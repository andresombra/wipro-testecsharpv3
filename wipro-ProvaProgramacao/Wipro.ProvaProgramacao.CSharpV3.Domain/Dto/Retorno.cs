using System;
using System.Collections.Generic;
using System.Text;

namespace Wipro.ProvaProgramacao.CSharpV3.Domain.Dto
{
    public class Retorno
    {
        public int Codigo { get; set; }
        public string Mensagem { get; set; }
       
        public Retorno()
        {

        }

        public Retorno(string msg)
        {
            this.Codigo = 1;
            this.Mensagem = msg;
        }

        public Retorno(Exception exc)
        {
            this.Codigo = -1;
            this.Mensagem = "Erro: "+exc.Message;
        }

        public Retorno Erro() { Codigo = -1; return this; }
    }
}
