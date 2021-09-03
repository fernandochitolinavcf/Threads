using System;
using System.Threading;

namespace Threads
{

    public class Program

    {

        public static void Main(string[] args)
        {

            string strTipoArquivo = "CSV";

            //Vamos percorrer todos os arquivos da pastas que vão estar os arquivos e vamos startar varias threads para processar todos os arquivos em paralelo.
            //Se impactar na operação podemos criar um serviço que roda na madrugada para executar as tarefas.


            switch (strTipoArquivo)
            {

                case "CSV":

                    Thread t = new Thread(new ThreadStart(ImportaCsv));
                    t.Start();

                    break;

                case "TXT":


                    Thread t1 = new Thread(new ThreadStart(ImportaTxt));
                    t1.Start();

                    break;


            }

        }

        public static void ImportaCsv()
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine("Thread {0}", i);
                Thread.Sleep(1000);

            }
        }


        public static void ImportaTxt()
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine("Thread {1}", i);
                Thread.Sleep(1000);

            }
        }

    }
}
