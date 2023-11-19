
namespace aula09.ContentContext
{
    public abstract class Content
    {
        public Content(string title, string url)
        {
            Id = Guid.NewGuid(); //gera um id novo a cada objeto
            Title = title;
            Url = url;
        }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

    }
}