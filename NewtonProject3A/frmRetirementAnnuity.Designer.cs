namespace ProjectPlutoCalculator
{
	partial class frmRetirementAnnuity
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.grbxRetAnnuity = new System.Windows.Forms.GroupBox();
			this.btnCalcRetAnu = new System.Windows.Forms.Button();
			this.retAnuPVLabel = new System.Windows.Forms.Label();
			this.retAnuNumPerLable = new System.Windows.Forms.Label();
			this.retAnuRateLabel = new System.Windows.Forms.Label();
			this.retAnuPymtLabel = new System.Windows.Forms.Label();
			this.retAnuPVbox = new System.Windows.Forms.TextBox();
			this.retAnuNumPerBox = new System.Windows.Forms.TextBox();
			this.retAnuRateBox = new System.Windows.Forms.TextBox();
			this.retAnuPymtBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.grbxRetAnnuity.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Black;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1114, 794);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// grbxRetAnnuity
			// 
			this.grbxRetAnnuity.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.grbxRetAnnuity.Controls.Add(this.btnCalcRetAnu);
			this.grbxRetAnnuity.Controls.Add(this.retAnuPVLabel);
			this.grbxRetAnnuity.Controls.Add(this.retAnuNumPerLable);
			this.grbxRetAnnuity.Controls.Add(this.retAnuRateLabel);
			this.grbxRetAnnuity.Controls.Add(this.retAnuPymtLabel);
			this.grbxRetAnnuity.Controls.Add(this.retAnuPVbox);
			this.grbxRetAnnuity.Controls.Add(this.retAnuNumPerBox);
			this.grbxRetAnnuity.Controls.Add(this.retAnuRateBox);
			this.grbxRetAnnuity.Controls.Add(this.retAnuPymtBox);
			this.grbxRetAnnuity.Location = new System.Drawing.Point(446, 40);
			this.grbxRetAnnuity.Name = "grbxRetAnnuity";
			this.grbxRetAnnuity.Size = new System.Drawing.Size(613, 632);
			this.grbxRetAnnuity.TabIndex = 1;
			this.grbxRetAnnuity.TabStop = false;
			// 
			// btnCalcRetAnu
			// 
			this.btnCalcRetAnu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCalcRetAnu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcRetAnu.Location = new System.Drawing.Point(210, 490);
			this.btnCalcRetAnu.Name = "btnCalcRetAnu";
			this.btnCalcRetAnu.Size = new System.Drawing.Size(252, 63);
			this.btnCalcRetAnu.TabIndex = 3;
			this.btnCalcRetAnu.Text = "CALCULATE";
			this.btnCalcRetAnu.UseVisualStyleBackColor = false;
			this.btnCalcRetAnu.Click += new System.EventHandler(this.btnCalcRetAnu_Click);
			// 
			// retAnuPVLabel
			// 
			this.retAnuPVLabel.AutoSize = true;
			this.retAnuPVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.retAnuPVLabel.Location = new System.Drawing.Point(38, 389);
			this.retAnuPVLabel.Name = "retAnuPVLabel";
			this.retAnuPVLabel.Size = new System.Drawing.Size(226, 37);
			this.retAnuPVLabel.TabIndex = 7;
			this.retAnuPVLabel.Text = "Present Value:";
			// 
			// retAnuNumPerLable
			// 
			this.retAnuNumPerLable.AutoSize = true;
			this.retAnuNumPerLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.retAnuNumPerLable.Location = new System.Drawing.Point(33, 261);
			this.retAnuNumPerLable.Name = "retAnuNumPerLable";
			this.retAnuNumPerLable.Size = new System.Drawing.Size(294, 37);
			this.retAnuNumPerLable.TabIndex = 6;
			this.retAnuNumPerLable.Text = "Number of Periods:";
			// 
			// retAnuRateLabel
			// 
			this.retAnuRateLabel.AutoSize = true;
			this.retAnuRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.retAnuRateLabel.Location = new System.Drawing.Point(33, 159);
			this.retAnuRateLabel.Name = "retAnuRateLabel";
			this.retAnuRateLabel.Size = new System.Drawing.Size(310, 37);
			this.retAnuRateLabel.TabIndex = 5;
			this.retAnuRateLabel.Text = "Rate Per Period (%):";
			// 
			// retAnuPymtLabel
			// 
			this.retAnuPymtLabel.AutoSize = true;
			this.retAnuPymtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.retAnuPymtLabel.Location = new System.Drawing.Point(33, 62);
			this.retAnuPymtLabel.Name = "retAnuPymtLabel";
			this.retAnuPymtLabel.Size = new System.Drawing.Size(151, 37);
			this.retAnuPymtLabel.TabIndex = 4;
			this.retAnuPymtLabel.Text = "Payment:";
			// 
			// retAnuPVbox
			// 
			this.retAnuPVbox.Location = new System.Drawing.Point(370, 395);
			this.retAnuPVbox.Name = "retAnuPVbox";
			this.retAnuPVbox.ReadOnly = true;
			this.retAnuPVbox.Size = new System.Drawing.Size(225, 31);
			this.retAnuPVbox.TabIndex = 3;
			this.retAnuPVbox.TabStop = false;
			// 
			// retAnuNumPerBox
			// 
			this.retAnuNumPerBox.Location = new System.Drawing.Point(370, 267);
			this.retAnuNumPerBox.Name = "retAnuNumPerBox";
			this.retAnuNumPerBox.Size = new System.Drawing.Size(225, 31);
			this.retAnuNumPerBox.TabIndex = 2;
			// 
			// retAnuRateBox
			// 
			this.retAnuRateBox.Location = new System.Drawing.Point(370, 159);
			this.retAnuRateBox.Name = "retAnuRateBox";
			this.retAnuRateBox.Size = new System.Drawing.Size(225, 31);
			this.retAnuRateBox.TabIndex = 1;
			// 
			// retAnuPymtBox
			// 
			this.retAnuPymtBox.Location = new System.Drawing.Point(370, 68);
			this.retAnuPymtBox.Name = "retAnuPymtBox";
			this.retAnuPymtBox.Size = new System.Drawing.Size(225, 31);
			this.retAnuPymtBox.TabIndex = 0;
			// 
			// frmRetirementAnnuity
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1114, 794);
			this.Controls.Add(this.grbxRetAnnuity);
			this.Controls.Add(this.pictureBox1);
			this.Name = "frmRetirementAnnuity";
			this.Text = "Retirement Annuity Calculator";
			this.Load += new System.EventHandler(this.frmRetirementAnnuity_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.grbxRetAnnuity.ResumeLayout(false);
			this.grbxRetAnnuity.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox grbxRetAnnuity;
		private System.Windows.Forms.Label retAnuPymtLabel;
		private System.Windows.Forms.TextBox retAnuPVbox;
		private System.Windows.Forms.TextBox retAnuNumPerBox;
		private System.Windows.Forms.TextBox retAnuRateBox;
		private System.Windows.Forms.TextBox retAnuPymtBox;
		private System.Windows.Forms.Button btnCalcRetAnu;
		private System.Windows.Forms.Label retAnuPVLabel;
		private System.Windows.Forms.Label retAnuNumPerLable;
		private System.Windows.Forms.Label retAnuRateLabel;
	}
}