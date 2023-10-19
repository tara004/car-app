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
            lblAutoStatus = new Label();
            btnStart = new Button();
            btnAccelerate = new Button();
            pbaSpeed = new ProgressBar();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblAutoStatus
            // 
            lblAutoStatus.AutoSize = true;
            lblAutoStatus.Location = new Point(28, 116);
            lblAutoStatus.Margin = new Padding(2, 0, 2, 0);
            lblAutoStatus.Name = "lblAutoStatus";
            lblAutoStatus.Size = new Size(50, 20);
            lblAutoStatus.TabIndex = 0;
            lblAutoStatus.Text = "label1";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(28, 30);
            btnStart.Margin = new Padding(2, 2, 2, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(97, 54);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnAccelerate
            // 
            btnAccelerate.Location = new Point(143, 30);
            btnAccelerate.Margin = new Padding(2, 2, 2, 2);
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
            pbaSpeed.Margin = new Padding(2, 2, 2, 2);
            pbaSpeed.Name = "pbaSpeed";
            pbaSpeed.Size = new Size(436, 29);
            pbaSpeed.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(338, 30);
            button1.Name = "button1";
            button1.Size = new Size(94, 54);
            button1.TabIndex = 4;
            button1.Text = "decelera";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 281);
            Controls.Add(button1);
            Controls.Add(pbaSpeed);
            Controls.Add(btnAccelerate);
            Controls.Add(btnStart);
            Controls.Add(lblAutoStatus);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAutoStatus;
        private Button btnStart;
        private Button btnAccelerate;
        private ProgressBar pbaSpeed;
        private Button button1;
    }
}