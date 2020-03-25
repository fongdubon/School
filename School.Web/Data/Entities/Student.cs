namespace School.Web.Data.Entities
{
    using System;

    public class Student : IEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Enrollment { get; set; }

        public DateTime BirthDate { get; set; }

        public string ImageUrl { get; set; }

        public string FullName => $"{LastName} {FirstName}";

        public Gender Gender { get; set; }
    }
}
