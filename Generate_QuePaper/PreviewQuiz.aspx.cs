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
    public partial class PreviewQuiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = Session["QuizQuestions"] as DataTable;
                if (dt != null)
                {
                    rptPreviewQuiz.DataSource = dt;
                    rptPreviewQuiz.DataBind();
                }
                else
                {
                    // Handle the case where the session variable is null
                    Response.Write("No quiz data available.");
                }
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("DisplayQuiz.aspx");
        }
        protected void rptPreviewQuiz_ItemCommand(object source, RepeaterCommandEventArgs e)
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