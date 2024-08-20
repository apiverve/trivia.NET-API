using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("question")]
    public string question { get; set; }

    [JsonProperty("answer")]
    public string answer { get; set; }

    [JsonProperty("options")]
    public string[] options { get; set; }

    [JsonProperty("category")]
    public string category { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
