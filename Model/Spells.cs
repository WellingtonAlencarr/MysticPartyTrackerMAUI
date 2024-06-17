using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticPartyTracker.Model
{
    public class Spells
    {
        public class Result {
            public string Index { get; set; }
            public string Name { get; set; }
            public int Level { get; set; }
            public string Url { get; set; }

        }

        public Result(string Index, string Name, int Level, string Url)
        {
            Index = Index;
            Name = Name;
            Level = Level;
            Url = Url;
        }

        public class Response
        {

            public int Count { get; set; }
            public List<Result> Results { get; set; }
        }

    }
}
