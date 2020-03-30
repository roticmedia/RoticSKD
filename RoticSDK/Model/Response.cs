using System;
using System.Collections.Generic;
using System.Text;

namespace RoticSDK.Model
{
    public class Provider
    {
        public string website { get; set; }
        public string source { get; set; }
    }

    public class Error
    {
        public object code { get; set; }
        public object message { get; set; }
    }

    public class RoticSDKModel
    {
        public Provider provider { get; set; }
        public string response { get; set; }
        public bool status { get; set; }
        public Error error { get; set; }
    }
}
