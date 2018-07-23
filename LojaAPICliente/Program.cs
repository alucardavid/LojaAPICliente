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
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:57810/api/carrinho/");
            request.Method = "POST";
            request.Accept = "application/xml";

            string xml = "<Carrinho xmlns:i='http://www.w3.org/2001/XMLSchema-instance' xmlns='http://schemas.datacontract.org/2004/07/Loja.Models'><Endereco>Rua Iara 15, 8 andar, Sao Paulo</Endereco><Id>2</Id><Produtos><Produto><Id>6237</Id><Nome>PS5</Nome><Preco>4000</Preco><Quantidade>4</Quantidade></Produto></Produtos></Carrinho>";
            byte[] xmlBytes = Encoding.UTF8.GetBytes(xml);

            request.GetRequestStream().Write(xmlBytes, 0, xmlBytes.Length);
            request.ContentType = "application/xml";

            WebResponse response = request.GetResponse();

            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream);
                conteudo = reader.ReadToEnd();
            }

            Console.Write(conteudo);
            Console.Read();
        }

        private static void TestePostXml()
        {
            string conteudo;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:57810/api/carrinho/");
            request.Method = "POST";
            request.Accept = "application/xml";

            string xml = "<Carrinho xmlns:i='http://www.w3.org/2001/XMLSchema-instance' xmlns='http://schemas.datacontract.org/2004/07/Loja.Models'><Endereco>Rua Iara 15, 8 andar, Sao Paulo</Endereco><Id>2</Id><Produtos><Produto><Id>6237</Id><Nome>PS5</Nome><Preco>4000</Preco><Quantidade>4</Quantidade></Produto></Produtos></Carrinho>";
            byte[] xmlBytes = Encoding.UTF8.GetBytes(xml);

            request.GetRequestStream().Write(xmlBytes, 0, xmlBytes.Length);
            request.ContentType = "application/xml";

            WebResponse response = request.GetResponse();

            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream);
                conteudo = reader.ReadToEnd();
            }

            Console.Write(conteudo);
            Console.Read();
        }

        private static void TestePostJson()
        {
            string conteudo;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:57810/api/carrinho/");
            request.Method = "POST";
            request.Accept = "application/json";

            string json = "{'Produtos':[{'Id':6237,'Preco':4000.0,'Nome':'PS4','Quantidade':4}],'Endereco':'Rua Iara 15, 8 andar, Sao Paulo','Id':1}";
            byte[] jsonBytes = Encoding.UTF8.GetBytes(json);

            request.GetRequestStream().Write(jsonBytes, 0, jsonBytes.Length);
            request.ContentType = "application/json";

            WebResponse response = request.GetResponse();

            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream);
                conteudo = reader.ReadToEnd();
            }

            Console.Write(conteudo);
            Console.Read();
        }

        private static void TesteGet()
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
