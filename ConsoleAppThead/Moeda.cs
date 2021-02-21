using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDesafio2
{
    public class Moedas
    {
        public int Id { get; set; }
              
        [JsonProperty("moeda")]
        public string Moeda { get; set; }

        [JsonProperty("data_inicio")]
        public DateTime DataInicio { get; set; }

        [JsonProperty("data_fim")]
        public DateTime DataFim { get; set; }

        [JsonProperty("mensagem")]
        public string Mensagem { get; set; }
    }
}
