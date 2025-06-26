using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_11
{
    public partial class fmrDescuento : Form
    {
        public fmrDescuento()
        {
            InitializeComponent();
            lblError.Text = string.Empty;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                lblError.Text = "No deje el campo vacio";
            }
            else
            {
                double precioSinDescuento, precioDescuento, precioFinal;
                precioSinDescuento = double.Parse(txtPrecio.Text);
                if (precioSinDescuento <= 0)
                {
                    lblError.Text = "Ingresa un valor mayor a 0";
                }
                else
                {
                    precioDescuento = precioSinDescuento * 0.65;
                    precioFinal = precioSinDescuento - precioDescuento;
                    txtConDesceunto.Text = precioFinal.ToString("N2");
                    txtPrecio.ReadOnly = true;
                }
            }
        }

        private void btnRealizarOtro_Click(object sender, EventArgs e)
        {
            txtPrecio.ReadOnly = false;
            txtPrecio.Clear();
            txtConDesceunto.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
 