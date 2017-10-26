using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface IFilms
    {
        string Name { get; set; }
        string Country { get; set; }
        double Budget { get; set; }
    }
}