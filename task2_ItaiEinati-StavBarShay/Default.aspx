<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head >
<body dir="rtl" lang="he" style="font-family: Arial;">
    <form id="form1" runat="server">
        <div>
            שם המשחק -
            <asp:TextBox ID="gameName" runat="server"></asp:TextBox>
            <br />
            <br />
            גוף השאלה -&nbsp;&nbsp;
            <asp:TextBox ID="Qtxt" runat="server"></asp:TextBox>
            <br />
            <br />
            תמונה כחלק מגוף השאלה -&nbsp;
            <asp:TextBox ID="picQtxt" runat="server"></asp:TextBox>
            <br />
            <br />
            זמן מענה לשאלה -
            <asp:TextBox ID="timeTxt" runat="server"></asp:TextBox>
            <br />
            <strong>
            <br />
            </strong>התשובה הנכונה היא - <span>
                <asp:RadioButtonList ID="correctAnswer" runat="server" Width="822px" RepeatDirection="Horizontal" Style="display: inline-block; margin-top: 0px;">
                    <asp:ListItem Value="0">אפשרות תשובה 1</asp:ListItem>
                    <asp:ListItem Value="1">אפשרות תשובה 2</asp:ListItem>
                    <asp:ListItem Value="2">אפשרות תשובה 3</asp:ListItem>
                    <asp:ListItem Value="3">אפשרות תשובה 4</asp:ListItem>
                </asp:RadioButtonList>
            <br />
            <br />
            <br />
            אפשרות תשובה 1 - <asp:TextBox ID="option0" runat="server"></asp:TextBox>
            <br />
            אפשרות תשובה 2 -
            <asp:TextBox ID="option1" runat="server"></asp:TextBox>
            <br />
            אפשרות תשובה 3 -
            <asp:TextBox ID="option2" runat="server"></asp:TextBox>
            <br />
            אפשרות תשובה 4 -
            </span>
            <asp:TextBox ID="option3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="typeXML" runat="server" Text="הזן מידע לקובץ XML" OnClick="typeXML_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="printXML" runat="server" Text="הדפס XML" OnClick="printXML_Click" />
            &nbsp;
            <br />
            <br />


            <asp:TextBox ID="myXmlText" runat="server" Height="315px" TextMode="MultiLine" Width="423px"></asp:TextBox>
            <br />
        </div>
    </form>
</body>
</html>
