using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_9
{
    public partial class fmrCalcularCambio : Form
    {
        public fmrCalcularCambio()
        {
            InitializeComponent();
            lblError.Text = string.Empty;
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDineroCliente.Text) || string.IsNullOrEmpty(txtPrecioProducto.Text))
            {
                lblError.Text = "Hay un campo vacio, por favor verificar";
            }
            else
            {
                double precioProducto, resultadoCambio, dineroCliente;
                precioProducto = double.Parse(txtPrecioProducto.Text);
                dineroCliente = double.Parse(txtDineroCliente.Text);
                if (precioProducto <= 0 || dineroCliente <= 0)
                {
                    lblError.Text = "Ingrese un valor mayor a 0";
                }
                else
                {
                    if(dineroCliente < precioProducto)
                    {
                        lblError.Text = "La cantidad de dinero es menor que el valor";
                    }
                    else
                    {
                        resultadoCambio = dineroCliente - precioProducto;
                        txtCambioEntregar.Text = resultadoCambio.ToString("N2");
                        lblError.Text = "";
                        txtDineroCliente.ReadOnly = true;
                        txtPrecioProducto.ReadOnly = true;
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtDineroCliente.ReadOnly = false;
            txtPrecioProducto.ReadOnly = false;
            txtPrecioProducto.Clear();
            txtDineroCliente.Clear();
            txtCambioEntregar.Clear();
        }
    }
}
