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
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tmrMoving = new System.Windows.Forms.Timer(this.components);
			this.lblAngle = new System.Windows.Forms.Label();
			this.lblYmult = new System.Windows.Forms.Label();
			this.lblXmult = new System.Windows.Forms.Label();
			this.lblForce = new System.Windows.Forms.Label();
			this.pnlCanvas.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlCanvas
			// 
			this.pnlCanvas.Controls.Add(this.lblForce);
			this.pnlCanvas.Controls.Add(this.lblXmult);
			this.pnlCanvas.Controls.Add(this.lblYmult);
			this.pnlCanvas.Controls.Add(this.lblAngle);
			this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlCanvas.Location = new System.Drawing.Point(0, 0);
			this.pnlCanvas.Name = "pnlCanvas";
			this.pnlCanvas.Size = new System.Drawing.Size(784, 561);
			this.pnlCanvas.TabIndex = 0;
			this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// tmrMoving
			// 
			this.tmrMoving.Enabled = true;
			this.tmrMoving.Interval = 18;
			this.tmrMoving.Tick += new System.EventHandler(this.tmrMoving_Tick);
			// 
			// lblAngle
			// 
			this.lblAngle.AutoSize = true;
			this.lblAngle.Location = new System.Drawing.Point(12, 9);
			this.lblAngle.Name = "lblAngle";
			this.lblAngle.Size = new System.Drawing.Size(35, 13);
			this.lblAngle.TabIndex = 1;
			this.lblAngle.Text = "label1";
			// 
			// lblYmult
			// 
			this.lblYmult.AutoSize = true;
			this.lblYmult.Location = new System.Drawing.Point(12, 48);
			this.lblYmult.Name = "lblYmult";
			this.lblYmult.Size = new System.Drawing.Size(35, 13);
			this.lblYmult.TabIndex = 2;
			this.lblYmult.Text = "label2";
			// 
			// lblXmult
			// 
			this.lblXmult.AutoSize = true;
			this.lblXmult.Location = new System.Drawing.Point(12, 35);
			this.lblXmult.Name = "lblXmult";
			this.lblXmult.Size = new System.Drawing.Size(35, 13);
			this.lblXmult.TabIndex = 3;
			this.lblXmult.Text = "label3";
			// 
			// lblForce
			// 
			this.lblForce.AutoSize = true;
			this.lblForce.Location = new System.Drawing.Point(12, 22);
			this.lblForce.Name = "lblForce";
			this.lblForce.Size = new System.Drawing.Size(35, 13);
			this.lblForce.TabIndex = 4;
			this.lblForce.Text = "label4";
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.pnlCanvas);
			this.Name = "Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
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
	}
}

