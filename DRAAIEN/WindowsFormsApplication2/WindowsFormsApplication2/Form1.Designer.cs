namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.lblForce = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.tmrGameTicks = new System.Windows.Forms.Timer(this.components);
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.pnlCanvas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.Controls.Add(this.lblX);
            this.pnlCanvas.Controls.Add(this.lblY);
            this.pnlCanvas.Controls.Add(this.lblForce);
            this.pnlCanvas.Controls.Add(this.lblAngle);
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 0);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(784, 561);
            this.pnlCanvas.TabIndex = 0;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            // 
            // lblForce
            // 
            this.lblForce.AutoSize = true;
            this.lblForce.Location = new System.Drawing.Point(721, 32);
            this.lblForce.Name = "lblForce";
            this.lblForce.Size = new System.Drawing.Size(35, 13);
            this.lblForce.TabIndex = 1;
            this.lblForce.Text = "label1";
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(721, 9);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(35, 13);
            this.lblAngle.TabIndex = 0;
            this.lblAngle.Text = "label1";
            // 
            // tmrGameTicks
            // 
            this.tmrGameTicks.Enabled = true;
            this.tmrGameTicks.Interval = 18;
            this.tmrGameTicks.Tick += new System.EventHandler(this.tmrGameTicks_Tick);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(692, 83);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(35, 13);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "label1";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(692, 58);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(35, 13);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlCanvas);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.pnlCanvas.ResumeLayout(false);
            this.pnlCanvas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.Timer tmrGameTicks;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label lblForce;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
    }
}

