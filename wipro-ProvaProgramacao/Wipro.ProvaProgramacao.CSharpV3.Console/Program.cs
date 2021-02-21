using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Wipro.ProvaProgramacao.CSharpV3.Service.Interface;

namespace Wipro.ProvaProgramacao.CSharpV3.ConsoleApp
{
    public static class Program
    {
        private static readonly IFilaService _filaService;
        static bool flag = true;
              
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio ConsoleApp");
            var tarefa = new Thread(ExecutarTarefa);
            tarefa.Start();
        }
        static void ExecutarTarefa()
        {
            // for (int i = 0; i < 1000; i++)
            //   Console.Write("www.macoratti.net");
            int seq = 0;
            while (flag)
            {
                
                if (seq == 4) flag = false;
                Thread.Sleep(TimeSpan.FromSeconds(3));
                seq++;
                Console.WriteLine($"{seq} executou /n");
            }

        }
    }
}
