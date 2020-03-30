using System;
using System.Collections.Generic;
using System.Text;

namespace RoticSDK.Model
{
    public class TdtResponse
    {
        public string word { get; set; }
        public string language { get; set; }
        public string group { get; set; }
        public string related_groups { get; set; }
        public string phrase { get; set; }
        public string initial_word { get; set; }
    }

    public class RoticSDKTdtModel
    {
        public Provider provider { get; set; }
        public List<TdtResponse> response { get; set; }
        public bool status { get; set; }
        public Error error { get; set; }
    }
}
