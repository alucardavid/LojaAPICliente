using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LojaAPICliente
{
    class Program
    {
        static void Main(string[] args)
        {
            string conteudo;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:57810/api/carrinho/1");
            request.Method = "GET";
            request.Accept = "application/xml";

            WebResponse response = request.GetResponse();

            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream);
                conteudo = reader.ReadToEnd();
            }

            Console.Write(conteudo);
            Console.Read();
        }
    }
}
