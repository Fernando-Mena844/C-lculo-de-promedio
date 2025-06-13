using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cálculo_de_promedios
{
    public partial class frmSistemaDeNotasITR : Form
    {
        public frmSistemaDeNotasITR()
        {
            InitializeComponent();
            lblError.Text = string.Empty;
        }

        private void btnAgregarPromedio_Click(object sender, EventArgs e)
        {
            double n1, n2, n3;
            if (string.IsNullOrEmpty(txtNota1.Text)|| string.IsNullOrEmpty(txtNota2.Text)|| string.IsNullOrEmpty(txtNota3.Text))
            {
                lblError.Text = "Asegúrese de haber ingresado las tres notas";
            }
            else
            {
                if (double.TryParse(txtNota1.Text, out n1) && double.TryParse(txtNota2.Text, out n2) && double.TryParse(txtNota3.Text, out n3))
                {
                    if (n1 > 0 && n1 <= 10 && n2 > 0 && n2 <= 10 && n3 > 0 && n3 <= 10)
                    {
                        double promedio = (n1 + n2 + n3) / 3;
                        txtPromedio.Text = promedio.ToString("N2");
                        lblError.Text = string.Empty;
                        txtNota1.ReadOnly = true;
                        txtNota2.ReadOnly = true;
                        txtNota3.ReadOnly = true;
                    }
                    else
                    {
                        lblError.Text = "Asegúrese de que las 3 notas ingresadas estén entre 0 y 10";
                    }
                }
                else
                {
                    lblError.Text = "Asegúrese de ingresar un número en los 3 campos";
                }
            }
            
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota1.ReadOnly = false;
            txtNota2.ReadOnly = false;
            txtNota3.ReadOnly = false;
            txtPromedio.Clear();
            lblError.Text=string.Empty;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}