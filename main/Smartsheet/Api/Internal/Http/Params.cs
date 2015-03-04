using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smartsheet_csharp_sdk.main.Smartsheet.Api.Internal.Http
{
    public class Params
    {

        public List<KeyValuePair<string, string>> _parameters;

        public Params()
        {
            _parameters = new List<KeyValuePair<string, string>>();
        }

        public List<KeyValuePair<string, string>> Parameters
        {
            get
            {
                return _parameters;
            }
        }

        public void Add(string key, string value)
        {
            _parameters.Add(new KeyValuePair<string, string>(key, value)); 
        }

    }
}
