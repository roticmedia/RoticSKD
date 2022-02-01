// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using System.Collections.Generic;

public class Provider
{
    public string website { get; set; }
    public string source { get; set; }
}

public class Response
{
    public string value { get; set; }
    public List<string> buttons { get; set; }
    public string images { get; set; }
    public string type { get; set; }
}

public class Options
{
}

public class Error
{
    public int code { get; set; }
    public string message { get; set; }
}

public class RoticSDKModel
{
    public Provider provider { get; set; }
    public int status { get; set; }
    public List<Response> response { get; set; }
    public Options options { get; set; }
    public Error error { get; set; }
}

