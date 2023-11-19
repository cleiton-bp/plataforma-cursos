using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula09.ContentContext
{
    public class CareerItem
    {
        public CareerItem(
            int order,
            string title,
            string descripions,
            Course course)
        {
            if (course == null)
                throw new System.Exception("O curso nao pode ser nulo");
            
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