
using aula09.ContentContext.Enums;

namespace aula09.ContentContext
{
    public class Lecture
    {
        public int Ordem { get; set; }

        public string Title { get; set; }

        public EContentLevel DurationInMinutes { get; set; }
    }
}