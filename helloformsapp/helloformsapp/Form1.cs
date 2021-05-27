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
    public partial class Form1 : Form
    {
        public class BMI
        {
            public char Sex { get; }
            public double Weight { get; }
            public double Height { get; }
            public double bmi;// ИМТ = вес/ (рост * рост)
            public string Mark_bmi { get; }
            public BMI(char sex, double height, double weight)
            {
                this.Sex = sex;
                this.Weight = weight;
                this.Height = height;
                this.bmi = CountBMI(weight, height);
                this.Mark_bmi = CheckBMI(bmi, sex);
            }
            static double CountBMI(double weight, double height)
            {
                double bmi;
                if (height >= 10.0)
                {//человек явно меньше, чем 10 метров (наверное)
                    bmi = weight / ((height / 100.0) * (height / 100.0));
                }
                else
                {
                    bmi = weight / (height * height);
                }
                return bmi;
            }
            public string CheckBMI(double n, char sex)
            {
                double bmi = n;
                if (sex == 'F')
                    bmi += 3.0;
                if (bmi < 16.0)
                    return "Ярко выраженный дефицит массы тела";
                else if (bmi >= 16.0 && bmi < 23.0)
                    return "Дефицит массы тела";
                else if (bmi >= 23 && bmi < 25.0)
                    return "Норма";
                else if (bmi >= 25.0 && bmi < 30.0)
                    return "Предожирение";
                else if (bmi >= 30.0 && bmi < 35.0)
                    return "Ожирение первой степени";
                else if (bmi >= 35.0 && bmi < 40.0)
                    return "Ожирение второй степени";
                else
                    return "Ожирение третей степени";
            }
            public string ToString()
            {
                return $"Пол: {Sex}, Вес: {Weight}, Рост: {Height}, Результат: \n\"Ваш ИМТ: {bmi}({Mark_bmi})\"";
            }
            public void Round(int simb)
            {
                bmi = Math.Round(bmi, simb);
            }
        };
        static double MidBmi(List<BMI> bmi)
            {
                double s = 0;
                int n = 0;
                foreach (BMI el in bmi)
                {
                    s += el.bmi;
                    n++;
                }
                return s / n;
            }
        static void print(List<BMI> bmi)
            {
                foreach (BMI el in bmi)
                {
                    Console.WriteLine(el.ToString());
                }
            }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var l = new BMI(Convert.ToChar(textBox.Text), Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            l.Round(Convert.ToInt32(textBox3.Text));
            MessageBox.Show(l.ToString());
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
        

       
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        //private void textBox1_TextChanged(object sender, EventArgs e)
        // {

        // }
    }
}
