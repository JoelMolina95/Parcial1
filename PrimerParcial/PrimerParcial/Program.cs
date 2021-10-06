using PrimerParcial.Entidades;
using PrimerParcial.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {

            ClsUsuario usuario = new ClsUsuario();
            NClsUsuario nclsusuario = new NClsUsuario();


            Console.WriteLine("Escriba su nombre: ");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Escriba su contaseña: ");
            usuario.Contraseña = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(nclsusuario.ACCESO(usuario));
            Console.ReadLine();


        }
    }
}
