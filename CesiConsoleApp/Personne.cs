using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CesiConsoleApp
{
    class Personne
    {
        private String _nom { get; set; }
        class Animal
        {
            private string _nom;

            public Animal(string nom)
            {
                this.Nom = nom ?? throw new ArgumentNullException(nameof(nom));
            }

            public string Nom { get=>_nom; set=>_nom=value; }

            public string getNomLatin() 
            {
                return Nom + "us";
            }
        }

        [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
        class Poisson : Animal
        {
            private int _nombredeNageoire = 10;

            public Poisson(string Nom , int nombredeNageoire) : base(Nom)
            {
                this.NombredeNageoire = nombredeNageoire;
            }

            public int NombredeNageoire { get=> _nombredeNageoire; set=> _nombredeNageoire = value; }
            private string GetDebuggerDisplay()
            {
                return ToString();
            }
        }
        public string Nom
        {
            get { return _nom.ToUpper(); }
            set
            {
                if (value != "")
                {
                    _nom = value;
                }
            }
        }
    }
}
