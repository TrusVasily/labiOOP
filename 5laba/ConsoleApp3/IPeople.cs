using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface IPeople
    {
        string FirstName { get; set; }
        string Surname { get; set; }
        void Show();
    }
}