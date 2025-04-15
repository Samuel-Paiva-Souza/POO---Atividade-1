using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAtividadePooB
{
    public partial class frmAtividade1: Form
    {
        double num1, num2, result;

        public frmAtividade1()
        {
            InitializeComponent(); 
             
            
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtNumero1.Clear();
            txtNumero2.Clear();

            txtNumero1.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNumero1.Text);
            num2 = Convert.ToDouble(txtNumero2.Text);

            result = (num1 * num2);

            txtResultado.Text = result.ToString();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNumero1.Text);
            num2 = Convert.ToDouble(txtNumero2.Text);

            result = (num1 + num2);

            txtResultado.Text = result.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNumero1.Text);
            num2 = Convert.ToDouble(txtNumero2.Text);

            result = (num1 - num2);

            txtResultado.Text = result.ToString();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtNumero1.Text);
            num2 = Convert.ToDouble(txtNumero2.Text);

            result = Math.Pow(num1, 1/num2);
            txtResultado.Text = result.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            num1 = Convert.ToDouble(txtNumero1.Text);
            num2 = Convert.ToDouble(txtNumero2.Text);

            result = (num1 / num2);

            txtResultado.Text = result.ToString();
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
