using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Socket_Reflection.WebSocket
{

    public class Server
        {
        IPHostEntry host;





        /*private Socket srv;
        private readonly int puerto = 1024;
        private Socket srvListen;

        // Crea el servidor de socket instanciado en la variable srv
        public bool CreateSocketSrv(int port)
        {
            try
            {
               // srv = new Socket();
                srv.Bind(new IPEndPoint(IPAddress.Any, port));
                srv.Listen(10);
                return true;
            }
            catch (SocketException)
            {
                return false;
            }
        }

        public void ListenerSocket()
        {
            CreateSocketSrv(puerto); // se crea el socket en el puerto especificado
            try
            {
                while (true)
                {
                    Console.WriteLine("Esperando solicitud..!");
                    srvListen = srv.Accept(); // espera por conexión de un cliente...

                    NetworkStream ns = new NetworkStream(srvListen);
                    StreamReader sr = new StreamReader(ns);

                    string msg = sr.ReadLine();
                    Console.WriteLine("mensaje recibido: " + msg);
                    this.SentToCli("Mensaje recibido ok ... (Srv)");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("error al escuchar el mensaje del cliente: " + e.Message);
            }
        }

        public void SentToCli(string data)
        {
            try
            {
                Console.WriteLine("Enviando Respuesta...");
                NetworkStream ns = new NetworkStream(srvListen);
                StreamWriter sw = new StreamWriter(ns);

                sw.WriteLine(data);
                sw.Flush();

                sw.Close();
                ns.Close();
                srvListen.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("error al enviar respuesta: " + e.Message);
            }
        }

       public static void Main(string[] args)
        {
            Server s = new Server();
            s.ListenerSocket();
        }*/
    }
}
