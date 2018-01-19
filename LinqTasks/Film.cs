using System.Collections;

namespace LinqTasks
{
    class Film : ArtObject
    {
        public int Length { get; set; }
        public IEnumerable Actors { get; set; }
    }
}