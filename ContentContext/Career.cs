namespace aula09.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url)
            : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }

        public int TotalCorses => Items.Count;
        //=> expression body quando temos uma linha no get e sem termos o set


    }

}