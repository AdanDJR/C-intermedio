using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_SRP
{
    public class ServicioCorreo
    {
        public void EnviarCorreoElectronico(string enviador, string mensaje)
        {
            Console.WriteLine($"Correo enviado por: {enviador}, Contenido: {mensaje}");
        }
    }
}
