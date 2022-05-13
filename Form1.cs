using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //зчитую дані з текстових полів, конвертую в числове значення

            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            //шукаю дискримінант

            double d = b * b - 4 * a * c;

            //1 варіант

            if (d < 0)
            {
                MessageBox.Show("Рівняння не має розв'язку - дискримінант менше нуля");
            }

            //2 варіант

            if (d == 0)
            {
                double x = (-b / (2 * a));
                MessageBox.Show("Дискримінант дорівнює нулю. Існує один корінь рівняння, що дорівнює числу" + x + ".");
            }

            //3 варіант

            if (d > 0)
            
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));

                MessageBox.Show("Дискримінант = " + d + ";  X1 = " + x1 + ";  X2 = " + x2 + " .");

