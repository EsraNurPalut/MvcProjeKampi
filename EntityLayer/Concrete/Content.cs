using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Content
    {
        public int ContentID { get; set; }
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        public int HeadingID { get; set; }
        public   Heading Heading { get; set; }

        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }




    }
}
