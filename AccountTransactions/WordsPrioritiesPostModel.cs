using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace AccountTransactions
{
    class WordsPrioritiesPostModel
    {
        public string language { get; set; }
        public int Amount { get; set; }
        public int Offset { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public SortingVariants SortingVariant { get; set; }
    }
}
