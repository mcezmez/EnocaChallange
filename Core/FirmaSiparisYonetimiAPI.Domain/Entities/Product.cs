﻿using FirmaSiparisYonetimiAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmaSiparisYonetimiAPI.Domain.Entities
{
    public class Product : BaseEntity
    {

        
        
        public Company Company { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }

        


    }
}
