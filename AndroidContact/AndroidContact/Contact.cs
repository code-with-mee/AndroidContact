﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AndroidContact
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FormattedName { get; set; }
        public string Organization { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Address> Addresses { get; set; }
    }

    public class Phone
    {
        public string Number { get; set; }
        public string Type { get; set; }
    }

    public class Address
    {
        public string Description { get; set; }
        public string Type { get; set; }
    }
}