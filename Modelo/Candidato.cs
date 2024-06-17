using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Modelo
{
    public class Candidato
    {
        protected int nroLista;
        protected String cedula;
        protected String nombre;
        protected int edad;

        public int NroLista { get => nroLista; set => nroLista = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public  string Nombre { get => nombre; set => nombre = value; }
        public  int Edad { get => edad; set => edad = value; }

        public Candidato(int nroLista, string cedula, string nombre, int edad)
        {
            NroLista = nroLista;
            Cedula = cedula;
            Nombre = nombre;
            Edad = edad;
            
        }

        public override string ToString()
        {
            return "Nombre:"+Nombre+"Edad:"+Edad+"Cedula:"+Cedula+"Numero de Lista:"+NroLista;
        }
    }
}
