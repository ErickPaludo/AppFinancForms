using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosForms.Objetos
{
    public class Contas
    {
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public int tipo { get; set; }
        public DateTime Data { get; set; }

        public Contas(double valor, string descricao, int tipo, DateTime data)
        {
            Valor = valor;
            Descricao = descricao;
            this.tipo = tipo;
            Data = data;
        }
    }
}
