using plataformaCursos.NotificationContext;

namespace plataformaCursos.ContentContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid(); //gera um id novo a cada objeto
        }

        public Guid Id { get; set; }
    }
}