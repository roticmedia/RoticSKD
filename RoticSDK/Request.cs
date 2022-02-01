using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Linq;
using RestSharp;

namespace RoticSDK
{
    internal class Request
    {
        private static Random random = new Random();

        private static string ut;

        public Request()
        {
        }
        internal static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        internal static RoticSDKModel MakeRequestAsync(string token, string api, string data = null, string unique_token=null, string uri = null)
        {
            try
            {
                ut = RandomString(10);

                string AiUri = "https://api.rotic.ir/v2/services/" + token + "/ai";

                var client = new RestClient(AiUri);

                var request = new RestRequest()
                  .AddParameter("data", data)
                  .AddParameter("api", api)
                  .AddParameter("unique_token", unique_token != null ? unique_token : ut)
                  .AddParameter("driver", "api (.NET SDK)");


                var response = client.PostAsync<RoticSDKModel>(request).Result;

                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                RoticSDKModel model = new RoticSDKModel();
                model.error.message = e.Message;
                model.error.code = e.HResult;
                model.provider.source = "Rotic .NET SDK";
                model.provider.website = "https://rotic.ir";
                model.response = null;
                model.status = 0;

                return model;
            }

        }
    }
}
