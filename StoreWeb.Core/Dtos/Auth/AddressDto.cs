﻿using StoreWeb.Core.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreWeb.Core.Dtos.Auth
{
    public class AddressDto
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }


    }
}
