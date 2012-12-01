using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PennyGameWeb
{
	public partial class _default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void PennyLaunch_Click(object sender, EventArgs e)
		{
			PopUp("Popup.aspx");
		}

		public void PopUp(string url)
		{
			string popup = "<script language='javascript'>" +
						   "window.open('" + url + "', 'CustomPopUp', " +
						   "'width=200, height=200, resizable=no')" +
						   "</script>";

			//Page.RegisterStartupScript("Popup", popup);
			ClientScript.RegisterStartupScript(this.GetType(),"Popup", popup);
		}

	}
}