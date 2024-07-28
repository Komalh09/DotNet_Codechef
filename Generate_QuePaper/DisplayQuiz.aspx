<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayQuiz.aspx.cs" Inherits="QuestionPaper.DisplayQuiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
         <center>
         <div>     
               <asp:Button ID="btnGeneratePaper" runat="server" Text="Generate Paper" OnClick="btnGeneratePaper_Click" />    
       </div>
        </center>

        <asp:Repeater ID="rptQuiz" runat="server" OnItemCommand="rptQuiz_ItemCommand">
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

         <center>
            <div>
                <asp:Button ID="btnPreview" runat="server" Text="Preview" OnClick="btnPreview_Click" />
            </div>
        </center>

         <asp:SqlDataSource runat="server" ID="SqlDataSource1"></asp:SqlDataSource>
     </form>
</body>
</html>
