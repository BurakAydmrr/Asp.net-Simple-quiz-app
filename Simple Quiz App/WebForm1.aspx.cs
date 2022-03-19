using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Table1.BorderWidth = 2;
            Table1.BorderColor = System.Drawing.Color.Brown;
            TableHeaderRow tbheader = new TableHeaderRow();
            tbheader.BorderColor = System.Drawing.Color.Red;
            TableHeaderCell thCell0 = new TableHeaderCell();
            TableHeaderCell thCell1 = new TableHeaderCell();
            TableHeaderCell thCell2 = new TableHeaderCell();
            TableHeaderCell thCell3 = new TableHeaderCell();
            TableHeaderCell thCell4 = new TableHeaderCell();
            thCell0.Text = "DERSLER";
            thCell1.Text = "sınav 1 ";
            thCell2.Text = "sınav 2 ";
            thCell3.Text = "sınav 3 ";
            thCell4.Text = "ortlama ";
            tbheader.Cells.Add(thCell0);
            tbheader.Cells.Add(thCell1);
            tbheader.Cells.Add(thCell2);
            tbheader.Cells.Add(thCell3);
            tbheader.Cells.Add(thCell4);

            Table1.Rows.Add(tbheader);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1.myArray.Add(tbsayi2.Text + "," + tbsayi3.Text + "," + tbsayi4.Text);
            int say = 0;
            foreach (string temp in Class1.myArray)
            {

                string[] words = temp.Split(',');

                //TableCell tbCell0 = new TableCell();
                TableRow tbRow = new TableRow();
                /* if (say == 0) { tbCell0.Text = "MAT"; }
                 if (say == 1) { tbCell0.Text = "EDEBİYAY"; }
                 if (say == 2) { tbCell0.Text = "WEB"; }
                 if (say == 3) { tbCell0.Text = "ALİ"; }
                 say++;
                */
                
                TableCell tbCell0 = new TableCell(); tbCell0.Text = tbsayi1.Text;

           

                TableCell tbCell1 = new TableCell(); tbCell1.Text = words[0];
                TableCell tbCell2 = new TableCell(); tbCell2.Text = words[1];
                TableCell tbCell3 = new TableCell(); tbCell3.Text = words[2];
                TableCell tbCell4 = new TableCell(); tbCell4.Text = "";
                TableCell tbCell5 = new TableCell(); tbCell5.Text = ((int.Parse(words[0]) + int.Parse(words[1]) + int.Parse(words[2])) / 3).ToString();



                tbRow.Cells.Add(tbCell0);
                tbRow.Cells.Add(tbCell1);
                tbRow.Cells.Add(tbCell2);
                tbRow.Cells.Add(tbCell3);
                tbRow.Cells.Add(tbCell4);
                tbRow.Cells.Add(tbCell5);


                Table1.Rows.Add(tbRow);



            }







        }
    }
}