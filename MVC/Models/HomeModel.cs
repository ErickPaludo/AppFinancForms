using GastosForms.Objetos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static GastosForms.Objetos.Contas;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GastosForms.MVC.Models
{
    public class HomeModel
    {
        static List<Contas> contas = new List<Contas>();
        public List<Contas> Contas { get { return contas; } set { contas = value; } }
        public HomeModel() { }

        public void AddConta(Contas contasobj)
        {
            contas.Add(contasobj);
        }
        public async Task RecebeContas()
        {
            try
            {
                var objeto = await RecHttp.ExecutaRec(metodo: "GET");
                Contas.Clear();
                foreach (var obj in objeto.contasLista)
                {
                    Contas.Add(new Contas(obj.id, obj.valor, obj.titulo, obj.tipo, obj.data));
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public async Task EnviaContas(Contas conta)
        {
            try
            {
                await RecHttp.ExecutaRec(metodo: "POST", obj: conta);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public double Calcula(int type)
        {
            return Contas.Where(c => c.tipo == type).Sum(c => c.valor); ;
        }
        public async void AtualizaContas(ContasRec objeto)
        {
           await RecHttp.ExecutaRec("PUT",objeto);
        }
    }
}
