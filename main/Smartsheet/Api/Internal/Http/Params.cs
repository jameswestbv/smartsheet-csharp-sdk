using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smartsheet_csharp_sdk.main.Smartsheet.Api.Internal.Http
{
    public class Params
    {
        public Params()
        {
            Parameters = new List<KeyValuePair<string, string>>();
        }

        public List<KeyValuePair<string, string>> Parameters;

        public void Add(string key, string value)
        {
            Parameters.Add(new KeyValuePair<string, string>(key, value)); 
        }

    }
}
