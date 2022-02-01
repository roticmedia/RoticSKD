using Newtonsoft.Json;
using RoticSDK;
using RoticSDK.Model;
using System;
using System.Linq;

namespace RoticSDK
{
    public class Connect
    {

        private string token,api,ut,bName,bDescription,bDomain,bLogo;


        public string BusinessName
        {
            get
            {
                return bName;
            }
        }
        public string Description
        {
            get
            {
                return bDescription;
            }
        }
        public string Domain
        {
            get
            {
                return bDomain;
            }
        }
        public string Logo
        {
            get
            {
                return bLogo;
            }
        }
        public string Token
        {
            get
            {
                return token;
            }
            set
            {
                token = value;
            }
        }
        public string Api
        {
            get
            {
                return api;
            }
            set
            {
                api = value;
            }
        }
        public string UniqueToken
        {
            get
            {
                return ut;
            }
            set
            {
                ut = value;
            }
        }

        private static Random random = new Random();


        public Connect()
        {
            ut = RandomString(20);
        }
        private static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //public RoticSDKInitModel init(string unique_token=null)
        //{
        //    try
        //    {
        //        if (token != null & api != null)
        //        {
        //            string Result = Request.MakeRequest(this.token, this.api, unique_token != null ? unique_token : this.ut, "/init");

        //            RoticSDKInitModel response = JsonConvert.DeserializeObject<RoticSDKInitModel>(Result);
        //            bName = response.response.name;
        //            bDescription = response.response.description;
        //            bDomain = response.response.domain;
        //            bLogo = "https://rotic.ir/storage/enterprise_logo/" + response.response.enterprise_logo;

        //            return response;
        //        }
        //        else if(token == null){

        //            RoticSDKInitModel model = new RoticSDKInitModel();
        //            model.error.message = "Token not specified to the server!";
        //            model.error.code = 21;
        //            model.provider.source = "Rotic .NET SDK";
        //            model.provider.website = "https://rotic.ir";
        //            model.response = null;
        //            model.status = false;

        //            return model;
        //        }
        //        else if (api == null)
        //        {

        //            RoticSDKInitModel model = new RoticSDKInitModel();
        //            model.error.message = "Api Token not specified to the server!";
        //            model.error.code = 22;
        //            model.provider.source = "Rotic .NET SDK";
        //            model.provider.website = "https://rotic.ir";
        //            model.response = null;
        //            model.status = false;

        //            return model;
        //        }
        //        else
        //        {
        //            RoticSDKInitModel model = new RoticSDKInitModel();
        //            model.error.message = "Unknown error happened";
        //            model.error.code = 304;
        //            model.provider.source = "Rotic .NET SDK";
        //            model.provider.website = "https://rotic.ir";
        //            model.response = null;
        //            model.status = false;

        //            return model;
        //        }
        //    }
        //    catch (Exception e)
        //    {

        //        Console.WriteLine(e.Message);

        //        RoticSDKInitModel model = new RoticSDKInitModel();
        //        model.error.message = e.Message;
        //        model.error.code = e.HResult;
        //        model.provider.source = "Rotic .NET SDK";
        //        model.provider.website = "https://rotic.ir";
        //        model.response = null;
        //        model.status = false;

        //        return model;

        //    }
        //}

        public RoticSDKModel chat(string data, string unique_token = null)
        {
            try
            {


                RoticSDKModel response = Request.MakeRequestAsync(this.token, data);


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
