using System;
using System.Collections.Generic;
using System.Text;
using MyGameBackend.Entities.Abstract;

namespace MyGameBackend.Entities
{
    class Person:IEntity
    {
        public string NationalityNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }

    }
}
