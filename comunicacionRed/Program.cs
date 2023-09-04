using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace comunicacionRed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebRequest peticion = WebRequest.Create("http://www.mercadolibre.com.co");
            WebResponse respuesta = peticion.GetResponse();
            StreamReader  respuestaCadena = new StreamReader(respuesta.GetResponseStream());
            string responseText = respuestaCadena.ReadToEnd();
            Console.WriteLine(responseText);
            respuestaCadena.Close();
            Console.ReadKey();
        }
    }
}
