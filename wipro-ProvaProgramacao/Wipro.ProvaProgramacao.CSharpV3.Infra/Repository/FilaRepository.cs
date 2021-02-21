using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wipro.ProvaProgramacao.CSharpV3.Data;
using Wipro.ProvaProgramacao.CSharpV3.Domain.Dto;
using Wipro.ProvaProgramacao.CSharpV3.Domain.Entities;
using Wipro.ProvaProgramacao.CSharpV3.Infra.Interface;

namespace Wipro.ProvaProgramacao.CSharpV3.Infra.Repository
{
    public class FilaRepository : IFilaRepository
    {
        public Retorno AddItemRanger(List<MoedaDto> listaMoedas)
        {
            var retorno = new Retorno();
            try
            {
                ValidarListaItem(listaMoedas);

                var novaLista = new List<Moedas>();
                int seqItem = 0;
                listaMoedas.ForEach(x =>
                {
                    novaLista.Add(new Moedas()
                    {
                        Moeda = x.moeda,
                        DataInicio = DateTime.Parse(x.data_inicio),
                        DataFim = DateTime.Parse(x.data_fim)
                    });
                    seqItem++;
                });

                using (var ctx = new WiproContext())
                {
                    ctx.Set<Moedas>().AddRange(novaLista);
                    int ret = ctx.SaveChanges();
                    return new Retorno($"{seqItem} incluídos com sucesso.");
                }
            }
            catch (Exception ex) { return new Retorno(ex); }
        }

        public Retorno AddItem(Moedas item)
        {
            var retorno = new Retorno();
            try
            {
                using (var ctx = new WiproContext())
                {
                    ctx.Set<Moedas>().Add(item);
                    int ret = ctx.SaveChanges();
                    return new Retorno("Incluido com sucesso.");
                }
            }
            catch (Exception ex) { return new Retorno(ex); }
        }

        public void ValidarListaItem(List<MoedaDto> lista)
        {
            int seqItem = 0;
            try
            {
                lista.ForEach(x =>
                {
                    if (x.moeda.Length != 3) throw new Exception("moeda com valor invalido");
                    VerificarDataValida(x.data_inicio, seqItem);
                    VerificarDataValida(x.data_fim, seqItem);
                    x.Id = seqItem++;
                });
            }
            catch
            {
                throw;
            }
        }

        public void VerificarDataValida(string data, int id)
        {
            try
            {
                DateTime _data = DateTime.Parse(data);
            }
            catch
            {
                throw new Exception($"Index:{id} da lista com Data Invalida");
            }
        }

        public string GetItemLista()
        {
            try
            {
                using (var ctx = new WiproContext())
                {
                    var ultimoDaLista = ctx.Moedas.ToList().LastOrDefault<Moedas>();
                    if (ultimoDaLista != null)
                    {
                        var ultimoExcluir = ctx.Moedas.Find(ultimoDaLista.Id);
                        ctx.Moedas.Remove(ultimoExcluir);
                        ctx.SaveChanges();
                        
                        return JsonConvert.SerializeObject(ultimoDaLista, new JsonSerializerSettings() { DateFormatString = "yyyy-MM-dd" }).ToString();
                    }

                    return JsonConvert.SerializeObject(new Moedas() { Id = -1, Mensagem = "Nao existe registro a ser retornado." }); 
                }
            }
            catch (Exception exc)
            {
                return JsonConvert.SerializeObject(new Moedas() { Id = -1, Mensagem = exc.Message });
            }
        }

    }
}
