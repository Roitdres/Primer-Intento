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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void regristroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Regristro regristro = new Regristro();  
            regristro.ShowDialog(); 
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.ShowDialog(this);
        }

        //Agregar menuSTRIP
    }
}
