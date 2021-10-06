using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Negocio
{
    class NClsUsuario
    {

        public string ACCESO(ClsUsuario usuario)
        {

            if (usuario.Nombre == "Joel Molina" || usuario.Contraseña == 123)

            {

                return "Inicio de Sesion correcto puedes continuar con el proceso de venta";
            }
            else
            {
                return "Nombre de usuario incorrecto";



            }
        }
    }
}

