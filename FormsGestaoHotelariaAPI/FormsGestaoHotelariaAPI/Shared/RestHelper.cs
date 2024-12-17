using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace FormsGestaoHotelariaAPI.Shared
{
    public static class RestHelper
    {
        private static readonly string baseURL = "https://localhost:7056/api/";
        public static async Task<string> GetALL()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "Utilizadores"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }

                    }


                }
            }
            return string.Empty;
        }

        public static string FormatJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);
            return parseJson.ToString(Formatting.Indented);
        }

        public static async Task<string> Get(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "Utilizadores/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }

                    }


                }
            }
            return string.Empty;
        }

        public static async Task<string> Post(int id, string Nome, string Email, string Perfil, string Password)
        {
            var inputData = new
            {
                utilizadorID = id,
                nome = Nome,
                email = Email,
                perfil = Perfil,
                password = Password
            };

            string json = System.Text.Json.JsonSerializer.Serialize(inputData);

            using (HttpClient client = new HttpClient())
            {

                var input = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage res = await client.PostAsync(baseURL + "Utilizadores", input))
                {
                    using (HttpContent responseContent = res.Content)
                    {
                        string data = await responseContent.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data; 
                        }
                    }
                }
            }
            return string.Empty; 
        }

        public static async Task<string> PUT(int id, string Nome, string Email, string Perfil, string Password)
        {
            var inputData = new
            {
                utilizadorID = id,
                nome = Nome,
                email = Email,
                perfil = Perfil,
                password = Password
            };

            string json = System.Text.Json.JsonSerializer.Serialize(inputData);

            using (HttpClient client = new HttpClient())
            {

                var input = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpResponseMessage res = await client.PutAsync(baseURL + "Utilizadores/" + id, input))
                {
                    using (HttpContent responseContent = res.Content)
                    {
                        string data = await responseContent.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
        public static async Task<string> Delete(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync(baseURL + "Utilizadores/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }

                    }


                }
            }
            return string.Empty;
        }
    }
}
