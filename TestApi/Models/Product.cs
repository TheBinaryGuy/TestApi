﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
    }
}
