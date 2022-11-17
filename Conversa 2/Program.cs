using System;
using System.Collections.Generic;
using System.Text;

namespace Conversa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ola,eu sou um programa, e vou fazer algumas perguntas");

            Console.WriteLine("você é um homen");

            string Resposta = "sim";

            switch (Resposta)

                
            {
                case "sim":
                    
                    StartService(Console.ReadLine());
                    Console.WriteLine("legal ");
                    break;

                case "nao":
                    
                    StopService();
                    Console.WriteLine("legal ");
                    break;
                                                       

                default:
                    Console.WriteLine(String.Format("unknonw command: {0}", Resposta));
                    break;



            }












        }

        private static void StartService(string v)
        {
            throw new NotImplementedException();
        }

        
        

       
        

        private static void StartService()
        {
            // throw new NotImplementedException();
            Console.WriteLine("iniciando serviço");
        }

        private static void StopService()
        {
            // throw new NotImplementedException();
            Console.WriteLine("parando serviço");
        }
    }
}
