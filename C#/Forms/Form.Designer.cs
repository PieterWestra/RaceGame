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
			this.Fuelbarcar2 = new System.Windows.Forms.ProgressBar();
			this.Fuelbarcar1 = new System.Windows.Forms.ProgressBar();
			this.lblRondencar2 = new System.Windows.Forms.Label();
			this.lblRondencar1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblTest = new System.Windows.Forms.Label();
			this.lblFuel2 = new System.Windows.Forms.Label();
			this.lblFuel1 = new System.Windows.Forms.Label();
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
			this.LBLRNDE = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tmrMoving = new System.Windows.Forms.Timer(this.components);
			this.lblCursor = new System.Windows.Forms.Label();
			this.pnlCanvas.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlCanvas
			// 
			this.pnlCanvas.Controls.Add(this.lblCursor);
			this.pnlCanvas.Controls.Add(this.Fuelbarcar2);
			this.pnlCanvas.Controls.Add(this.Fuelbarcar1);
			this.pnlCanvas.Controls.Add(this.lblRondencar2);
			this.pnlCanvas.Controls.Add(this.lblRondencar1);
			this.pnlCanvas.Controls.Add(this.label5);
			this.pnlCanvas.Controls.Add(this.lblTest);
			this.pnlCanvas.Controls.Add(this.lblFuel2);
			this.pnlCanvas.Controls.Add(this.lblFuel1);
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
			this.pnlCanvas.Controls.Add(this.LBLRNDE);
			this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlCanvas.Location = new System.Drawing.Point(0, 0);
			this.pnlCanvas.Name = "pnlCanvas";
			this.pnlCanvas.Size = new System.Drawing.Size(1004, 725);
			this.pnlCanvas.TabIndex = 0;
			this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
			// 
			// Fuelbarcar2
			// 
			this.Fuelbarcar2.Location = new System.Drawing.Point(918, 524);
			this.Fuelbarcar2.Margin = new System.Windows.Forms.Padding(2);
			this.Fuelbarcar2.Name = "Fuelbarcar2";
			this.Fuelbarcar2.Size = new System.Drawing.Size(75, 19);
			this.Fuelbarcar2.TabIndex = 18;
			// 
			// Fuelbarcar1
			// 
			this.Fuelbarcar1.Location = new System.Drawing.Point(64, 524);
			this.Fuelbarcar1.Margin = new System.Windows.Forms.Padding(2);
			this.Fuelbarcar1.Name = "Fuelbarcar1";
			this.Fuelbarcar1.Size = new System.Drawing.Size(75, 19);
			this.Fuelbarcar1.TabIndex = 17;
			// 
			// lblRondencar2
			// 
			this.lblRondencar2.AutoSize = true;
			this.lblRondencar2.Location = new System.Drawing.Point(568, 23);
			this.lblRondencar2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRondencar2.Name = "lblRondencar2";
			this.lblRondencar2.Size = new System.Drawing.Size(76, 13);
			this.lblRondencar2.TabIndex = 15;
			this.lblRondencar2.Text = "lblRondencar2";
			// 
			// lblRondencar1
			// 
			this.lblRondencar1.AutoSize = true;
			this.lblRondencar1.Location = new System.Drawing.Point(74, 24);
			this.lblRondencar1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRondencar1.Name = "lblRondencar1";
			this.lblRondencar1.Size = new System.Drawing.Size(76, 13);
			this.lblRondencar1.TabIndex = 14;
			this.lblRondencar1.Text = "lblRondencar1";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 102);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Geraakt?";
			// 
			// lblTest
			// 
			this.lblTest.AutoSize = true;
			this.lblTest.Location = new System.Drawing.Point(12, 81);
			this.lblTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTest.Name = "lblTest";
			this.lblTest.Size = new System.Drawing.Size(58, 13);
			this.lblTest.TabIndex = 13;
			this.lblTest.Text = "lblFuelTest";
			// 
			// lblFuel2
			// 
			this.lblFuel2.AutoSize = true;
			this.lblFuel2.Location = new System.Drawing.Point(863, 524);
			this.lblFuel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFuel2.Name = "lblFuel2";
			this.lblFuel2.Size = new System.Drawing.Size(43, 13);
			this.lblFuel2.TabIndex = 12;
			this.lblFuel2.Text = "lblFuel2";
			// 
			// lblFuel1
			// 
			this.lblFuel1.AutoSize = true;
			this.lblFuel1.Location = new System.Drawing.Point(7, 524);
			this.lblFuel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFuel1.Name = "lblFuel1";
			this.lblFuel1.Size = new System.Drawing.Size(43, 13);
			this.lblFuel1.TabIndex = 11;
			this.lblFuel1.Text = "lblFuel1";
			// 
			// Car1_Bar
			// 
			this.Car1_Bar.Location = new System.Drawing.Point(64, 556);
			this.Car1_Bar.Margin = new System.Windows.Forms.Padding(2);
			this.Car1_Bar.Maximum = 200;
			this.Car1_Bar.Name = "Car1_Bar";
			this.Car1_Bar.Size = new System.Drawing.Size(75, 19);
			this.Car1_Bar.TabIndex = 10;
			// 
			// Car2_Bar
			// 
			this.Car2_Bar.Location = new System.Drawing.Point(918, 555);
			this.Car2_Bar.Margin = new System.Windows.Forms.Padding(2);
			this.Car2_Bar.Maximum = 200;
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
			this.label3.Location = new System.Drawing.Point(662, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(871, 561);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "label1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(662, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "label1";
			// 
			// lblForce
			// 
			this.lblForce.AutoSize = true;
			this.lblForce.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblForce.Location = new System.Drawing.Point(3, 561);
			this.lblForce.Name = "lblForce";
			this.lblForce.Size = new System.Drawing.Size(44, 13);
			this.lblForce.TabIndex = 4;
			this.lblForce.Text = "lblForce";
			// 
			// lblXmult
			// 
			this.lblXmult.AutoSize = true;
			this.lblXmult.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblXmult.Location = new System.Drawing.Point(10, 23);
			this.lblXmult.Name = "lblXmult";
			this.lblXmult.Size = new System.Drawing.Size(43, 13);
			this.lblXmult.TabIndex = 3;
			this.lblXmult.Text = "lblXmult";
			// 
			// lblYmult
			// 
			this.lblYmult.AutoSize = true;
			this.lblYmult.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblYmult.Location = new System.Drawing.Point(10, 36);
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
			// LBLRNDE
			// 
			this.LBLRNDE.AutoSize = true;
			this.LBLRNDE.Location = new System.Drawing.Point(319, 10);
			this.LBLRNDE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LBLRNDE.Name = "LBLRNDE";
			this.LBLRNDE.Size = new System.Drawing.Size(57, 13);
			this.LBLRNDE.TabIndex = 16;
			this.LBLRNDE.Text = "LBLRNDE";
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
			// lblCursor
			// 
			this.lblCursor.AutoSize = true;
			this.lblCursor.Location = new System.Drawing.Point(319, 45);
			this.lblCursor.Name = "lblCursor";
			this.lblCursor.Size = new System.Drawing.Size(35, 13);
			this.lblCursor.TabIndex = 1;
			this.lblCursor.Text = "label6";
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1004, 725);
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
        private System.Windows.Forms.Label lblFuel2;
        private System.Windows.Forms.Label lblFuel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRondencar2;
        private System.Windows.Forms.Label lblRondencar1;
        private System.Windows.Forms.Label LBLRNDE;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.ProgressBar Fuelbarcar2;
        private System.Windows.Forms.ProgressBar Fuelbarcar1;
		private System.Windows.Forms.Label lblCursor;
	}
}

