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
			this.label1.Text = this.Auto.marca;
		}
	}
}