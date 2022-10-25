using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        public int HeadingID { get; set; } // veri tabanına yansıyacak sütun başlıkları
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

    }
}
