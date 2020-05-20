﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventosTec.Web.Models.Entities
{
    public class User:IdentityUser
    {
        [Display(Name = "Nombre completo")]
        [MaxLength(150)]
        public string Fullname { get; set; }

        [Display(Name = "Descripcion")]
        [MaxLength(300)]
        public string Description { get; set; }

        [Display(Name = "Foto")]
        public string ImgUrl { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        public DateTime? BirthDate { get; set; }


       
    }
}
