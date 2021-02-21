using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using ConsoleAppDesafio2.Models;

namespace ConsoleAppDesafio2
{
    public class Repository
    {
        public List<DadosMoeda> GetDadosMoeda()
        {
            var listaDadosMoeda = new List<DadosMoeda>();
            var lista = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\DocsCsv\DadosMoeda.csv");
            foreach(var lin in lista)
            {
                string[] values = lin.Split(';');
                listaDadosMoeda.Add(new DadosMoeda()
                {
                    ID_MOEDA = values[0].ToString(),
                    DATA_REF = Convert.ToDateTime(values[1])
                });
            }

            return listaDadosMoeda;
            //.ToArray<DadosMoeda>().AsParallel<DadosMoeda>();
                                                       //.Skip(1)
                                                       //.Select(v => DadosMoeda.FromCsv(v))
                                                       //.ToList();
        }
    }
}
