using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenfuDemo
{ 
    public  class Person
    {
       
        public bool IsRegister { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public int Age { get; set; }
        public int NumberOfKids { get; set; }
        public Guid SystemId { get; set; }

        private string _middleName;
        public void SetMiddleName(string name) { _middleName = name; }
        public string EmailAddress { get; set; }
    }
}
