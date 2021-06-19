using Newtonsoft.Json;
using System;

namespace Consulta
{
    public class CEPClass
    {   [JsonProperty("logradouro")]
        public string Logradouro{ get; set; }

        [JsonProperty("complemento")]
        public string Complemento { get; set; }

        [JsonProperty("bairro")]
        public string Bairro { get; set; }

        [JsonProperty("localidade")]
        public string Localidade { get; set; }

        [JsonProperty("uf")]
        public string UF { get; set; }

    }
}
