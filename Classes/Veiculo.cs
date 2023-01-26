using LGAtividade02.Enums;
using System.Collections.Generic;

namespace LGAtividade02.Classes
{
    public class Veiculo
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public EnumTipo Tipo { get; set; }
        public string Placa { get; set; }
        public int OcupacaoMaxima { get; set; }
        public string Chassi { get; set; }
        public int PesoEmToneladas { get; set; }



        /// <summary>
        /// Método responsável por realizar o cadastro base de qualquer tipo de Veiculo.
        /// </summary>
        /// <param name="Codigo">Código</param>
        /// <param name="Descricao">Descrição</param>
        /// <param name="Placa">Placa</param>
        /// <param name="Tipo">Tipo</param>
        /// <returns>Objeto Veiculo com Codigo, Descricao, Placa e Tipo.</returns>
        private static Veiculo InserirVeiculo(int Codigo, string Descricao, string Placa, EnumTipo Tipo)
        {
            var Veiculo = new Veiculo();
            Veiculo.Codigo = Codigo;
            Veiculo.Descricao = Descricao;
            Veiculo.Placa = Placa;
            Veiculo.Tipo = EnumTipo.Carro;
            return Veiculo;
        }


        /// <summary>
        /// Método responsável por realizar o cadastro de um novo Carro.
        /// </summary>
        /// <param name="Codigo">Código</param>
        /// <param name="Descricao">Descrição</param>
        /// <param name="Placa">Placa</param>
        /// <param name="OcupacaoMaxima">Ocupação Máxima</param>
        /// <returns>Objeto Veiculo com Codigo, Descricao, Placa, Tipo e OcupacaoMaxima.</returns>
        public static Veiculo InserirCarro(int Codigo, string Descricao, string Placa, int OcupacaoMaxima)
        {
            var Veiculo = InserirVeiculo(Codigo, Descricao, Placa, EnumTipo.Carro);
            Veiculo.OcupacaoMaxima = OcupacaoMaxima;       
            return Veiculo;
        }


        /// <summary>
        /// Método responsável por realizar o cadastro de um novo Caminhão.
        /// </summary>
        /// <param name="Codigo">Código</param>
        /// <param name="Descricao">Descrição</param>
        /// <param name="Placa">Placa</param>
        /// <param name="Chassi">Chassi</param>
        /// <param name="Chassi">Peso em Toneladas</param>
        /// <returns>Objeto Veiculo com Codigo, Descricao, Placa, Tipo, Chassi e PesoEmToneladas.</returns>
        public static Veiculo InserirCaminhao(int Codigo, string Descricao, string Placa, string Chassi, int PesoEmToneladas)
        {
            var Veiculo = InserirVeiculo(Codigo, Descricao, Placa, EnumTipo.Caminhao);
            Veiculo.Chassi = Chassi;
            Veiculo.PesoEmToneladas = PesoEmToneladas;            
            return Veiculo;
        }


        /// <summary>
        /// Método responsável por obter um veículo por Código, seja Carro ou Caminhão.
        /// </summary>
        /// <param name="Codigo">Código do Veículo</param>
        /// <returns>Objeto Veículo.</returns>
        public static Veiculo ObtenhaVeiculo(int Codigo)
        {
            return new Veiculo();
        }


        /// <summary>
        /// Métodos responsável por obter uma lista de veículos por Tipo.
        /// </summary>
        /// <param name="Tipo"> Tipo de Veículo 0 - Todos (Padrão) | 1 - Carro | 2 - Caminhao </param>
        /// <returns>Lista de objetos Veículo.</returns>
        public static List<Veiculo> ObtenhaListaVeiculos(EnumTipo Tipo = EnumTipo.Todos)
        {
            switch (Tipo)
            {
                case EnumTipo.Carro:
                    return new List<Veiculo>(); //Retorna lista com somente Carros                    
                case EnumTipo.Caminhao:
                    return new List<Veiculo>(); //Retorna lista com somente Caminhões
                default:
                    return new List<Veiculo>(); //Retorna lista com todos os Veículos
            }
        }


        /// <summary>
        /// Método responsável por obter a Quantidade de Veículos por Tipo
        /// </summary>
        /// <param name="Tipo"> Tipo de Veículo 0 - Todos (Padrão) | 1 - Carro | 2 - Caminhao </param>
        /// <returns>Int com a quantidade de veículos.</returns>
        public static int ObtenhaQuantidadeDeVeiculos(EnumTipo Tipo = EnumTipo.Todos)
        {
            var listaVeiculos = new List<Veiculo>();

            return listaVeiculos.FindAll(v => v.Tipo == Tipo).Count; //Retorna lista de acordo com o Tipo desejado
        }

    }
}
