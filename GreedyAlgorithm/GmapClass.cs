using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyAlgorithm
{
    public class GmapClass
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Nome { get; set; }
    }

    public class GmapClassList
    {
        public IList<GmapClass> resultados { get; set; }
    }
}
