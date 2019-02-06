using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDti.Parte2
{
    class Dados
    {
        public static ObservableCollection<Resultado> CarregarDados
        {
            get
            {
                ObservableCollection<Resultado> lista = new List<Resultado>();
                lista.Add(new Resultado()
                {
                    BloqueadoPor = "Solicitação de serviço",
                    Bloquear = "Cálculo",
                    Cliente = "Cliente Bom",
                    Contrato = "ZZZ52364",
                    DataDisponibilizacao = new DateTime(),
                    DataLimite = new DateTime(),
                    GeracaoFatura = "Fatura sempre",
                    Inicio = new DateTime(),
                    Justificativa = "Muito bom",
                    Placa = "asc1234",
                    ServiçoDespesa = "Perda Total",
                    Solicitante = "admin",
                    SS = "22MMF/D"

                });

                lista.Add(new Resultado()
                {
                    BloqueadoPor = "Solicitação de serviço",
                    Bloquear = "Cálculo",
                    Cliente = "Cliente ruim",
                    Contrato = "ZZZ52364",
                    DataDisponibilizacao = new DateTime(),
                    DataLimite = new DateTime(),
                    GeracaoFatura = "Fatura nunca",
                    Inicio = new DateTime(),
                    Justificativa = "Muito ruim",
                    Placa = "zzz9999",
                    ServiçoDespesa = "Perda Total",
                    Solicitante = "admin",
                    SS = "666ZZF/D"
                });

                return lista;
            }
        }
    }
}
