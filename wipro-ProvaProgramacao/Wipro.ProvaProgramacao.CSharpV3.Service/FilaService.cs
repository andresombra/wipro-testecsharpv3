using System;
using System.Collections.Generic;
using System.Text;
using Wipro.ProvaProgramacao.CSharpV3.Domain.Dto;
using Wipro.ProvaProgramacao.CSharpV3.Domain.Entities;
using Wipro.ProvaProgramacao.CSharpV3.Infra.Interface;
using Wipro.ProvaProgramacao.CSharpV3.Service.Interface;

namespace Wipro.ProvaProgramacao.CSharpV3.Service
{
    public class FilaService : IFilaService
    {
        private readonly IFilaRepository _filaRepository;

        public FilaService(IFilaRepository filaRepository)
        {
            _filaRepository = filaRepository;
        }
        public Retorno AddItem(Moedas item)
        {
            return _filaRepository.AddItem(item);
        }

        public Retorno AddItemRanger(List<MoedaDto> listaMoedas)
        {
            return _filaRepository.AddItemRanger(listaMoedas);
        }

        public string GetItemLista()
        {
           return _filaRepository.GetItemLista();
        }

        public void ValidarListaItem(List<MoedaDto> lista)
        {
            _filaRepository.ValidarListaItem(lista);
        }

        public void VerificarDataValida(string data, int id)
        {
            _filaRepository.VerificarDataValida(data, id);
        }
        
    }
}
