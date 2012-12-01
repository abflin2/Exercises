using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;

namespace MandMReg
{
	public partial class UserList : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void SearchButton_Click(object sender, EventArgs e)
		{
			XmlDocument userDoc = GetXMLDoc();

			XmlNode oXmlRootNode = userDoc.SelectSingleNode("records");
			int recordCount = oXmlRootNode.ChildNodes.Count;

			XmlNode record;
			bool found = false;
			for (int i = 0; i < recordCount; i++)
			{
				XmlNode node = oXmlRootNode.ChildNodes.Item(i);
				XmlNode child = node.ChildNodes.Item(2);

				if (child.InnerText.Equals(SearchBox.Text.ToLower().Trim()))
				{
					record = node;

					First.Text = record.ChildNodes.Item(0).InnerText;
					Last.Text = record.ChildNodes.Item(1).InnerText;
					Email.Text = record.ChildNodes.Item(2).InnerText;
					Adress.Text = record.ChildNodes.Item(4).InnerText;
					City.Text = record.ChildNodes.Item(5).InnerText;
					State.Text = record.ChildNodes.Item(6).InnerText;
					ZipCode.Text = record.ChildNodes.Item(7).InnerText;

					found = true;
					break;
				}
			}

			if (found)
			{
				Panel2.Visible = false;
				Panel1.Visible = true;
			}

			else
			{
				Panel2.Visible = true;
				Panel1.Visible = false;
			}
		}


		protected void SearchBox_TextChanged(object sender, EventArgs e)
		{

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
	}
}
