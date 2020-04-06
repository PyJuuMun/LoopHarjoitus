using System;
using System.Collections.Generic;
using System.Text;

namespace LoopHarjoitus
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public bool Employed;
        public int Money;

        public Person()
        {

        }

        public List<Hobby> hobbies = new List<Hobby>();
    }
}
