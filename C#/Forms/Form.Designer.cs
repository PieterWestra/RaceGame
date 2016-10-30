namespace Forms
{
    partial class Form
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
			this.components = new System.ComponentModel.Container();
			this.pnlCanvas = new System.Windows.Forms.Panel();
			this.Car1_Bar = new System.Windows.Forms.ProgressBar();
			this.Car2_Bar = new System.Windows.Forms.ProgressBar();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblForce = new System.Windows.Forms.Label();
			this.lblXmult = new System.Windows.Forms.Label();
			this.lblYmult = new System.Windows.Forms.Label();
			this.lblAngle = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tmrMoving = new System.Windows.Forms.Timer(this.components);
			this.lbltest = new System.Windows.Forms.Label();
			this.lblCarLoc = new System.Windows.Forms.Label();
			this.pnlCanvas.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlCanvas
			// 
			this.pnlCanvas.Controls.Add(this.lblCarLoc);
			this.pnlCanvas.Controls.Add(this.lbltest);
			this.pnlCanvas.Controls.Add(this.Car1_Bar);
			this.pnlCanvas.Controls.Add(this.Car2_Bar);
			this.pnlCanvas.Controls.Add(this.label4);
			this.pnlCanvas.Controls.Add(this.label3);
			this.pnlCanvas.Controls.Add(this.label2);
			this.pnlCanvas.Controls.Add(this.label1);
			this.pnlCanvas.Controls.Add(this.lblForce);
			this.pnlCanvas.Controls.Add(this.lblXmult);
			this.pnlCanvas.Controls.Add(this.lblYmult);
			this.pnlCanvas.Controls.Add(this.lblAngle);
			this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlCanvas.Location = new System.Drawing.Point(0, 0);
			this.pnlCanvas.Name = "pnlCanvas";
			this.pnlCanvas.Size = new System.Drawing.Size(752, 583);
			this.pnlCanvas.TabIndex = 0;
			this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
			// 
			// Car1_Bar
			// 
			this.Car1_Bar.Location = new System.Drawing.Point(12, 74);
			this.Car1_Bar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Car1_Bar.Maximum = 10;
			this.Car1_Bar.Name = "Car1_Bar";
			this.Car1_Bar.Size = new System.Drawing.Size(75, 19);
			this.Car1_Bar.TabIndex = 10;
			// 
			// Car2_Bar
			// 
			this.Car2_Bar.Location = new System.Drawing.Point(664, 74);
			this.Car2_Bar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Car2_Bar.Maximum = 10;
			this.Car2_Bar.Name = "Car2_Bar";
			this.Car2_Bar.Size = new System.Drawing.Size(75, 19);
			this.Car2_Bar.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new System.Drawing.Point(662, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "label1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(662, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(662, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "label1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(662, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "label1";
			// 
			// lblForce
			// 
			this.lblForce.AutoSize = true;
			this.lblForce.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblForce.Location = new System.Drawing.Point(10, 22);
			this.lblForce.Name = "lblForce";
			this.lblForce.Size = new System.Drawing.Size(44, 13);
			this.lblForce.TabIndex = 4;
			this.lblForce.Text = "lblForce";
			// 
			// lblXmult
			// 
			this.lblXmult.AutoSize = true;
			this.lblXmult.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblXmult.Location = new System.Drawing.Point(10, 35);
			this.lblXmult.Name = "lblXmult";
			this.lblXmult.Size = new System.Drawing.Size(43, 13);
			this.lblXmult.TabIndex = 3;
			this.lblXmult.Text = "lblXmult";
			// 
			// lblYmult
			// 
			this.lblYmult.AutoSize = true;
			this.lblYmult.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblYmult.Location = new System.Drawing.Point(10, 48);
			this.lblYmult.Name = "lblYmult";
			this.lblYmult.Size = new System.Drawing.Size(43, 13);
			this.lblYmult.TabIndex = 2;
			this.lblYmult.Text = "lblYmult";
			// 
			// lblAngle
			// 
			this.lblAngle.AutoSize = true;
			this.lblAngle.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblAngle.Location = new System.Drawing.Point(10, 9);
			this.lblAngle.Name = "lblAngle";
			this.lblAngle.Size = new System.Drawing.Size(44, 13);
			this.lblAngle.TabIndex = 1;
			this.lblAngle.Text = "lblAngle";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// tmrMoving
			// 
			this.tmrMoving.Enabled = true;
			this.tmrMoving.Interval = 18;
			this.tmrMoving.Tick += new System.EventHandler(this.tmrMoving_Tick);
			// 
			// lbltest
			// 
			this.lbltest.AutoSize = true;
			this.lbltest.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lbltest.Location = new System.Drawing.Point(12, 105);
			this.lbltest.Name = "lbltest";
			this.lbltest.Size = new System.Drawing.Size(35, 13);
			this.lbltest.TabIndex = 11;
			this.lbltest.Text = "label5";
			// 
			// lblCarLoc
			// 
			this.lblCarLoc.AutoSize = true;
			this.lblCarLoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblCarLoc.Location = new System.Drawing.Point(12, 127);
			this.lblCarLoc.Name = "lblCarLoc";
			this.lblCarLoc.Size = new System.Drawing.Size(35, 13);
			this.lblCarLoc.TabIndex = 13;
			this.lblCarLoc.Text = "label5";
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(752, 583);
			this.Controls.Add(this.pnlCanvas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RaceGame";
			this.Load += new System.EventHandler(this.Form_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_KeyUp);
			this.pnlCanvas.ResumeLayout(false);
			this.pnlCanvas.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Timer tmrMoving;
		private System.Windows.Forms.Label lblAngle;
		private System.Windows.Forms.Label lblForce;
		private System.Windows.Forms.Label lblXmult;
		private System.Windows.Forms.Label lblYmult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar Car1_Bar;
        private System.Windows.Forms.ProgressBar Car2_Bar;
		private System.Windows.Forms.Label lbltest;
		private System.Windows.Forms.Label lblCarLoc;
	}
}

