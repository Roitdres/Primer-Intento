using Modelo;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Control
{
    public class CtrlCandidato
    {




        private static List<Candidato> listaCandidatos = new List<Candidato>();

        public static List<Candidato> ListaCandidatos { get => listaCandidatos; set => listaCandidatos = value; }

        public bool ExisteCedula(string cedula)
        {
            foreach (Candidato candidato in ListaCandidatos)
            {
                if (candidato.Cedula == cedula)
                {
                    return true;
                }
            }
            return false;
        }

        public string RegistrarCandidato(int nroLista, string cedula, string nombre, int edad)
        {
            if (ExisteCedula(cedula))
            {
                return "Ya existe un candidato registrado con esta cédula.";
            }

            Candidato candidato = new Candidato(nroLista, cedula, nombre, edad);
            ListaCandidatos.Add(candidato);
            return "Candidato registrado satisfactoriamente."+candidato;
        }

        public string ListarCandidatos()
        {
            string mensaje = "";
            foreach (Candidato candidato in ListaCandidatos)
            {
                mensaje += candidato.ToString() + "\n\n";
            }
            return mensaje;
        }




        public void LlenarGrid(DataGridView dvgCandidatos)
        {
            int i = 0;
            dvgCandidatos.Rows.Clear();
            foreach (Candidato x in ListaCandidatos)
            {
                i = dvgCandidatos.Rows.Add();
                dvgCandidatos.Rows[i].Cells["colNro"].Value = x.NroLista;
                dvgCandidatos.Rows[i].Cells["colCedula"].Value = x.Cedula;
                dvgCandidatos.Rows[i].Cells["colNombre"].Value = x.Nombre;
                dvgCandidatos.Rows[i].Cells["colEdad"].Value = x.Edad;
            }
        }

    }
}




