using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LabelNumero2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declarar variables

            string num1, num2;

            num1 = Labetxt1.Text;
            num2 = Labetxt2.Text;

            // Validar que no esta vacio 

            if (num1.Trim() == "")
            {
                MessageBox.Show("El numero 1 no puede estar vacio");
                return;
            }

            if (num2.Trim() == "")
            {
                MessageBox.Show("El numero 2 no puede estar vacio");
                return;
            }

            // Realizar el calculo 

            int resultado = int.Parse(num1) + int.Parse(num2);
            Labetxt3.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Declarar variables

            string num1, num2;

            num1 = Labetxt1.Text;
            num2 = Labetxt2.Text;

            // Validar que no esta vacio 

            if (num1.Trim() == "")
            {
                MessageBox.Show("El numero 1 no puede estar vacio");
                return;
            }

            if (num2.Trim() == "")
            {
                MessageBox.Show("El numero 2 no puede estar vacio");
                return;
            }

            // Realizar el calculo 

            int resultado = int.Parse(num1) - int.Parse(num2);
            Labetxt3.Text = resultado.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Declarar variables

            string num1, num2;

            num1 = Labetxt1.Text;
            num2 = Labetxt2.Text;

            // Validar que no esta vacio 

            if (num1.Trim() == "")
            {
                MessageBox.Show("El numero 1 no puede estar vacio");
                return;
            }

            if (num2.Trim() == "")
            {
                MessageBox.Show("El numero 2 no puede estar vacio");
                return;
            }

            // Realizar el calculo 

            int resultado = int.Parse(num1) * int.Parse(num2);
            Labetxt3.Text = resultado.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Declarar variables

            string num1, num2;

            num1 = Labetxt1.Text;
            num2 = Labetxt2.Text;

            // Validar que no esta vacio 

            if (num1.Trim() == "")
            {
                MessageBox.Show("El numero 1 no puede estar vacio");
                return;
            }

            if (num2.Trim() == "")
            {
                MessageBox.Show("El numero 2 no puede estar vacio");
                return;
            }

            // Realizar el calculo 

            int resultado = int.Parse(num1) / int.Parse(num2);
            Labetxt3.Text = resultado.ToString();
        }
    }
}
