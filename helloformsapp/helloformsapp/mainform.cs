using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloformsapp
{
    public partial class MainForm : Form
    {
        private Button button1;
        private Label label1;
        private Button button2;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CaloriesForm c1 = new CaloriesForm();
            c1.Show();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }





        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "ИМТ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(251, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 66);
            this.button2.TabIndex = 1;
            this.button2.Text = "Калораж";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(147, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите что вы хотите узнать:\r\n";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(448, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        


        //private void textBox1_TextChanged(object sender, EventArgs e)
        // {

        // }
    }
}
