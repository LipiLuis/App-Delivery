using AppFooD.Models.FormasPagamentos;
using System;
using System.Collections.Generic;
using AppFooD.Helps;
using AppFood.Helps.Enum;

namespace AppFooD.Models
{
    public class Pedido : NotifyBase
    {
        public int PedidoId { get; set; }
        public string CodigoPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        //private DateTime _timeDate;
        // Sei que é gambiarra só estou te mostrando 

        /// <summary>
        /// /// essa desgraça nn é gambiarra
        /// </summary>
        // Funciona assim ->
        private DateTime _Temporizador;
        public DateTime Temporizador
        {
            get { return _Temporizador; }
            set { SetProperty(ref _Temporizador, value); }
        }
        public decimal Total { get; set; }
        public Endereco Endereco { get; set; }
        public int EstabelecimentoID { get; set; }
        public Estabelecimento Estabelecimento { get; set; }
        public Cartao Cartao { get; set; }

        private EnumTrackDelivery _EnumTrackDelivery;
        public EnumTrackDelivery EnumTrackDelivery
        {
            get { return _EnumTrackDelivery; }
            set { SetProperty(ref _EnumTrackDelivery, value); }
        }
        //public EnumTrackDelivery EnumTrackDelivery { get; set; }
        public virtual ICollection<ItemPedido> itensPedido { get; set; }

        public Pedido()
        {
            Temporizador = DateTime.Now.Date;
        }
    }
}
