using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class FeatureFilm : Film
    {
        private string _casting;
        public string Casting
        {
            get
            {
                return _casting;
            }
            set
            {
                _casting = value;
            }
        }

        public override void ShowCasting()
        {
            Console.WriteLine($"Актёрский состав: {Casting}");
        }

        public override string ToString()
        {
            return $"Художественный фильм {Name}";
        }
    }
}