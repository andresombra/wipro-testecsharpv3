using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDesafio2.Models
{
    public class ResultadoMoedaCotacao
    {
        public string ID_MOEDA { get; set; }
        public DateTime DATA_REF { get; set; }
        public decimal VL_COTACAO { get; set; }
    }
}
