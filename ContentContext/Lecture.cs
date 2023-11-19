using aula09.ContentContext.Enums;
using plataformaCursos.ContentContext;

namespace aula09.ContentContext
{
    public class Lecture : Base
    {
        public int Ordem { get; set; }

        public string Title { get; set; }

        public EContentLevel DurationInMinutes { get; set; }
    }
}