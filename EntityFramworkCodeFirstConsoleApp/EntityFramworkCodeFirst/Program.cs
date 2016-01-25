using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramworkCodeFirst
{
    class PlayList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Video> Videos { get; set; }
    }

    class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    //DBContext is a class that is responsible for interacting with the data as an object. Meaning you can insert or get data using DBContext.
    class MeContext : DbContext
    {
        //DbSet is a reference from DbContext but helps to set the entity to perform actions like add, edit delete etc. 
        public DbSet<Video> Videos { get; set; }
        public DbSet<PlayList> PlyList { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MeContext db = new MeContext();
            db.Database.Delete();
            Video meVideo = new Video
            {
                Title = "Hello World Entitiy Framework",
                Description = "Learn the framework"
            };
            db.Videos.Add(meVideo);

            //PlayList mePlaylist = new PlayList();
            //mePlaylist.Title = "Entity Framework";
            //mePlaylist.Videos = new List<Video> { meVideo };


            ////pulling out the data from the first line in the database.
            //Video meVideo = meContext.Videos.Single();
            //Console.WriteLine("ID {0}, Title {1}, Description{2} ", meVideo.Id, meVideo.Title, meVideo.Description);
        }
    }
}
