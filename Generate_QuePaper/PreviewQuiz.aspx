<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PreviewQuiz.aspx.cs" Inherits="QuestionPaper.PreviewQuiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br></br>
      <center>
        <div>
       <asp:Button ID="btnBack" runat="server" Text="BACK" OnClick="btnBack_Click" />
       </div>
     </center>

        <div>
            <asp:Repeater ID="rptPreviewQuiz" runat="server" OnItemCommand="rptPreviewQuiz_ItemCommand">
            <ItemTemplate>
                <div>
                    <b>Question:</b> <%# Eval("q_text") %>
                    <ul>
                        <li>
                            <asp:RadioButton ID="rbOptionA" runat="server" GroupName='<%# Eval("q_id") %>' Text='<%# Eval("option_A") %>' /></li>
                        <li>
                            <asp:RadioButton ID="rbOptionB" runat="server" GroupName='<%# Eval("q_id") %>' Text='<%# Eval("option_B") %>' /></li>
                        <li>
                            <asp:RadioButton ID="rbOptionC" runat="server" GroupName='<%# Eval("q_id") %>' Text='<%# Eval("option_C") %>' /></li>
                        <li>
                            <asp:RadioButton ID="rbOptionD" runat="server" GroupName='<%# Eval("q_id") %>' Text='<%# Eval("option_D") %>' /></li>
                    </ul>

                    <asp:Button ID="btnCorrectAnswer" runat="server" Text="Correct Answer" CommandName="ShowCorrectAnswer" CommandArgument='<%# Eval("q_id") %>' />
                        <asp:Label ID="lblCorrectAnswer" runat="server" Visible="false"></asp:Label>

                </div>
            </ItemTemplate>
        </asp:Repeater>
        </div>
         
    </form>
</body>
</html>
