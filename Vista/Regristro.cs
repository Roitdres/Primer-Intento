using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;

namespace Vista
{
    public partial class Regristro : Form
    {
        private CtrlCandidato CtrlCandidato=new CtrlCandidato();
        public Regristro()
        {
            InitializeComponent();
        }

        

        private void txtNroLista_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            
            if (char.IsDigit(e.KeyChar) && txtCedula.Text.Length >= 10)
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar) && txtCedula.Text.Length >= 10)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void btnRegrsitrar_Click(object sender, EventArgs e)
        {

            int nroLista = Convert.ToInt32(txtNroLista.Text.Trim());
             string cedula= txtCedula.Text.Trim();
            string nombre=txtNombre.Text.Trim();
            int edad = Convert.ToInt32(txtEdad.Text.Trim());

            string resultado = CtrlCandidato.RegistrarCandidato(nroLista,cedula,nombre,edad);
            MessageBox.Show(resultado);

            txtNroLista.Clear();
            txtCedula.Clear();
            txtNombre.Clear();
            
        }
    }


}
