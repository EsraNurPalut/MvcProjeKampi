using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using EntityLayer.Concrete;

namespace DataAccsessLayer.Concrete
{

    public class Context:DbContext
    {

        public Context()
            :base ("Context")
        {


        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }


    }
}
