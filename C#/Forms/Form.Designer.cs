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
<<<<<<< HEAD
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.winner = new System.Windows.Forms.Label();
            this.car2seconds3 = new System.Windows.Forms.Label();
            this.car2minutes3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.car2seconds2 = new System.Windows.Forms.Label();
            this.car2minutes2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.car2seconds1 = new System.Windows.Forms.Label();
            this.car2minutes1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Seconds3 = new System.Windows.Forms.Label();
            this.Minutes3 = new System.Windows.Forms.Label();
            this.Seconds2 = new System.Windows.Forms.Label();
            this.Minutes2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Seconds = new System.Windows.Forms.Label();
            this.Minutes = new System.Windows.Forms.Label();
            this.YouWonBox = new System.Windows.Forms.PictureBox();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.LBL_info = new System.Windows.Forms.Label();
            this.label_player2 = new System.Windows.Forms.Label();
            this.label_player1 = new System.Windows.Forms.Label();
            this.pnlCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YouWonBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.Controls.Add(this.label_player1);
            this.pnlCanvas.Controls.Add(this.label_player2);
            this.pnlCanvas.Controls.Add(this.LBL_info);
            this.pnlCanvas.Controls.Add(this.winner);
            this.pnlCanvas.Controls.Add(this.car2seconds3);
            this.pnlCanvas.Controls.Add(this.car2minutes3);
            this.pnlCanvas.Controls.Add(this.label14);
            this.pnlCanvas.Controls.Add(this.car2seconds2);
            this.pnlCanvas.Controls.Add(this.car2minutes2);
            this.pnlCanvas.Controls.Add(this.label11);
            this.pnlCanvas.Controls.Add(this.car2seconds1);
            this.pnlCanvas.Controls.Add(this.car2minutes1);
            this.pnlCanvas.Controls.Add(this.label10);
            this.pnlCanvas.Controls.Add(this.label9);
            this.pnlCanvas.Controls.Add(this.label8);
            this.pnlCanvas.Controls.Add(this.label7);
            this.pnlCanvas.Controls.Add(this.Seconds3);
            this.pnlCanvas.Controls.Add(this.Minutes3);
            this.pnlCanvas.Controls.Add(this.Seconds2);
            this.pnlCanvas.Controls.Add(this.Minutes2);
            this.pnlCanvas.Controls.Add(this.label6);
            this.pnlCanvas.Controls.Add(this.Seconds);
            this.pnlCanvas.Controls.Add(this.Minutes);
            this.pnlCanvas.Controls.Add(this.YouWonBox);
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
            this.pnlCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(1002, 717);
            this.pnlCanvas.TabIndex = 0;
            this.pnlCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCanvas_Paint);
            // 
            // winner
            // 
            this.winner.AutoSize = true;
            this.winner.BackColor = System.Drawing.Color.Black;
            this.winner.Font = new System.Drawing.Font("Comic Sans MS", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winner.ForeColor = System.Drawing.Color.White;
            this.winner.Location = new System.Drawing.Point(311, 4);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(326, 113);
            this.winner.TabIndex = 40;
            this.winner.Text = "label12";
            this.winner.Visible = false;
            // 
            // car2seconds3
            // 
            this.car2seconds3.AutoSize = true;
            this.car2seconds3.Location = new System.Drawing.Point(936, 597);
            this.car2seconds3.Name = "car2seconds3";
            this.car2seconds3.Size = new System.Drawing.Size(54, 17);
            this.car2seconds3.TabIndex = 39;
            this.car2seconds3.Text = "label16";
            // 
            // car2minutes3
            // 
            this.car2minutes3.AutoSize = true;
            this.car2minutes3.Location = new System.Drawing.Point(872, 597);
            this.car2minutes3.Name = "car2minutes3";
            this.car2minutes3.Size = new System.Drawing.Size(54, 17);
            this.car2minutes3.TabIndex = 38;
            this.car2minutes3.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(895, 580);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "Car 2 round 3";
            // 
            // car2seconds2
            // 
            this.car2seconds2.AutoSize = true;
            this.car2seconds2.Location = new System.Drawing.Point(946, 537);
            this.car2seconds2.Name = "car2seconds2";
            this.car2seconds2.Size = new System.Drawing.Size(54, 17);
            this.car2seconds2.TabIndex = 36;
            this.car2seconds2.Text = "label13";
            // 
            // car2minutes2
            // 
            this.car2minutes2.AutoSize = true;
            this.car2minutes2.Location = new System.Drawing.Point(889, 537);
            this.car2minutes2.Name = "car2minutes2";
            this.car2minutes2.Size = new System.Drawing.Size(54, 17);
            this.car2minutes2.TabIndex = 35;
            this.car2minutes2.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(889, 520);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Car 2 round 1";
            // 
            // car2seconds1
            // 
            this.car2seconds1.AutoSize = true;
            this.car2seconds1.Location = new System.Drawing.Point(936, 479);
            this.car2seconds1.Name = "car2seconds1";
            this.car2seconds1.Size = new System.Drawing.Size(54, 17);
            this.car2seconds1.TabIndex = 33;
            this.car2seconds1.Text = "label12";
            // 
            // car2minutes1
            // 
            this.car2minutes1.AutoSize = true;
            this.car2minutes1.Location = new System.Drawing.Point(889, 479);
            this.car2minutes1.Name = "car2minutes1";
            this.car2minutes1.Size = new System.Drawing.Size(54, 17);
            this.car2minutes1.TabIndex = 32;
            this.car2minutes1.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(889, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Car 2 round 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 580);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "Car 1 round 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 520);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Car 1 round 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 662);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // Seconds3
            // 
            this.Seconds3.AutoSize = true;
            this.Seconds3.Location = new System.Drawing.Point(72, 597);
            this.Seconds3.Name = "Seconds3";
            this.Seconds3.Size = new System.Drawing.Size(54, 17);
            this.Seconds3.TabIndex = 27;
            this.Seconds3.Text = "label12";
            // 
            // Minutes3
            // 
            this.Minutes3.AutoSize = true;
            this.Minutes3.Location = new System.Drawing.Point(12, 597);
            this.Minutes3.Name = "Minutes3";
            this.Minutes3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Minutes3.Size = new System.Drawing.Size(54, 17);
            this.Minutes3.TabIndex = 26;
            this.Minutes3.Text = "label11";
            // 
            // Seconds2
            // 
            this.Seconds2.AutoSize = true;
            this.Seconds2.Location = new System.Drawing.Point(56, 537);
            this.Seconds2.Name = "Seconds2";
            this.Seconds2.Size = new System.Drawing.Size(46, 17);
            this.Seconds2.TabIndex = 24;
            this.Seconds2.Text = "label9";
            // 
            // Minutes2
            // 
            this.Minutes2.AutoSize = true;
            this.Minutes2.Location = new System.Drawing.Point(9, 537);
            this.Minutes2.Name = "Minutes2";
            this.Minutes2.Size = new System.Drawing.Size(46, 17);
            this.Minutes2.TabIndex = 23;
            this.Minutes2.Text = "label8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Car 1 round 1";
            // 
            // Seconds
            // 
            this.Seconds.AutoSize = true;
            this.Seconds.Location = new System.Drawing.Point(56, 479);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(46, 17);
            this.Seconds.TabIndex = 20;
            this.Seconds.Text = "label7";
            // 
            // Minutes
            // 
            this.Minutes.AutoSize = true;
            this.Minutes.Location = new System.Drawing.Point(9, 479);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(46, 17);
            this.Minutes.TabIndex = 19;
            this.Minutes.Text = "label6";
            // 
            // YouWonBox
            // 
            this.YouWonBox.Image = global::Forms.Properties.Resources.YouWon;
            this.YouWonBox.Location = new System.Drawing.Point(-2, 0);
            this.YouWonBox.Name = "YouWonBox";
            this.YouWonBox.Size = new System.Drawing.Size(1004, 717);
            this.YouWonBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YouWonBox.TabIndex = 19;
            this.YouWonBox.TabStop = false;
            this.YouWonBox.Visible = false;
            // 
            // Fuelbarcar2
            // 
            this.Fuelbarcar2.Location = new System.Drawing.Point(900, 645);
            this.Fuelbarcar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fuelbarcar2.Name = "Fuelbarcar2";
            this.Fuelbarcar2.Size = new System.Drawing.Size(100, 23);
            this.Fuelbarcar2.TabIndex = 18;
            // 
            // Fuelbarcar1
            // 
            this.Fuelbarcar1.Location = new System.Drawing.Point(86, 645);
            this.Fuelbarcar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fuelbarcar1.Name = "Fuelbarcar1";
            this.Fuelbarcar1.Size = new System.Drawing.Size(100, 23);
            this.Fuelbarcar1.TabIndex = 17;
            // 
            // lblRondencar2
            // 
            this.lblRondencar2.AutoSize = true;
            this.lblRondencar2.Location = new System.Drawing.Point(757, 28);
            this.lblRondencar2.Name = "lblRondencar2";
            this.lblRondencar2.Size = new System.Drawing.Size(100, 17);
            this.lblRondencar2.TabIndex = 15;
            this.lblRondencar2.Text = "lblRondencar2";
            // 
            // lblRondencar1
            // 
            this.lblRondencar1.AutoSize = true;
            this.lblRondencar1.Location = new System.Drawing.Point(98, 29);
            this.lblRondencar1.Name = "lblRondencar1";
            this.lblRondencar1.Size = new System.Drawing.Size(100, 17);
            this.lblRondencar1.TabIndex = 14;
            this.lblRondencar1.Text = "lblRondencar1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Geraakt?";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(16, 100);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(77, 17);
            this.lblTest.TabIndex = 13;
            this.lblTest.Text = "lblFuelTest";
            // 
            // lblFuel2
            // 
            this.lblFuel2.AutoSize = true;
            this.lblFuel2.Location = new System.Drawing.Point(800, 645);
            this.lblFuel2.Name = "lblFuel2";
            this.lblFuel2.Size = new System.Drawing.Size(57, 17);
            this.lblFuel2.TabIndex = 12;
            this.lblFuel2.Text = "lblFuel2";
            // 
            // lblFuel1
            // 
            this.lblFuel1.AutoSize = true;
            this.lblFuel1.Location = new System.Drawing.Point(9, 645);
            this.lblFuel1.Name = "lblFuel1";
            this.lblFuel1.Size = new System.Drawing.Size(57, 17);
            this.lblFuel1.TabIndex = 11;
            this.lblFuel1.Text = "lblFuel1";
            // 
            // Car1_Bar
            // 
            this.Car1_Bar.Location = new System.Drawing.Point(86, 684);
            this.Car1_Bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Car1_Bar.Maximum = 200;
            this.Car1_Bar.Name = "Car1_Bar";
            this.Car1_Bar.Size = new System.Drawing.Size(100, 23);
            this.Car1_Bar.TabIndex = 10;
            // 
            // Car2_Bar
            // 
            this.Car2_Bar.Location = new System.Drawing.Point(900, 684);
            this.Car2_Bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Car2_Bar.Maximum = 200;
            this.Car2_Bar.Name = "Car2_Bar";
            this.Car2_Bar.Size = new System.Drawing.Size(100, 23);
            this.Car2_Bar.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(883, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(883, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(800, 690);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(883, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // lblForce
            // 
            this.lblForce.AutoSize = true;
            this.lblForce.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblForce.Location = new System.Drawing.Point(4, 690);
            this.lblForce.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForce.Name = "lblForce";
            this.lblForce.Size = new System.Drawing.Size(58, 17);
            this.lblForce.TabIndex = 4;
            this.lblForce.Text = "lblForce";
            // 
            // lblXmult
            // 
            this.lblXmult.AutoSize = true;
            this.lblXmult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblXmult.Location = new System.Drawing.Point(14, 28);
            this.lblXmult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXmult.Name = "lblXmult";
            this.lblXmult.Size = new System.Drawing.Size(57, 17);
            this.lblXmult.TabIndex = 3;
            this.lblXmult.Text = "lblXmult";
            // 
            // lblYmult
            // 
            this.lblYmult.AutoSize = true;
            this.lblYmult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblYmult.Location = new System.Drawing.Point(14, 44);
            this.lblYmult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYmult.Name = "lblYmult";
            this.lblYmult.Size = new System.Drawing.Size(57, 17);
            this.lblYmult.TabIndex = 2;
            this.lblYmult.Text = "lblYmult";
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAngle.Location = new System.Drawing.Point(13, 11);
            this.lblAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(58, 17);
            this.lblAngle.TabIndex = 1;
            this.lblAngle.Text = "lblAngle";
            // 
            // LBLRNDE
            // 
            this.LBLRNDE.AutoSize = true;
            this.LBLRNDE.Location = new System.Drawing.Point(425, 12);
            this.LBLRNDE.Name = "LBLRNDE";
            this.LBLRNDE.Size = new System.Drawing.Size(72, 17);
            this.LBLRNDE.TabIndex = 16;
            this.LBLRNDE.Text = "LBLRNDE";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // tmrMoving
            // 
            this.tmrMoving.Enabled = true;
            this.tmrMoving.Interval = 18;
            this.tmrMoving.Tick += new System.EventHandler(this.tmrMoving_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // LBL_info
            // 
            this.LBL_info.AutoSize = true;
            this.LBL_info.BackColor = System.Drawing.Color.Black;
            this.LBL_info.ForeColor = System.Drawing.Color.White;
            this.LBL_info.Location = new System.Drawing.Point(385, 276);
            this.LBL_info.Name = "LBL_info";
            this.LBL_info.Size = new System.Drawing.Size(84, 17);
            this.LBL_info.TabIndex = 41;
            this.LBL_info.Text = "INFO_TEXT";
            this.LBL_info.Visible = false;
            // 
            // label_player2
            // 
            this.label_player2.AutoSize = true;
            this.label_player2.Location = new System.Drawing.Point(889, 429);
            this.label_player2.Name = "label_player2";
            this.label_player2.Size = new System.Drawing.Size(0, 17);
            this.label_player2.TabIndex = 42;
            // 
            // label_player1
            // 
            this.label_player1.AutoSize = true;
            this.label_player1.Location = new System.Drawing.Point(4, 416);
            this.label_player1.Name = "label_player1";
            this.label_player1.Size = new System.Drawing.Size(0, 17);
            this.label_player1.TabIndex = 43;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1002, 717);
            this.Controls.Add(this.pnlCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pret Eiland";
            this.Load += new System.EventHandler(this.Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_KeyUp);
            this.pnlCanvas.ResumeLayout(false);
            this.pnlCanvas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YouWonBox)).EndInit();
            this.ResumeLayout(false);
=======
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
			this.pnlCanvas = new System.Windows.Forms.Panel();
			this.winner = new System.Windows.Forms.Label();
			this.car2seconds3 = new System.Windows.Forms.Label();
			this.car2minutes3 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.car2seconds2 = new System.Windows.Forms.Label();
			this.car2minutes2 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.car2seconds1 = new System.Windows.Forms.Label();
			this.car2minutes1 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.Seconds3 = new System.Windows.Forms.Label();
			this.Minutes3 = new System.Windows.Forms.Label();
			this.Seconds2 = new System.Windows.Forms.Label();
			this.Minutes2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.Seconds = new System.Windows.Forms.Label();
			this.Minutes = new System.Windows.Forms.Label();
			this.Fuelbarcar2 = new System.Windows.Forms.ProgressBar();
			this.Fuelbarcar1 = new System.Windows.Forms.ProgressBar();
			this.lblRondencar2 = new System.Windows.Forms.Label();
			this.lblRondencar1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblRefuelP1 = new System.Windows.Forms.Label();
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
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.timer4 = new System.Windows.Forms.Timer(this.components);
			this.timer5 = new System.Windows.Forms.Timer(this.components);
			this.timer6 = new System.Windows.Forms.Timer(this.components);
			this.lblRefuelP2 = new System.Windows.Forms.Label();
			this.pnlCanvas.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlCanvas
			// 
			this.pnlCanvas.Controls.Add(this.lblRefuelP2);
			this.pnlCanvas.Controls.Add(this.winner);
			this.pnlCanvas.Controls.Add(this.car2seconds3);
			this.pnlCanvas.Controls.Add(this.car2minutes3);
			this.pnlCanvas.Controls.Add(this.label14);
			this.pnlCanvas.Controls.Add(this.car2seconds2);
			this.pnlCanvas.Controls.Add(this.car2minutes2);
			this.pnlCanvas.Controls.Add(this.label11);
			this.pnlCanvas.Controls.Add(this.car2seconds1);
			this.pnlCanvas.Controls.Add(this.car2minutes1);
			this.pnlCanvas.Controls.Add(this.label10);
			this.pnlCanvas.Controls.Add(this.label9);
			this.pnlCanvas.Controls.Add(this.label8);
			this.pnlCanvas.Controls.Add(this.label7);
			this.pnlCanvas.Controls.Add(this.Seconds3);
			this.pnlCanvas.Controls.Add(this.Minutes3);
			this.pnlCanvas.Controls.Add(this.Seconds2);
			this.pnlCanvas.Controls.Add(this.Minutes2);
			this.pnlCanvas.Controls.Add(this.label6);
			this.pnlCanvas.Controls.Add(this.Seconds);
			this.pnlCanvas.Controls.Add(this.Minutes);
			this.pnlCanvas.Controls.Add(this.Fuelbarcar2);
			this.pnlCanvas.Controls.Add(this.Fuelbarcar1);
			this.pnlCanvas.Controls.Add(this.lblRondencar2);
			this.pnlCanvas.Controls.Add(this.lblRondencar1);
			this.pnlCanvas.Controls.Add(this.label5);
			this.pnlCanvas.Controls.Add(this.lblRefuelP1);
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
			// winner
			// 
			this.winner.AutoSize = true;
			this.winner.BackColor = System.Drawing.Color.Black;
			this.winner.Font = new System.Drawing.Font("Comic Sans MS", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.winner.ForeColor = System.Drawing.Color.White;
			this.winner.Location = new System.Drawing.Point(373, 3);
			this.winner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.winner.Name = "winner";
			this.winner.Size = new System.Drawing.Size(262, 90);
			this.winner.TabIndex = 40;
			this.winner.Text = "label12";
			this.winner.Visible = false;
			// 
			// car2seconds3
			// 
			this.car2seconds3.AutoSize = true;
			this.car2seconds3.Location = new System.Drawing.Point(939, 477);
			this.car2seconds3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.car2seconds3.Name = "car2seconds3";
			this.car2seconds3.Size = new System.Drawing.Size(41, 13);
			this.car2seconds3.TabIndex = 39;
			this.car2seconds3.Text = "label16";
			// 
			// car2minutes3
			// 
			this.car2minutes3.AutoSize = true;
			this.car2minutes3.Location = new System.Drawing.Point(891, 477);
			this.car2minutes3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.car2minutes3.Name = "car2minutes3";
			this.car2minutes3.Size = new System.Drawing.Size(41, 13);
			this.car2minutes3.TabIndex = 38;
			this.car2minutes3.Text = "label15";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(908, 463);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(71, 13);
			this.label14.TabIndex = 37;
			this.label14.Text = "Car 2 round 3";
			// 
			// car2seconds2
			// 
			this.car2seconds2.AutoSize = true;
			this.car2seconds2.Location = new System.Drawing.Point(947, 428);
			this.car2seconds2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.car2seconds2.Name = "car2seconds2";
			this.car2seconds2.Size = new System.Drawing.Size(41, 13);
			this.car2seconds2.TabIndex = 36;
			this.car2seconds2.Text = "label13";
			// 
			// car2minutes2
			// 
			this.car2minutes2.AutoSize = true;
			this.car2minutes2.Location = new System.Drawing.Point(904, 428);
			this.car2minutes2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.car2minutes2.Name = "car2minutes2";
			this.car2minutes2.Size = new System.Drawing.Size(41, 13);
			this.car2minutes2.TabIndex = 35;
			this.car2minutes2.Text = "label12";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(904, 414);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(71, 13);
			this.label11.TabIndex = 34;
			this.label11.Text = "Car 2 round 1";
			// 
			// car2seconds1
			// 
			this.car2seconds1.AutoSize = true;
			this.car2seconds1.Location = new System.Drawing.Point(939, 381);
			this.car2seconds1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.car2seconds1.Name = "car2seconds1";
			this.car2seconds1.Size = new System.Drawing.Size(41, 13);
			this.car2seconds1.TabIndex = 33;
			this.car2seconds1.Text = "label12";
			// 
			// car2minutes1
			// 
			this.car2minutes1.AutoSize = true;
			this.car2minutes1.Location = new System.Drawing.Point(904, 381);
			this.car2minutes1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.car2minutes1.Name = "car2minutes1";
			this.car2minutes1.Size = new System.Drawing.Size(41, 13);
			this.car2minutes1.TabIndex = 32;
			this.car2minutes1.Text = "label11";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(904, 367);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(71, 13);
			this.label10.TabIndex = 31;
			this.label10.Text = "Car 2 round 1";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(7, 471);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(71, 13);
			this.label9.TabIndex = 30;
			this.label9.Text = "Car 1 round 3";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 422);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(71, 13);
			this.label8.TabIndex = 29;
			this.label8.Text = "Car 1 round 2";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(15, 538);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 13);
			this.label7.TabIndex = 28;
			this.label7.Text = "label7";
			this.label7.Visible = false;
			// 
			// Seconds3
			// 
			this.Seconds3.AutoSize = true;
			this.Seconds3.Location = new System.Drawing.Point(54, 485);
			this.Seconds3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Seconds3.Name = "Seconds3";
			this.Seconds3.Size = new System.Drawing.Size(41, 13);
			this.Seconds3.TabIndex = 27;
			this.Seconds3.Text = "label12";
			// 
			// Minutes3
			// 
			this.Minutes3.AutoSize = true;
			this.Minutes3.Location = new System.Drawing.Point(9, 485);
			this.Minutes3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Minutes3.Name = "Minutes3";
			this.Minutes3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Minutes3.Size = new System.Drawing.Size(41, 13);
			this.Minutes3.TabIndex = 26;
			this.Minutes3.Text = "label11";
			// 
			// Seconds2
			// 
			this.Seconds2.AutoSize = true;
			this.Seconds2.Location = new System.Drawing.Point(42, 436);
			this.Seconds2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Seconds2.Name = "Seconds2";
			this.Seconds2.Size = new System.Drawing.Size(35, 13);
			this.Seconds2.TabIndex = 24;
			this.Seconds2.Text = "label9";
			// 
			// Minutes2
			// 
			this.Minutes2.AutoSize = true;
			this.Minutes2.Location = new System.Drawing.Point(7, 436);
			this.Minutes2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Minutes2.Name = "Minutes2";
			this.Minutes2.Size = new System.Drawing.Size(35, 13);
			this.Minutes2.TabIndex = 23;
			this.Minutes2.Text = "label8";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 367);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 13);
			this.label6.TabIndex = 21;
			this.label6.Text = "Car 1 round 1";
			// 
			// Seconds
			// 
			this.Seconds.AutoSize = true;
			this.Seconds.Location = new System.Drawing.Point(42, 389);
			this.Seconds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Seconds.Name = "Seconds";
			this.Seconds.Size = new System.Drawing.Size(35, 13);
			this.Seconds.TabIndex = 20;
			this.Seconds.Text = "label7";
			// 
			// Minutes
			// 
			this.Minutes.AutoSize = true;
			this.Minutes.Location = new System.Drawing.Point(7, 389);
			this.Minutes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Minutes.Name = "Minutes";
			this.Minutes.Size = new System.Drawing.Size(35, 13);
			this.Minutes.TabIndex = 19;
			this.Minutes.Text = "label6";
			// 
			// Fuelbarcar2
			// 
			this.Fuelbarcar2.Location = new System.Drawing.Point(912, 516);
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
			this.lblRondencar2.Location = new System.Drawing.Point(816, 22);
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
			// lblRefuelP1
			// 
			this.lblRefuelP1.AutoSize = true;
			this.lblRefuelP1.Location = new System.Drawing.Point(12, 81);
			this.lblRefuelP1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRefuelP1.Name = "lblRefuelP1";
			this.lblRefuelP1.Size = new System.Drawing.Size(58, 13);
			this.lblRefuelP1.TabIndex = 13;
			this.lblRefuelP1.Text = "lblFuelTest";
			// 
			// lblFuel2
			// 
			this.lblFuel2.AutoSize = true;
			this.lblFuel2.Location = new System.Drawing.Point(837, 516);
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
			this.Car2_Bar.Location = new System.Drawing.Point(913, 555);
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
			this.label4.Location = new System.Drawing.Point(910, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "label1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(910, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(837, 556);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "label1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(910, 35);
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
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Interval = 1000;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
			// 
			// timer3
			// 
			this.timer3.Interval = 1000;
			this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
			// 
			// lblRefuelP2
			// 
			this.lblRefuelP2.AutoSize = true;
			this.lblRefuelP2.Location = new System.Drawing.Point(816, 80);
			this.lblRefuelP2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRefuelP2.Name = "lblRefuelP2";
			this.lblRefuelP2.Size = new System.Drawing.Size(58, 13);
			this.lblRefuelP2.TabIndex = 41;
			this.lblRefuelP2.Text = "lblFuelTest";
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1004, 725);
			this.Controls.Add(this.pnlCanvas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pret Eiland";
			this.Load += new System.EventHandler(this.Form_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_KeyUp);
			this.pnlCanvas.ResumeLayout(false);
			this.pnlCanvas.PerformLayout();
			this.ResumeLayout(false);
>>>>>>> 68f646d8ee693c585f244fc1fea8ec8b71e31421

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
        private System.Windows.Forms.Label lblRefuelP1;
        private System.Windows.Forms.ProgressBar Fuelbarcar2;
        private System.Windows.Forms.ProgressBar Fuelbarcar1;
        private System.Windows.Forms.Label Seconds;
        private System.Windows.Forms.Label Minutes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Seconds3;
        private System.Windows.Forms.Label Minutes3;
        private System.Windows.Forms.Label Seconds2;
        private System.Windows.Forms.Label Minutes2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label car2seconds1;
        private System.Windows.Forms.Label car2minutes1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Label car2seconds3;
        private System.Windows.Forms.Label car2minutes3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label car2seconds2;
        private System.Windows.Forms.Label car2minutes2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label winner;
        private System.Windows.Forms.Label LBL_info;
        private System.Windows.Forms.Label label_player1;
        private System.Windows.Forms.Label label_player2;
		private System.Windows.Forms.Label lblRefuelP2;
	}
}

