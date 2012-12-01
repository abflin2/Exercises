using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlTypes;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data.SqlClient;
using System.Data;
using System.Xml;



namespace MandMReg.Account
{
	public partial class Registration : System.Web.UI.Page
	{

		protected void Page_Load(object sender, EventArgs e)
		{

		}


		protected void RegisterBtn_Click(object sender, EventArgs e)
		{

			#region No_validation_Errors
			if (Page.IsValid)
			{
				string user_first = FirstName.Text;
				string user_last = LastName.Text;
				string user_email = Email.Text.Trim();
				string user_password = Password.Text;
				string user_address = Address.Text;
				string user_city = City.Text;
				string user_state = State.Text;
				string user_zip = ZipCode.Text;

				GetXMLDoc();

				XmlDocument oXmlDocument = GetXMLDoc();


				XmlNode oXmlRootNode = oXmlDocument.SelectSingleNode("records");
				int recordCount = oXmlRootNode.ChildNodes.Count;
				bool unique = true;
				if (recordCount > 0)
				{
					for (int i = 0; i < recordCount; i++)
					{
						XmlNode node = oXmlRootNode.ChildNodes.Item(i);
						XmlNode child = node.ChildNodes.Item(2);
						if (child.InnerText.Equals(user_email))
						{
							unique = false;
							break;
						}
					}
				}

				#region addRow
				if (unique)
				{
					XmlNode oXmlRecordNode = oXmlRootNode.AppendChild(
						oXmlDocument.CreateNode(XmlNodeType.Element, "record", ""));
					oXmlRecordNode.AppendChild(oXmlDocument.CreateNode(XmlNodeType.Element,
						"First_Name", "")).InnerText = user_first;
					oXmlRecordNode.AppendChild(oXmlDocument.CreateNode(XmlNodeType.Element,
						"Last_Name", "")).InnerText = user_last;
					oXmlRecordNode.AppendChild(oXmlDocument.CreateNode(XmlNodeType.Element,
						"Email", "")).InnerText = user_email.ToLower().Trim();
					oXmlRecordNode.AppendChild(oXmlDocument.CreateNode(XmlNodeType.Element,
						"Password", "")).InnerText = user_password;
					oXmlRecordNode.AppendChild(oXmlDocument.CreateNode(XmlNodeType.Element,
						 "Address", "")).InnerText = user_address;
					oXmlRecordNode.AppendChild(oXmlDocument.CreateNode(XmlNodeType.Element,
						"City", "")).InnerText = user_city;
					oXmlRecordNode.AppendChild(oXmlDocument.CreateNode(XmlNodeType.Element,
						"State", "")).InnerText = user_state;
					oXmlRecordNode.AppendChild(oXmlDocument.CreateNode(XmlNodeType.Element,
						"ZipCode", "")).InnerText = user_zip;

					oXmlDocument.Save("Users.xml");
					FirstName.Text = "";
					LastName.Text = "";
					Email.Text = "";
					Address.Text = "";
					City.Text = "";
					State.Text = "";
					ZipCode.Text = "";

					Success.Visible = true;
				}
				#endregion

				else
				{
					RegistrationValidationSummary.Enabled = true;
					Page.Validate();
				}
			}
			#endregion

			else
			{
				Success.Visible = false;
			}
		}



		protected void EmailMustBeUnique_ServerValidate(object source, ServerValidateEventArgs args)
		{
			XmlDocument oXmlDocument = GetXMLDoc();
			XmlNode oXmlRootNode = oXmlDocument.SelectSingleNode("records");
			int recordCount = oXmlRootNode.ChildNodes.Count;

			for (int i = 0; i < recordCount; i++)
			{
				XmlNode node = oXmlRootNode.ChildNodes.Item(i);
				XmlNode child = node.ChildNodes.Item(2);
				if (child.InnerText.Equals(Email.Text.Trim()))
				{
					args.IsValid = false;
					Success.Visible = false;
				}
			}
		}

		protected XmlDocument GetXMLDoc()
		{
			XmlDocument oXmlDocument = new XmlDocument();

			if (!File.Exists("Users.xml"))
			{
				string[] xmlfile = new string[3];
				xmlfile[0] = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>";
				xmlfile[1] = "<records>";
				xmlfile[2] = "</records>";
				File.WriteAllLines("Users.xml", xmlfile);
			}
			oXmlDocument.Load("Users.xml");

			return oXmlDocument;
		}

		protected void VerifyPassword_TextChanged(object sender, EventArgs e)
		{

		}
	}
}