using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoPizza.Services;

namespace ContosoPizza.Models
{
    public  class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool LivreDeGluten { get; set; }
    }
}