﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wipro.ProvaProgramacao.CSharpV3.Domain.Entities
{
    public class Moedas
    {
        [JsonIgnore]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        
        [JsonProperty("moeda")]
        public string Moeda { get; set; }
        [JsonProperty("data_inicio")]
        public DateTime DataInicio { get; set; }
        [JsonProperty("data_fim")]
        public DateTime DataFim { get; set; }

        public string Mensagem { get; set; }
    }
}
