using Newtonsoft.Json;
using RoticSDK;
using RoticSDK.Model;
using System;

namespace RoticSDK
{
    public class Connect
    {

        private string token,bName,bDescription,bDomain,bLogo;


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


        public RoticSDKInitModel init(string Token)
        {
            try
            {

                this.token = Token;

                string Result = Request.MakeRequest(this.token,null,"/init");

                RoticSDKInitModel response = JsonConvert.DeserializeObject<RoticSDKInitModel>(Result);
                bName = response.response.name;
                bDescription = response.response.description;
                bDomain = response.response.domain;
                bLogo = "https://rotic.ir/storage/enterprise_logo/" + response.response.enterprise_logo;

                return response;

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

                RoticSDKInitModel model = new RoticSDKInitModel();
                model.error.message = e.Message;
                model.error.code = e.HResult;
                model.provider.source = "Rotic .NET Library";
                model.provider.website = "https://rotic.ir";
                model.response = null;
                model.status = false;

                return model;

            }
        }

        public RoticSDKModel chat(string Token ,string data)
        {
            try
            {

                this.token = Token;

                string Result = Request.MakeRequest(this.token, data);

                RoticSDKModel response = JsonConvert.DeserializeObject<RoticSDKModel>(Result);

                return response;

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

                RoticSDKModel model = new RoticSDKModel();
                model.error.message = e.Message;
                model.error.code = e.HResult;
                model.provider.source = "Rotic .NET Library";
                model.provider.website = "https://rotic.ir";
                model.response = null;
                model.status = false;

                return model;

            }
        }

        public RoticSDKLtdModel detectLanguage(string Token, string data)
        {
            try
            {

                this.token = Token;

                string Result = Request.MakeRequest(this.token, data,"/language-detection");

                RoticSDKLtdModel response = JsonConvert.DeserializeObject<RoticSDKLtdModel>(Result);

                return response;

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

                RoticSDKLtdModel model = new RoticSDKLtdModel();
                model.error.message = e.Message;
                model.error.code = e.HResult;
                model.provider.source = "Rotic .NET Library";
                model.provider.website = "https://rotic.ir";
                model.response = null;
                model.status = false;

                return model;

            }
        }

        public RoticSDKTdtModel detectTime(string Token, string data)
        {
            try
            {

                this.token = Token;

                string Result = Request.MakeRequest(this.token, data, "/time-detection");

                RoticSDKTdtModel response = JsonConvert.DeserializeObject<RoticSDKTdtModel>(Result);

                return response;

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);

                RoticSDKTdtModel model = new RoticSDKTdtModel();
                model.error.message = e.Message;
                model.error.code = e.HResult;
                model.provider.source = "Rotic .NET Library";
                model.provider.website = "https://rotic.ir";
                model.response = null;
                model.status = false;

                return model;

            }
        }

    }
}
