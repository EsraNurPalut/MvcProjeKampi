﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
   public  class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

    }
}
