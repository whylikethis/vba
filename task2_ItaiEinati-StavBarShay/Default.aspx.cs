using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml; // שורה שחייבת להיכתב בתחילת מסמך על מנת לדבר עם קובץ האקסמאל
using System.IO; // 

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void typeXML_Click(object sender, EventArgs e)
    {
        XmlTextWriter a = new XmlTextWriter(Server.MapPath("trees/game.xml"), System.Text.Encoding.UTF8);
        a.WriteStartDocument();
        a.WriteStartElement("game");
        a.WriteAttributeString("name", (gameName.Text));
        a.WriteAttributeString("time", (timeTxt.Text));
        a.WriteStartElement("question");
        a.WriteElementString("text", Qtxt.Text);
        a.WriteElementString("picture", picQtxt.Text);
        a.WriteStartElement("distractorsDetails");
        string mySelect = correctAnswer.SelectedValue;
        for (int i = 0; i < 4; i++)
        {
            if (mySelect != i.ToString())
            {
                mySelect = "inCorrect";
            }
            else
            {
                mySelect = "correct";
            }
            string textName = ((TextBox)FindControl("option" + i.ToString())).Text;
            a.WriteStartElement("option");
            a.WriteAttributeString("feedback", mySelect);
            a.WriteElementString("text", textName);
            a.WriteEndElement();
        }

        a.WriteEndElement();
        a.WriteEndElement();
        a.WriteEndElement();
        a.WriteEndDocument();
        a.Close();
    }

    protected void printXML_Click(object sender, EventArgs e)
    {
        MemoryStream ActivityStream = new MemoryStream();
        XmlTextWriter a = new XmlTextWriter(ActivityStream, System.Text.Encoding.UTF8);
        a.WriteStartDocument();
        a.WriteStartElement("game");
        a.WriteAttributeString("name", (gameName.Text));
        a.WriteAttributeString("time", (timeTxt.Text));
        a.WriteStartElement("question");
        a.WriteElementString("text", Qtxt.Text);
        a.WriteElementString("picture", picQtxt.Text);
        a.WriteStartElement("distractorsDetails");
        string mySelect = correctAnswer.SelectedValue;

        for (int i = 0; i < 4; i++)
        {
            if (mySelect != i.ToString())
            {
                mySelect = "inCorrect";
            }
            else
            {
                mySelect = "correct";
            }
            string textName = ((TextBox)FindControl("option" + i.ToString())).Text;
            a.WriteStartElement("option");
            a.WriteAttributeString("feedback", mySelect);
            a.WriteElementString("text", textName);
            a.WriteEndElement();
        }

        a.WriteEndElement();
        a.WriteEndElement();
        a.WriteEndElement();
        a.WriteEndDocument();
        a.Flush();
        ActivityStream.Position = 0;
        StreamReader reader = new StreamReader(ActivityStream);
        myXmlText.Text = reader.ReadToEnd();
        a.Close();
    }
}