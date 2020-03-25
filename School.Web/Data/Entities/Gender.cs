
namespace School.Web.Data.Entities
{
using System.Collections.Generic;

    public class Gender:IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
