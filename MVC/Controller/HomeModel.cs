using GastosForms.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosForms.MVC.Controller
{
    public class HomeModel
    {
        static Dictionary<int,Contas> contas = new Dictionary<int, Contas>();
        public Dictionary<int, Contas> Contas { get { return contas; } set { contas = value; } }
        public HomeModel() { }

        public void AddConta(Contas contasobj) {
            contas.Add(contas.Count + 1, contasobj);
        }
    }
}
