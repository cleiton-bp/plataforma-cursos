using plataformaCursos.ContentContext;
using plataformaCursos.NotificationContext;

namespace aula09.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(
            int order,
            string title,
            string descripions,
            Course course)
        {
            if (course == null)
                AddNotification(new Notification("Course", "Curso invalido"));
            
            Order = order;
            Title = title;
            Descripions = descripions;
            Course = course;
        }

        public int Order { get; set; }
        public string Title { get; set; }
        public string Descripions { get; set; }
        public Course Course { get; set; }
    }
}