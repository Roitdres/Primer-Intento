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
    public partial class Reporte : Form
    {
        CtrlCandidato ctrlcand= new CtrlCandidato();
        public Reporte()
        {
            InitializeComponent();
            
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            ctrlcand.LlenarGrid(dtgCandidatos);
        }
    }
}
