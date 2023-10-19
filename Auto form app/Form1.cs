namespace Auto_form_app
{
	public partial class Form1 : Form
	{

		private app_auto.Auto Auto;

		public Form1()
		{
			InitializeComponent();

			this.Load += this.OnLoad;
		}

		private void OnLoad(object sender, EventArgs e){
			this.Auto = new app_auto.Auto();
			this.lblAutoStatus.Text = this.Auto.marca;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			TurnOnAuto();
		}

		private void TurnOnAuto()
		{
			string status;

			Auto.TurnOn();

			if (this.Auto.accesa){
				status = "accesa";
			} else{
				status = "spenta";
			}
			this.lblAutoStatus.Text = status;
		}
	}
}