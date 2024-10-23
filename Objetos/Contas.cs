using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosForms.Objetos
{
    public class Contas : ContasRec
    {
        
        public Contas(double valor, string descricao, int tipo, DateTime data)
        {
            this.valor = valor;
            titulo = descricao;
            this.tipo = tipo;
            this.data = data;
        }

        public Contas(int id, double valor, string descricao, int tipo, DateTime data)
        {
            this.id = id;
            this.valor = valor;
            titulo = descricao;
            this.tipo = tipo;
            this.data = data;
        }

        public Contas()
        {
        }
    }
    public class ContasList<T>
    {
        public List<T> contasLista { get; set; }

        public ContasList()
        {
            contasLista = new List<T>();
        }
    }
    public class ContasRec : ContasEnv
    {
        public int id { get; set; }
    }
    public class ContasEnv
    {
        public double valor { get; set; }
        public string titulo { get; set; }
        public int tipo { get; set; }
        public DateTime data { get; set; }
    }
    public class ContasList
    {
        public List<ContasRec> contasLista { get; set; }
    }
}
