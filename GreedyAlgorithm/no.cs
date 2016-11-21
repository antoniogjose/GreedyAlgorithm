using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyAlgorithm 
{
    class no : IEquatable <no>, IEnumerable<no>
    {

        public int Euristic { get; set; }

        public int Index { get; set; }

        public bool CityBool { get; set; }

        public bool Visited { get; set; }

        public int LastNo { get; set; }



        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            no objAsPart = obj as no;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public int SortByEuristicAscending(int euristic_1, int euristic_2)
        {

            return euristic_1.CompareTo(euristic_2);
        }


        public int CompareTo(no comparePart)
        {
            // A null value means that this object is greater.
            if (comparePart == null)
                return 1;

            else
                return this.Euristic.CompareTo(comparePart.Euristic);
        } 
  

        public override int GetHashCode()
        {
            return Euristic;
        }

        public bool Equals(no other)
        {
            if (other == null) return false;
            return (this.Euristic.Equals(other.Euristic));
        }

        public IEnumerator<no> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
