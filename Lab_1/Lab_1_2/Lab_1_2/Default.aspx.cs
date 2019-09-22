using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_1_2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            String s = Request["__VIEWSTATE"];
            this.Label1.Text = "[" + s.Length + "]" + "[" + this.TextBox1.Text.Length + "]";
        }
    }
}