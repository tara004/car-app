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

        #region Event management

        private void btnStart_Click(object sender, EventArgs e)
        {
            TurnOnAuto();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            TurnOffAuto();
        }
        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            this.Accelera(10);
        }
        private void btnDeccelerate_Click(object sender, EventArgs e)
        {
            this.decellera(10);
        }
        private void btnFuel_Click(object sender, EventArgs e)
        {
            this.Fuel();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            this.Auto.Refill(1);
            this.lblAutoStatus.Text = this.Auto.marca;
            this.pbaSpeed.Minimum = 0;
            this.pbaSpeed.Maximum = this.Auto.maximumSpeed;
            this.pbaFuel.Value = this.Auto.livelloCarburante;
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

        private void TurnOffAuto()
        {
            string status;

            Auto.TurnOff();

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
        private void Accelera(int value)
        {
            this.Auto.Accelerate(value);
            this.pbaSpeed.Value = this.Auto.speed;
        }
        private void decellera(int value)
        {
            this.Auto.Decelerate(value);
            this.pbaSpeed.Value = this.Auto.speed;
        }
        public void Fuel()
        {
            this.Auto.Refill(10);
            this.pbaFuel.Value = this.Auto.livelloCarburante;
        }

        #endregion

        private void pbaFuel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            this.decellera(5);
            timer1.Interval = 1000; // Imposta l'intervallo a 1 secondo
            timer1.Enabled = true;  // Avvia il timer
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
#endregion