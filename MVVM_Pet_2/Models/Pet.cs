using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MVVM_Pet_2
{
    public partial class Pet
    {
        public int Id { get; set; }
        public string Passport { get; set; }
        public string PetName { get; set; }
        public string PetType { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public string Info { get; set; }
        public Client Client { get; set; }
    }
}
