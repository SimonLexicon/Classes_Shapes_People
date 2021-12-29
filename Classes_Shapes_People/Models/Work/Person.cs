using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Shapes_People.Models.Work
{
    public class Person : IInformation
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string HomeAdress { get; set; }

        public Person(string name, string phone, string adress)
        {
            this.Name = name;
            this.Phone = phone;
            this.HomeAdress = adress;
        }

        public string Info()
        {
            return $"{IInformation.INFOTEXT}\n {Name} \n {Phone} \n {HomeAdress}";
        }
    }
}
