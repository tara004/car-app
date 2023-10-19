namespace Auto_form_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblAutoStatus = new Label();
            btnStart = new Button();
            btnAccelerate = new Button();
            pbaSpeed = new ProgressBar();
            btnStop = new Button();
            btnFuel = new Button();
            pbaFuel = new ProgressBar();
            btnExit = new Button();
            btnDeccelerate = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblAutoStatus
            // 
            lblAutoStatus.AutoSize = true;
            lblAutoStatus.Location = new Point(28, 116);
            lblAutoStatus.Margin = new Padding(2, 0, 2, 0);
            lblAutoStatus.Name = "lblAutoStatus";
            lblAutoStatus.Size = new Size(30, 20);
            lblAutoStatus.TabIndex = 0;
            lblAutoStatus.Text = "try ";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(28, 30);
            btnStart.Margin = new Padding(2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(97, 54);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnAccelerate
            // 
            btnAccelerate.Location = new Point(230, 30);
            btnAccelerate.Margin = new Padding(2);
            btnAccelerate.Name = "btnAccelerate";
            btnAccelerate.Size = new Size(97, 54);
            btnAccelerate.TabIndex = 2;
            btnAccelerate.Text = "Accelerate";
            btnAccelerate.UseVisualStyleBackColor = true;
            btnAccelerate.Click += btnAccelerate_Click;
            // 
            // pbaSpeed
            // 
            pbaSpeed.Location = new Point(28, 148);
            pbaSpeed.Margin = new Padding(2);
            pbaSpeed.Name = "pbaSpeed";
            pbaSpeed.Size = new Size(436, 29);
            pbaSpeed.TabIndex = 3;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(129, 30);
            btnStop.Margin = new Padding(2);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(97, 54);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnFuel
            // 
            btnFuel.Location = new Point(435, 30);
            btnFuel.Margin = new Padding(2);
            btnFuel.Name = "btnFuel";
            btnFuel.Size = new Size(97, 54);
            btnFuel.TabIndex = 5;
            btnFuel.Text = "E-Fuel";
            btnFuel.UseVisualStyleBackColor = true;
            btnFuel.Click += btnFuel_Click;
            // 
            // pbaFuel
            // 
            pbaFuel.Location = new Point(28, 200);
            pbaFuel.Margin = new Padding(2);
            pbaFuel.Name = "pbaFuel";
            pbaFuel.Size = new Size(436, 29);
            pbaFuel.TabIndex = 6;
            pbaFuel.Click += pbaFuel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(557, 301);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 54);
            btnExit.TabIndex = 7;
            btnExit.Text = "Tired";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDeccelerate
            // 
            btnDeccelerate.Location = new Point(332, 30);
            btnDeccelerate.Name = "btnDeccelerate";
            btnDeccelerate.Size = new Size(98, 54);
            btnDeccelerate.TabIndex = 8;
            btnDeccelerate.Text = "Deccelerate";
            btnDeccelerate.UseVisualStyleBackColor = true;
            btnDeccelerate.Click += btnDeccelerate_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 381);
            Controls.Add(btnDeccelerate);
            Controls.Add(btnExit);
            Controls.Add(pbaFuel);
            Controls.Add(btnFuel);
            Controls.Add(btnStop);
            Controls.Add(pbaSpeed);
            Controls.Add(btnAccelerate);
            Controls.Add(btnStart);
            Controls.Add(lblAutoStatus);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAutoStatus;
        private Button btnStart;
        private Button btnAccelerate;
        private ProgressBar pbaSpeed;
        private Button btnStop;
        private Button btnFuel;
        private ProgressBar pbaFuel;
        private Button btnExit;
        private Button btnDeccelerate;
        private System.Windows.Forms.Timer timer1;
    }
}