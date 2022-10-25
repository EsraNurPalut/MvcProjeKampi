﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
   public  class Writer
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterSurName { get; set; }
        public string WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }

        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Content { get; set; }



    }
}
