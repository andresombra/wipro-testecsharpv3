using System;
using System.Collections.Generic;
using System.Text;
using Wipro.ProvaProgramacao.CSharpV3.Domain.Dto;
using Wipro.ProvaProgramacao.CSharpV3.Domain.Entities;

namespace Wipro.ProvaProgramacao.CSharpV3.Service.Interface
{
    public interface IFilaService
    {
        Retorno AddItem(Moedas item);

        Retorno AddItemRanger(List<MoedaDto> listaMoedas);

        void ValidarListaItem(List<MoedaDto> lista);

        void VerificarDataValida(string data, int id);

        string GetItemLista();
    }
}
