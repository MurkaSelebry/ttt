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
    public partial class CaloriesForm : Form
    {
        private Label label4;
        private TextBox WeightText;
        private Label label2;
        private TextBox HeightText;
        private Label label5;
        private TextBox SexText;
        private Button printbutton;
        private TextBox RateText;
        private Label label3;
        private Label label6;
        private TextBox YearsText;
        private Label label1;

        public class Calories
        {
            public char Sex { get; }
            public double Weight { get; }
            public double Height { get; }
            public double Years { get; }
            public double Boo { get; }// ИМТ = вес/ (рост * рост)
            public double MarkActivity { get; }
            public Calories(char sex, double height, double weight,double years,double activity)
            {
                this.Sex = sex;
                this.Weight = weight;
                this.Height = height;
                this.Years = years;
                this.MarkActivity = activity;
                if (sex == 'M') Boo = Math.Round(activity*(66.5 + (13.75 * weight) + (5.003 * height) - (6.775 * years)),1);
                else Boo = Math.Round(activity*(655.1 + (9.563 * weight) + (1.85 * height) - (4.676 * years)),1);
            }
            public string ToString()
            {
                return $"\"Ваш каллораж: {Boo} ккал\"";
            }
        };

        public CaloriesForm()
        {
            InitializeComponent();
        }

        





        

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WeightText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HeightText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SexText = new System.Windows.Forms.TextBox();
            this.printbutton = new System.Windows.Forms.Button();
            this.RateText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.YearsText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(193, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 176);
            this.label1.TabIndex = 0;
            this.label1.Text = "почти нет активности – 1,2;\r\nумеренные нагрузки – 1,375;\r\nтренировки 3-5 раз в не" +
    "делю – 1,55;\r\nинтенсивные нагрузки – 1,725;\r\nпрофессиональные спортсмены – 1,9.\r" +
    "\n";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(193, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Weight";
            // 
            // WeightText
            // 
            this.WeightText.Location = new System.Drawing.Point(302, 288);
            this.WeightText.Name = "WeightText";
            this.WeightText.Size = new System.Drawing.Size(267, 23);
            this.WeightText.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(193, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Height";
            // 
            // HeightText
            // 
            this.HeightText.Location = new System.Drawing.Point(302, 242);
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(267, 23);
            this.HeightText.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(193, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sex";
            // 
            // SexText
            // 
            this.SexText.Location = new System.Drawing.Point(302, 190);
            this.SexText.Name = "SexText";
            this.SexText.Size = new System.Drawing.Size(267, 23);
            this.SexText.TabIndex = 12;
            // 
            // printbutton
            // 
            this.printbutton.ForeColor = System.Drawing.Color.Red;
            this.printbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.printbutton.Location = new System.Drawing.Point(193, 432);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(376, 52);
            this.printbutton.TabIndex = 11;
            this.printbutton.Text = "Show BOO";
            this.printbutton.UseVisualStyleBackColor = true;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            // 
            // RateText
            // 
            this.RateText.Location = new System.Drawing.Point(302, 337);
            this.RateText.Name = "RateText";
            this.RateText.Size = new System.Drawing.Size(267, 23);
            this.RateText.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(193, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Rate";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(193, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Years";
            // 
            // YearsText
            // 
            this.YearsText.Location = new System.Drawing.Point(302, 390);
            this.YearsText.Name = "YearsText";
            this.YearsText.Size = new System.Drawing.Size(267, 23);
            this.YearsText.TabIndex = 20;
            // 
            // CaloriesForm
            // 
            this.ClientSize = new System.Drawing.Size(782, 496);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.YearsText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RateText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WeightText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HeightText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SexText);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.label1);
            this.Name = "CaloriesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void printbutton_Click(object sender, EventArgs e)
        {
            var l = new Calories(Convert.ToChar(SexText.Text), Convert.ToDouble(HeightText.Text), Convert.ToDouble(WeightText.Text), Convert.ToDouble(YearsText.Text), Convert.ToDouble(RateText.Text));
            MessageBox.Show(l.ToString());
        }




        //private void textBox1_TextChanged(object sender, EventArgs e)
        // {

        // }
    }
}
