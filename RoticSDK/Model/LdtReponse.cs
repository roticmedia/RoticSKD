using System;
using System.Collections.Generic;
using System.Text;

namespace RoticSDK.Model
{
    public class LtdResponse
    {
        public string language { get; set; }
        public string @short { get; set; }
        public string small { get; set; }
        public int fa_char { get; set; }
        public int en_char { get; set; }
    }

    public class RoticSDKLtdModel
    {
        public Provider provider { get; set; }
        public LtdResponse response { get; set; }
        public bool status { get; set; }
        public Error error { get; set; }
    }
}
