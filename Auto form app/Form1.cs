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


        #region Event management

        private void btnStart_Click(object sender, EventArgs e)
        {
            TurnOnAuto();
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            this.Accelerate(10);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Initializes properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnLoad(object sender, EventArgs e)
        {
            this.Auto = new app_auto.Auto();
            this.Auto.Refill(100);
            this.lblAutoStatus.Text = this.Auto.marca;
            this.pbaSpeed.Minimum = 0;
            this.pbaSpeed.Maximum = this.Auto.maximumSpeed;
        }

        /// <summary>
        /// Turns on the car
        /// </summary>
        private void TurnOnAuto()
        {
            string status;

            Auto.TurnOn();

            //decode the status to create a string
            if (this.Auto.accesa)
            {
                status = "accesa";
            }
            else
            {
                status = "spenta";
            }

            //outputs the status
            this.lblAutoStatus.Text = status;
        }

        /// <summary>
        /// Accelerate the car
        /// </summary>
        /// <param name="value">Amount of speed to increase</param>
        private void Accelerate(int value)
        {
            this.Auto.Accelerate(value);
            this.pbaSpeed.Value = this.Auto.speed;
        }

        #endregion

        private void btnStop_Click(object sender, EventArgs e)
        {

        }
    }
}