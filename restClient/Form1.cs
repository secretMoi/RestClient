using System;
using System.Windows.Forms;

namespace restClient
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonGo_Click(object sender, EventArgs e)
		{
			RestClient client = new RestClient
			{
				EndPoint = textBoxUri.Text
			};

			string response = client.MakeRequest();
			textBoxResponse.Text = response;
		}


	}
}
