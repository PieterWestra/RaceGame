using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public class Menu_Form : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Button button3;
        private bool toggle = false;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private System.Windows.Forms.Button button2;
        //moving without borders
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        //

        public Menu_Form()
        {
            InitializeComponent();
           
        }

        protected override void WndProc(ref Message m) //moving without borders
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        

        #region do not touch!!
        public void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Form));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(303, 196);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Start Game";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(303, 469);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Quit";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(222, 296);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 17);
			this.label1.TabIndex = 3;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(384, 296);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 19);
			this.label2.TabIndex = 4;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(303, 255);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "Names";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(50, 196);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 13);
			this.label3.TabIndex = 6;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(225, 321);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(75, 20);
			this.textBox1.TabIndex = 7;
			this.textBox1.Visible = false;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(384, 321);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(75, 20);
			this.textBox2.TabIndex = 8;
			this.textBox2.Visible = false;
			// 
			// Menu_Form
			// 
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::Forms.Properties.Resources.Preteiland;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(666, 539);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Menu_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pret Eiland";
			this.ResumeLayout(false);
			this.PerformLayout();

        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            Form Form_game = new Form();
            Form_game.Reset();
            Form_game.Show();
            Form_game.CloseRace = false;
            this.Hide();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form Form_game = new Form();
            Form_game.Close();
            Application.Exit();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //label3.Text = toggle = !toggle;
            
            switch (toggle)
            {
                case true:
                    {
                        label1.Text = "Player 1";
                        label2.Text = "Player 2";
                        textBox1.Visible = true;
                        textBox2.Visible = true;

                        break;
                    }
                case false:
                    {
                        label1.Text = String.Empty;
                        label2.Text = String.Empty;
                        textBox1.Visible = false;
                        textBox2.Visible = false;
                        break;
                    }
            }
            Form.Player1Name = textBox1.Text;
            Form.Player2Name = textBox2.Text;
            toggle = !toggle;
            
        }
    }
}
