using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_2_1
{
    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthDate { get; set; }
        public override string ToString()
        {
            return $@"{Name}
                      {Surname }
                      {Email }
                      {PhoneNumber }
                      {BirthDate }";
        }

    }
}
