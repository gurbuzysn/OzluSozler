using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzluSozler
{
    public class OzluSoz
    {
        public string Soz { get; set; }
        public string Yazar { get; set; }
        public int Derece { get; set; }

        public string Ozet { get { return $"{new string('★',Derece)}{new string('☆', 5 - Derece)} {Soz} -{Yazar}";  } }

    }
}
