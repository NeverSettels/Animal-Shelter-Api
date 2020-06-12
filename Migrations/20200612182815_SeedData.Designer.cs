﻿// <auto-generated />
using AnimalApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Animal_Api.Migrations
{
    [DbContext(typeof(AnimalApiContext))]
    [Migration("20200612182815_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalApi.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Gender");

                    b.Property<string>("Name");

                    b.Property<string>("PicUrl");

                    b.Property<bool>("SpecialMedicalNeeds");

                    b.Property<string>("Species");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 6,
                            Gender = "Female",
                            Name = "Matilda",
                            PicUrl = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/small-white-dog-breeds-havanese-1560302074.jpg",
                            SpecialMedicalNeeds = true,
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 15,
                            Gender = "Male",
                            Name = "Vice",
                            PicUrl = "https://images.squarespace-cdn.com/content/v1/5532205ce4b0edee9945e00a/1535399053497-8NKWAZSAGJHT3GFZWJ34/ke17ZwdGBToddI8pDm48kLkXF2pIyv_F2eUT9F60jBl7gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z4YTzHvnKhyp6Da-NYroOW3ZGjoBKy3azqku80C789l0iyqMbMesKd95J-X4EagrgU9L3Sa3U8cogeb0tjXbfawd0urKshkc5MgdBeJmALQKw/22+volando+MR4A2782.jpg?format=2500w",
                            SpecialMedicalNeeds = false,
                            Species = "Macaw"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 1,
                            Gender = "Male",
                            Name = "Cha",
                            PicUrl = "https://i.ytimg.com/vi/QRGl4AkaOzE/maxresdefault.jpg",
                            SpecialMedicalNeeds = false,
                            Species = "Beta fish"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 4,
                            Gender = "Female",
                            Name = "Pip",
                            PicUrl = "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/other/cat_relaxing_on_patio_other/1800x1200_cat_relaxing_on_patio_other.jpg",
                            SpecialMedicalNeeds = true,
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 22,
                            Gender = "Male",
                            Name = "Bartholomew",
                            PicUrl = "https://i.redd.it/uahsv0e85o801.jpg",
                            SpecialMedicalNeeds = false,
                            Species = "Dinosaur"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 1,
                            Gender = "Female",
                            Name = "Tina",
                            PicUrl = "hhttps://townsquare.media/site/393/files/2019/05/teddy.jpg?w=980&q=75",
                            SpecialMedicalNeeds = false,
                            Species = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}