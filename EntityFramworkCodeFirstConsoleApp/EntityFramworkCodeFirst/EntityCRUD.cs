using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFramworkCodeFirst
{
    class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    class MeContext : DbContext
    {

        public DbSet<Video> Videos { get; set; }
    }

    class EntityCRUD
    {
        public static void Main()
        {
            //CRUD Create , Read, Update, Delete
            MeContext meContext = new MeContext();
            //Video vid = new Video
            //{
            //    Title = "Entity Framework CRUD Operations",
            //    Description = "Learn the meaning of CRUD"
            //};

            //CREATE
           // meContext.Videos.Add(vid);
            //meContext.SaveChanges();

            ////READ
            Video vid = meContext.Videos.Single();
            ////updated record
            //vid.Title = "Begging CRUD1";
            //delete
            meContext.Videos.Remove(vid);
            //save the record changes
            meContext.SaveChanges();




        }
        
        
    }
}
