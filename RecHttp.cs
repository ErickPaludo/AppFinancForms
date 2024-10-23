using GastosForms.MVC.Models;
using GastosForms.Objetos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace GastosForms
{
    public class RecHttp
    {
        public static async Task<dynamic> ExecutaRec(string metodo, dynamic obj = null)
        {
            try
            {

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new System.Uri("https://localhost:7138/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = new HttpResponseMessage();
                    switch (metodo)
                    {
                        case "GET":
                            response = await client.GetAsync("Gastos/ReturnContas");
                            ContasList objeto = new ContasList();
                            if (response.IsSuccessStatusCode)
                            {
                                var contas = await response.Content.ReadAsStringAsync();
                                objeto = JsonConvert.DeserializeObject<ContasList>(contas);
                                return objeto;
                            }
                            break;
                        case "GET_ID":
                            response = await client.GetAsync($"/Gastos/ReturnContas?id={obj}");
                            ContasList objetoid = new ContasList();
                            if (response.IsSuccessStatusCode)
                            {
                                var contas = await response.Content.ReadAsStringAsync();
                                objetoid = JsonConvert.DeserializeObject<ContasList>(contas);
                                return objetoid;
                            }
                            break;
                        case "POST":
                            var contasobj = new ContasList<ContasEnv>();
                            contasobj.contasLista.Add(new ContasEnv
                            {
                                valor = obj.valor,
                                titulo = obj.titulo,
                                tipo = obj.tipo,
                                data = obj.data
                            });

                            response = await client.PostAsJsonAsync("Gastos/EnvioContas", contasobj);
                            if (response.IsSuccessStatusCode)
                            {
                                return "";
                            }
                            break;
                        case "PUT":
                            var contasobjatlz = new ContasRec
                            {
                                valor = obj.valor,
                                titulo = obj.titulo,
                                tipo = obj.tipo,
                                data = obj.data,
                                id = obj.id
                            };

                            response = await client.PostAsJsonAsync("Gastos/AtualizaContas", contasobjatlz);
                            if (response.IsSuccessStatusCode)
                            {
                                return "";
                            }
                            break;

                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }

        }
    }
}
