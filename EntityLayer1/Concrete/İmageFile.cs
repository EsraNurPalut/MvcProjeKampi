using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer1.Concrete
{
    public class İmageFile
    {
        [Key]
        public int ImageFileID { get; set; }

        [StringLength(100)]
        public string ImageName { get; set; }

        [StringLength(250)]
        public string ImagePath { get; set; }

    }
}
