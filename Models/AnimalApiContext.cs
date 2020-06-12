  
using Microsoft.EntityFrameworkCore;

namespace AnimalApi.Models
{
 public class AnimalApiContext : DbContext
 {
   public AnimalApiContext(DbContextOptions<AnimalApiContext> options)
            : base(options)
        {
        }
         protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
      .HasData(
          new Animal { AnimalId = 1, Name = "Matilda", Species = "Dog", Age = 6, Gender = "Female", SpecialMedicalNeeds= true, PicUrl= "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/small-white-dog-breeds-havanese-1560302074.jpg"  },
          new Animal { AnimalId = 2, Name = "Vice", Species = "Macaw", Age = 15, Gender = "Male", SpecialMedicalNeeds=false, PicUrl= "https://images.squarespace-cdn.com/content/v1/5532205ce4b0edee9945e00a/1535399053497-8NKWAZSAGJHT3GFZWJ34/ke17ZwdGBToddI8pDm48kLkXF2pIyv_F2eUT9F60jBl7gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z4YTzHvnKhyp6Da-NYroOW3ZGjoBKy3azqku80C789l0iyqMbMesKd95J-X4EagrgU9L3Sa3U8cogeb0tjXbfawd0urKshkc5MgdBeJmALQKw/22+volando+MR4A2782.jpg?format=2500w"  },
          new Animal { AnimalId = 3, Name = "Cha", Species = "Beta fish", Age = 1, Gender = "Male", SpecialMedicalNeeds= false, PicUrl= "https://i.ytimg.com/vi/QRGl4AkaOzE/maxresdefault.jpg"  },
          new Animal { AnimalId = 4, Name = "Pip", Species = "Cat", Age = 4, Gender = "Female" , SpecialMedicalNeeds= true, PicUrl= "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/other/cat_relaxing_on_patio_other/1800x1200_cat_relaxing_on_patio_other.jpg"  },
          new Animal { AnimalId = 5, Name = "Bartholomew", Species = "Dinosaur", Age = 22, Gender = "Male"  , SpecialMedicalNeeds= false, PicUrl= "https://i.redd.it/uahsv0e85o801.jpg"  },
          new Animal { AnimalId = 6, Name = "Tina", Species = "Dog", Age = 1, Gender = "Female"  , SpecialMedicalNeeds= false, PicUrl= "hhttps://townsquare.media/site/393/files/2019/05/teddy.jpg?w=980&q=75"  }
      );
        }
    public DbSet<Animal> Animals { get; set; }
 }
}

    