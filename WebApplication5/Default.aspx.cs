using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txt1.Text = "4";
        }

        protected void hdot_ValueChanged(object sender, EventArgs e)
        {
            hdot.Value = "3";
            lbltt.Text = "test ok";
        }
        protected void txt1_TextChanged1(object sender, EventArgs e)
        {
            hdot.Value = txt1.Text;
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            txt1.Text = "6";
        }
    }
}