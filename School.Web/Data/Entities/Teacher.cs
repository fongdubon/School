﻿namespace School.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Teacher : IEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [MaxLength(30, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [MaxLength(10, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Display(Name = "Clave")]
        public string Key { get; set; }

        [Required(ErrorMessage = "{0} es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [Display(Name = "Fecha de contratación")]
        public DateTime HireDate { get; set; }

        [Display(Name = "Fotografía")]
        public string ImageUrl { get; set; }

        [Display(Name = "Nombre completo")]
        public string FullName => $"{LastName} {FirstName}";

        public Gender Gender { get; set; }
    }
}