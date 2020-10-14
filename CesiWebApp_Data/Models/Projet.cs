using System;
using System.Collections.Generic;
using System.Text;

namespace CesiWebApp_Data.Models
{
    public class Projet
    {
        public int Id { get; set; }

        public string  Nom { get; set; }
        public Utilisateur Chef { get; set; }
    }
}
