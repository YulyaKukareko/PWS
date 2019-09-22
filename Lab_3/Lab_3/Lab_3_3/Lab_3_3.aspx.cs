using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_3_3
{
    public partial class Lab_3_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //float x, y, z;
                //if(Single.TryParse(this.TextBox1.Text, out x) 
                //    && Single.TryParse(this.TextBox2.Text, out y))
                //{
                //    z = x + y;
                //    this.TextBox3.Text = z.ToString();
                //}
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float x, y, z;
            if(Single.TryParse(this.TextBox1.Text, out x)
                && Single.TryParse(this.TextBox2.Text, out y))
            {
                z = x + y;
                this.TextBox3.Text = z.ToString();
            } else {
                throw new ApplicationException("My Error");
            }
            CheckBox1.Checked = true;
            RadioButton2.Checked = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            float x, y, z;
            if(Single.TryParse(this.TextBox5.Text, out x)
                && Single.TryParse(this.TextBox6.Text, out y))
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(15));
                z = x * y;
                this.TextBox7.Text = z.ToString();
            }
        }

        protected void ScriptManager1_AsyncPostBackError(object sender, AsyncPostBackErrorEventArgs e)
        {
            this.ScriptManager1.AsyncPostBackErrorMessage = "My error text";
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            float x, y, z;
            if(Single.TryParse(this.TextBox1.Text, out x)
                && Single.TryParse(this.TextBox2.Text, out y)){
                z = x + y;
                this.TextBox3.Text = z.ToString();
            }
        }

        protected void Timer2_Tick(object sender, EventArgs e)
        {
            float x, y, z;
            if (Single.TryParse(this.TextBox5.Text, out x)
                && Single.TryParse(this.TextBox6.Text, out y))
            {
                z = x * y;
                this.TextBox7.Text = z.ToString();
            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.RadioButton2.Checked = true;
        }
    }
}