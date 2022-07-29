using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoSenac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void CalcularFrete()
        {
            var nome= txtNome.Text;
            decimal valor=decimal.Parse(txtValor.Text);
            var estado = cbxUf.SelectedItem.ToString();
            decimal frete = 0;
            decimal valorTotal = 0;
            decimal valorCompra = 0;

            

            if (valor>1000){
                frete= 0;
            }

            else if (estado == "SP")
            {
                frete=5;
            }
            else if (estado == "RJ")
            {
                frete=10;
            }
            else if (estado == "AM")
            {
                frete = 20;
            }
            else
                frete = 15;

            valorTotal = frete + valor;
            txtValor.Text = valor.ToString("C");
            lblFrete.Text = frete.ToString("C");
            lblTotal.Text = valorTotal.ToString("C");
            lblValorCompra.Text = valor.ToString("C");
        }
        void LimparCampos()
        {
            txtValor.Clear();
            txtNome.Clear();
            cbxUf.Text = " ";
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularFrete();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

    }
}
