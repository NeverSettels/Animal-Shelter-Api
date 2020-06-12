using Microsoft.EntityFrameworkCore.Migrations;

namespace Animal_Api.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Animals",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Gender", "Name", "PicUrl", "SpecialMedicalNeeds", "Species" },
                values: new object[,]
                {
                    { 1, 6, "Female", "Matilda", "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/small-white-dog-breeds-havanese-1560302074.jpg", true, "Dog" },
                    { 2, 15, "Male", "Vice", "https://images.squarespace-cdn.com/content/v1/5532205ce4b0edee9945e00a/1535399053497-8NKWAZSAGJHT3GFZWJ34/ke17ZwdGBToddI8pDm48kLkXF2pIyv_F2eUT9F60jBl7gQa3H78H3Y0txjaiv_0fDoOvxcdMmMKkDsyUqMSsMWxHk725yiiHCCLfrh8O1z4YTzHvnKhyp6Da-NYroOW3ZGjoBKy3azqku80C789l0iyqMbMesKd95J-X4EagrgU9L3Sa3U8cogeb0tjXbfawd0urKshkc5MgdBeJmALQKw/22+volando+MR4A2782.jpg?format=2500w", false, "Macaw" },
                    { 3, 1, "Male", "Cha", "https://i.ytimg.com/vi/QRGl4AkaOzE/maxresdefault.jpg", false, "Beta fish" },
                    { 4, 4, "Female", "Pip", "https://img.webmd.com/dtmcms/live/webmd/consumer_assets/site_images/article_thumbnails/other/cat_relaxing_on_patio_other/1800x1200_cat_relaxing_on_patio_other.jpg", true, "Cat" },
                    { 5, 22, "Male", "Bartholomew", "https://i.redd.it/uahsv0e85o801.jpg", false, "Dinosaur" },
                    { 6, 1, "Female", "Tina", "hhttps://townsquare.media/site/393/files/2019/05/teddy.jpg?w=980&q=75", false, "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Age",
                table: "Animals",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
