using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_1_2
{
    public partial class Task_22 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            myLabel.Text += "- Init -";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            myLabel.Text += "- Load -";
        }

        protected void Page_Prerender(object sender, EventArgs e)
        {
            myLabel.Text += "- Prerender -";
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            myLabel.Text += "- Unload -";
        }

        protected void Page_Disposed(object sender, EventArgs e)
        {
            myLabel.Text += "- Disposed -";
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            myLabel.Text += "- CheckBox -";
        }

        protected void Unnamed1_CheckedChanged(object sender, EventArgs e)
        {
            myLabel.Text += "- RadioButton -";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            myLabel.Text += "- Button -";
        }
    }
}