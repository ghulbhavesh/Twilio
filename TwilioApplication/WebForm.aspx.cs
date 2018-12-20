using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TwilioApplication
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] integerarray = { 1, 2, 3, 4 };
            for (int i = 0; i < integerarray.Length; i++)
            {
                int value = i;
            }
        }
    }
}