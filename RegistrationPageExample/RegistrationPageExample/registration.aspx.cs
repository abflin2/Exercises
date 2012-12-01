using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.OleDb;

namespace RegistrationPageExample
{
	public partial class registration : System.Web.UI.Page
	{

		protected void Page_Load(object sender, EventArgs e)
		{
		

			
		}

		protected void RegistrationSubmit_Click(object sender, EventArgs e)
		{

			this.RegistrationInsert.Insert();

		}

		protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}