using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class MusicStoreDbInitializer : System.Data.Entity.DropCreateDatabaseAlways<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {
            context.Artists.Add(new Artist { Name = "Al Di Meola" });
            context.Artists.Add(new Artist { Name = "Sarah Brightman" });
            context.Artists.Add(new Artist { Name = "Rush" });
            context.Artists.Add(new Artist { Name = "Aqua" });
            context.Artists.Add(new Artist { Name = "Metallica" });

            context.Genres.Add(new Genre { Name = "Jazz" });
            context.Genres.Add(new Genre { Name = "Pop" });
            context.Genres.Add(new Genre { Name = "Classical" });
            context.Genres.Add(new Genre { Name = "Rock" });
            context.Genres.Add(new Genre { Name = "Metal" });

            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Rush" },
                Genre = new Genre { Name = "Rock" },
                Price = 9.99m,
                Title = "Caravan",
                AlbumArtUrl = "~/Images/placeholder.png"
            });
                       
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Rush" },
                Genre = new Genre { Name = "Pop" },
                Price = 8.99m,
                Title = "Men At Work",
                AlbumArtUrl = "~/Images/placeholder.png"
            });
                    
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Sarah Brightman" },
                Genre = new Genre { Name = "Classical" },
                Price = 9.99m,
                Title = "A Winter Symphony",
                AlbumArtUrl = "~/Images/placeholder.png"
            });         
            
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Aqua" },
                Genre = new Genre { Name = "Pop" },
                Price = 9.99m,
                Title = "Barbie Girl",
                AlbumArtUrl = "~/Images/placeholder.png"
            });

            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Metallica" },
                Genre = new Genre { Name = "Metal" },
                Price = 9.99m,
                Title = "Justice For All",
                AlbumArtUrl = "~/Images/placeholder.png"
            });

            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Sarah Brightman" },
                Genre = new Genre { Name = "Classical" },
                Price = 9.99m,
                Title = "All I Ask of You",
                AlbumArtUrl = "~/Images/placeholder.png"
            });

            base.Seed(context);
        }
    }
}