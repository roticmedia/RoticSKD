using System;
using System.Collections.Generic;
using System.Text;

namespace RoticSDK.Model
{

    public class Response
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string domain { get; set; }
        public string telegram { get; set; }
        public string bale { get; set; }
        public string instagram { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public string youtube { get; set; }
        public string enterprise_logo { get; set; }
        public int status { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string token { get; set; }
        public string expire { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
    }

    public class RoticSDKInitModel
    {
        public Provider provider { get; set; }
        public Response response { get; set; }
        public bool status { get; set; }
        public Error error { get; set; }
    }
}
