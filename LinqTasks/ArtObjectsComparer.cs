using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTasks
{
    class ArtObjectsComparer : IEqualityComparer<ArtObject>
    {
        public bool Equals(ArtObject x, ArtObject y)
        {
            //TODO: Add implementation
            throw new NotImplementedException();
        }

        public int GetHashCode(ArtObject obj)
        {
            return obj.Author.GetHashCode() ^
                   obj.Year.GetHashCode() ^
                   obj.Author.GetHashCode();
        }
    }
}
