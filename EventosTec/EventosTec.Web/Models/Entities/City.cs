﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventosTec.Web.Models.Entities
{
    public class City
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Ciudad")]
        public string Name { get; set; }

        [Display(Name="Descripcion")]
        public string Description{ get; set; }

        [Display(Name="Pais")]
        public string  Slung { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
