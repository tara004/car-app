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
			this.lblAutoStatus = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnAccelerate = new System.Windows.Forms.Button();
			this.pbaSpeed = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// lblAutoStatus
			// 
			this.lblAutoStatus.AutoSize = true;
			this.lblAutoStatus.Location = new System.Drawing.Point(46, 185);
			this.lblAutoStatus.Name = "lblAutoStatus";
			this.lblAutoStatus.Size = new System.Drawing.Size(78, 32);
			this.lblAutoStatus.TabIndex = 0;
			this.lblAutoStatus.Text = "label1";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(46, 48);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(157, 86);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnAccelerate
			// 
			this.btnAccelerate.Location = new System.Drawing.Point(232, 48);
			this.btnAccelerate.Name = "btnAccelerate";
			this.btnAccelerate.Size = new System.Drawing.Size(157, 86);
			this.btnAccelerate.TabIndex = 2;
			this.btnAccelerate.Text = "Accelerate";
			this.btnAccelerate.UseVisualStyleBackColor = true;
			this.btnAccelerate.Click += new System.EventHandler(this.btnAccelerate_Click);
			// 
			// pbaSpeed
			// 
			this.pbaSpeed.Location = new System.Drawing.Point(46, 236);
			this.pbaSpeed.Name = "pbaSpeed";
			this.pbaSpeed.Size = new System.Drawing.Size(708, 46);
			this.pbaSpeed.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pbaSpeed);
			this.Controls.Add(this.btnAccelerate);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.lblAutoStatus);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label lblAutoStatus;
		private Button btnStart;
		private Button btnAccelerate;
		private ProgressBar pbaSpeed;
	}
}