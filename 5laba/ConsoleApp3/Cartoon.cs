using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Cartoon : Film
    {
        private string _voices;
        public string Voices
        {
            get
            {
                return _voices;
            }
            set
            {
                _voices = value;
            }
        }



        public override void ShowCasting()
        {
            Console.WriteLine($"Озвучка: {Voices}");
        }

        public override string ToString()
        {
            return $"Мультфильм {Name}";
        }
    }
}