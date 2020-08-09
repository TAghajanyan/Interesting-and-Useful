using System;
using System.Collections.Generic;

namespace NumberToWordsonverter.Models
{
    class ModelBase
    {
        public IList<Tuple<int, string>> Ones { get; set; }
        public IList<Tuple<int, string>> Tens { get; set; }
        public IList<Tuple<int, string>> Teens { get; set; }
        public IList<Tuple<int, string>> Hundreds { get; set; }

    }
}
