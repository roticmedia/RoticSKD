using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Requestor;
using RoticSDK.Model;

namespace RoticSDK
{
    internal class Request
    {
        internal static string MakeRequest(string token,string Data=null, string Uri = null)
        {
            try
            {
                Make Rq = new Make();

                string AiUri = "https://rotic.ir/api/v1/services/ai";

                Dictionary<string, string> Dict = new Dictionary<string, string>();


                Dict.Add("data", Data);
                Dict.Add("token", token);


                return Task.Run(() => Rq.RequestAsync(AiUri + Uri, Dict)).Result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return e.Message;
            }

        }
    }
}
