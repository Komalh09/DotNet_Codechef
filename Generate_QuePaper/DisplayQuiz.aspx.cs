using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuestionPaper
{
    public partial class DisplayQuiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = Session["QuizQuestions"] as DataTable;
                if (dt != null)
                {
                    rptQuiz.DataSource = dt;
                    rptQuiz.DataBind();
                }
                else
                {
                    // Handle the case where the session variable is null
                    Response.Write("No quiz data available.");
                }
            }

        }
        protected void btnGeneratePaper_Click(object sender, EventArgs e)
        {
            DataTable dt = GetRandomQuestions();

            if (dt != null && dt.Rows.Count > 0)
            {
                Session["QuizQuestions"] = dt;
                Response.Redirect("DisplayQuiz.aspx");
            }
            else
            {
                // Handle the case where no questions are retrieved
                Response.Write("No questions available.");
            }
        }

        private DataTable GetRandomQuestions()
        {
            DataTable dt = new DataTable();

            // Ensure the connection string name matches the one in your Web.config
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT TOP 5 q_id, q_text, option_A, option_B, option_C, option_D FROM Questions ORDER BY NEWID()";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        conn.Open();
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        protected void btnPreview_Click(object sender, EventArgs e)
        {
            Response.Redirect("PreviewQuiz.aspx");
        }

       

        protected void rptQuiz_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "ShowCorrectAnswer")
            {
                int questionId = Convert.ToInt32(e.CommandArgument);
                Label lblCorrectAnswer = (Label)e.Item.FindControl("lblCorrectAnswer");

                string correctAnswer = GetCorrectAnswer(questionId);
                lblCorrectAnswer.Text = "Correct Answer: " + correctAnswer;
                lblCorrectAnswer.Visible = true;
            }
        }

        private string GetCorrectAnswer(int questionId)
        {
            string correctAnswer = string.Empty;

            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["db1ConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT correctOption FROM Questions WHERE q_id = @q_id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@q_id", questionId);
                    conn.Open();

                    correctAnswer = cmd.ExecuteScalar()?.ToString();
                }
            }

            return correctAnswer;
        }
    }
}