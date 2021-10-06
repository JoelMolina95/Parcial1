using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Entidades
{
    class ClsUsuario
    {
        private String nombre;
        private int contraseña;

        public ClsUsuario()
        {
        }

        public ClsUsuario(string nombre, int contraseña)
        {
            this.Nombre = nombre;
            this.Contraseña = contraseña;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Contraseña { get => contraseña; set => contraseña = value; }
    }

      
    }

