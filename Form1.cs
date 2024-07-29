namespace PRG455LAB_4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void btnBegin_Click(object sender, EventArgs e)
		{
			this.Hide();
			UserDetailForm userDetailForm = new UserDetailForm();
			userDetailForm.Closed += (s, args) => this.Close();
			userDetailForm.Show();
		}
	}
}
