using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Wipro.ProvaProgramacao.CSharpV3.Domain.Dto
{
    public class MoedaDto
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string moeda { get; set; }
        public string data_inicio { get; set; }
        public string data_fim { get; set; }
    }
}
