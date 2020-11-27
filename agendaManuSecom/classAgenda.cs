using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agendaManuSecom
{
    class classAgenda
    {
        private int tecnico;
        private string codigoCliente;
        private string contaOperacional;
        private string nomeCliente;
        private DateTime dataAgendamento;
        private string motivo;
        private string situacao;

        public int Tecnico { get => tecnico; set => tecnico = value; }
        public string CodigoCliente { get => codigoCliente; set => codigoCliente = value; }
        public string ContaOperacional { get => contaOperacional; set => contaOperacional = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public DateTime DataAgendamento { get => dataAgendamento; set => dataAgendamento = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Situacao { get => situacao; set => situacao = value; }
    }
}
