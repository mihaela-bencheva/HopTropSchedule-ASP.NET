using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.DataConnection.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DanceCloths",
                columns: new[] { "ID", "ClothType", "ShoesType" },
                values: new object[,]
                {
                    { "340d13fa-1e61-44db-b445-2d8eacb7633d", "Женска носия", "Скарпини" },
                    { "8940c0ca-367b-4ee1-8be5-56cd83ebb213", "Мъжка носия", "Скарпини" },
                    { "d2ffc119-8b3b-41c5-a15e-a1d7d6c65a9e", "Женска носия", "Цървули" },
                    { "9401ec3f-1b6b-41db-95d3-2fae3bed2990", "Мъжка носия", "Цървули" }
                });

            migrationBuilder.InsertData(
                table: "DanceGroups",
                columns: new[] { "ID", "DanceGroupName" },
                values: new object[,]
                {
                    { "e0de92fa-845e-4bf9-bb7e-46172df21f75", "Начинаещи" },
                    { "05de77c1-985f-47cc-bc12-879e0e3614e5", "Напреднали" },
                    { "c4225970-65b0-4003-842b-d231e8ad63df", "Майстори" }
                });

            migrationBuilder.InsertData(
                table: "DanceSongs",
                columns: new[] { "ID", "SongName", "SongUrl" },
                values: new object[,]
                {
                    { "7154734b-f603-4a40-a87d-527538c382d2", "Pesen10", "123" },
                    { "0dbb7320-ea95-4631-a94b-f373cd580fc7", "Pesen9", "123" },
                    { "e57e5215-6f0e-44d3-b64c-36b037a10304", "Pesen8", "123" },
                    { "3cf6a68c-331b-452c-86b3-2a83d717daf4", "Pesen6", "123" },
                    { "852003e2-2e15-44f5-b4ad-787bc4afe6a5", "Pesen7", "123" },
                    { "c66deb2c-3326-48a8-a54e-538acf3c14f3", "Pesen4", "123" },
                    { "c87dfb96-3cf0-4823-b497-206825fb8dd3", "Pesen3", "123" },
                    { "059620e7-71f7-41e9-9f07-14e3d7dfd0ce", "Pesen2", "123" },
                    { "4d1934ad-6a55-47c8-951f-b7942dbd73bb", "Pesen1", "123" },
                    { "abfbe360-76aa-4c16-8b13-a8dc8ccbc8cd", "Pesen5", "123" }
                });

            migrationBuilder.InsertData(
                table: "FolkDances",
                columns: new[] { "ID", "DanceClothId", "FolkDanceName", "FolkDanceRegion", "FolkDanceSize" },
                values: new object[,]
                {
                    { "28448c8c-f975-4183-9491-f7a1e37b1504", null, "Sborenka", null, "2/4" },
                    { "109dc466-fbc6-474a-b60c-e3b6498bc607", null, "Svornato", null, "2/4" },
                    { "3cfeea53-0927-469d-a28d-f314b5f6cf3e", null, "Chichovo", null, "2/4" },
                    { "749a385c-3364-488a-8b59-e0aa3716d828", null, "Pravo", null, "2/4" },
                    { "9c4c90ff-1401-49e6-9af2-fbc3ad017efe", null, "Lyavata", null, "2/4" },
                    { "0df25e8c-f459-4636-8cb7-14924525558c", null, "Pandalaj", null, "2/4" },
                    { "b3101db7-be63-4606-8e67-48f24ad2884f", null, "Ginka", null, "2/4" },
                    { "6630af9d-d7b7-4d56-8fb5-9f86763dc8cb", null, "Dunavsko", null, "2/4" },
                    { "07de1e70-a334-404d-8012-100b3b94cac1", null, "Pravo Trakiisko", null, "2/4" },
                    { "5f0c9c1a-03f8-4618-8c94-39dcedf86c92", null, "Graovsko", null, "2/4" }
                });

            migrationBuilder.InsertData(
                table: "PracticeSchedules",
                columns: new[] { "ID", "DanceGroupId", "DayName", "PracticeTime" },
                values: new object[,]
                {
                    { "7f24645e-1792-4165-85fc-77c9625ec9f7", "e0de92fa-845e-4bf9-bb7e-46172df21f75", "Ponedelnik", "18:30" },
                    { "ccdd3130-c857-4dc9-aca8-cac4a5f10a23", "e0de92fa-845e-4bf9-bb7e-46172df21f75", "Vtornik", "17:30" },
                    { "fb946194-0996-4804-b877-8d37d322b4d4", "c4225970-65b0-4003-842b-d231e8ad63df", "Ponedelnik", "20:50" },
                    { "1722a156-f4e0-43f2-8427-3782b8f54129", "05de77c1-985f-47cc-bc12-879e0e3614e5", "Ponedelnik", "19:40" },
                    { "ab903747-6c24-460a-901b-a055e2abb2bd", "05de77c1-985f-47cc-bc12-879e0e3614e5", "Vtornik", "18:40" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "DanceGroupId", "Email", "FirstName", "LastName", "Password", "PhoneNumber" },
                values: new object[,]
                {
                    { "29df3ebd-6048-4bb7-997b-99cface6a1f2", "c4225970-65b0-4003-842b-d231e8ad63df", "dragana@abc.bg", "Ivana", "Sokolova", "123d+", "0124456949" },
                    { "b1ac4bf7-b3ba-4e95-9e86-592f1145f0d3", "c4225970-65b0-4003-842b-d231e8ad63df", "abc@abc.bg", "Dimitar", "Penkov", "123a+", "0123453789" },
                    { "7edffdcf-54d2-4f86-bfef-79d86006fea3", "c4225970-65b0-4003-842b-d231e8ad63df", "abc@abc.bg", "Desa", "Ivanova", "123a+", "0123456789" },
                    { "a23e99ca-39ff-4708-81f8-2d222f05530c", "05de77c1-985f-47cc-bc12-879e0e3614e5", "abc@abc.bg", "Ivanitsa", "Ivanova", "123a+", "01234556789" },
                    { "b458b8b0-01eb-439e-907b-dd95f5527910", "05de77c1-985f-47cc-bc12-879e0e3614e5", "goshka@abv.bg", "Petya", "Peteva", "123g+", "0123459789" },
                    { "b60b920b-fd6f-4432-90fd-0198cb3ec862", "05de77c1-985f-47cc-bc12-879e0e3614e5", "goshka@abv.bg", "Reni", "Renova", "123g+", "0123457789" },
                    { "6935c5ac-98e7-4beb-a5ae-97ee1c50f235", "05de77c1-985f-47cc-bc12-879e0e3614e5", "goshka@abv.bg", "Ginka", "Goshkova", "123g+", "0123457789" },
                    { "f61556ae-e77d-4cd7-8953-dadecb0dd4bf", "c4225970-65b0-4003-842b-d231e8ad63df", "goshka@abv.bg", "Viki", "Viktorova", "123g+", "0123432789" },
                    { "d5e1c59f-9247-4450-a062-a1df12d0b7ab", "e0de92fa-845e-4bf9-bb7e-46172df21f75", "dragana@abc.bg", "Andreya", "Draganova", "123d+", "0124456789" },
                    { "88021783-7318-444b-bb27-100aa867f95c", "e0de92fa-845e-4bf9-bb7e-46172df21f75", "abc@abc.bg", "Petko", "Ivanovic", "123a+", "0123456789" },
                    { "3ffb5349-0af7-483b-8ef2-c06ce56870da", "e0de92fa-845e-4bf9-bb7e-46172df21f75", "dragana@abc.bg", "Pepa", "Draginova", "123d+", "0124456789" },
                    { "f0744446-c997-4e9b-9121-ee0ccd9a9d08", "e0de92fa-845e-4bf9-bb7e-46172df21f75", "dragana@abc.bg", "Dragana", "Draganova", "123d+", "0124456789" },
                    { "94434732-94af-4c5c-b25a-d6028ad01a52", "e0de92fa-845e-4bf9-bb7e-46172df21f75", "abc@abc.bg", "Ivan", "Ivanov", "123a+", "0123456789" },
                    { "549d7849-5036-428e-917e-972f15eafb7f", "05de77c1-985f-47cc-bc12-879e0e3614e5", "goshka@abv.bg", "Gena", "Genova", "123g+", "0123457789" },
                    { "fb437f8d-aaa6-4312-a603-382cddccaba4", "c4225970-65b0-4003-842b-d231e8ad63df", "dragana@abc.bg", "Petkana", "Draganova", "123d+", "0124456789" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DanceCloths",
                keyColumn: "ID",
                keyValue: "340d13fa-1e61-44db-b445-2d8eacb7633d");

            migrationBuilder.DeleteData(
                table: "DanceCloths",
                keyColumn: "ID",
                keyValue: "8940c0ca-367b-4ee1-8be5-56cd83ebb213");

            migrationBuilder.DeleteData(
                table: "DanceCloths",
                keyColumn: "ID",
                keyValue: "9401ec3f-1b6b-41db-95d3-2fae3bed2990");

            migrationBuilder.DeleteData(
                table: "DanceCloths",
                keyColumn: "ID",
                keyValue: "d2ffc119-8b3b-41c5-a15e-a1d7d6c65a9e");

            migrationBuilder.DeleteData(
                table: "DanceSongs",
                keyColumn: "ID",
                keyValue: "059620e7-71f7-41e9-9f07-14e3d7dfd0ce");

            migrationBuilder.DeleteData(
                table: "DanceSongs",
                keyColumn: "ID",
                keyValue: "0dbb7320-ea95-4631-a94b-f373cd580fc7");

            migrationBuilder.DeleteData(
                table: "DanceSongs",
                keyColumn: "ID",
                keyValue: "3cf6a68c-331b-452c-86b3-2a83d717daf4");

            migrationBuilder.DeleteData(
                table: "DanceSongs",
                keyColumn: "ID",
                keyValue: "4d1934ad-6a55-47c8-951f-b7942dbd73bb");

            migrationBuilder.DeleteData(
                table: "DanceSongs",
                keyColumn: "ID",
                keyValue: "7154734b-f603-4a40-a87d-527538c382d2");

            migrationBuilder.DeleteData(
                table: "DanceSongs",
                keyColumn: "ID",
                keyValue: "852003e2-2e15-44f5-b4ad-787bc4afe6a5");

            migrationBuilder.DeleteData(
                table: "DanceSongs",
                keyColumn: "ID",
                keyValue: "abfbe360-76aa-4c16-8b13-a8dc8ccbc8cd");

            migrationBuilder.DeleteData(
                table: "DanceSongs",
                keyColumn: "ID",
                keyValue: "c66deb2c-3326-48a8-a54e-538acf3c14f3");

            migrationBuilder.DeleteData(
                table: "DanceSongs",
                keyColumn: "ID",
                keyValue: "c87dfb96-3cf0-4823-b497-206825fb8dd3");

            migrationBuilder.DeleteData(
                table: "DanceSongs",
                keyColumn: "ID",
                keyValue: "e57e5215-6f0e-44d3-b64c-36b037a10304");

            migrationBuilder.DeleteData(
                table: "FolkDances",
                keyColumn: "ID",
                keyValue: "07de1e70-a334-404d-8012-100b3b94cac1");

            migrationBuilder.DeleteData(
                table: "FolkDances",
                keyColumn: "ID",
                keyValue: "0df25e8c-f459-4636-8cb7-14924525558c");

            migrationBuilder.DeleteData(
                table: "FolkDances",
                keyColumn: "ID",
                keyValue: "109dc466-fbc6-474a-b60c-e3b6498bc607");

            migrationBuilder.DeleteData(
                table: "FolkDances",
                keyColumn: "ID",
                keyValue: "28448c8c-f975-4183-9491-f7a1e37b1504");

            migrationBuilder.DeleteData(
                table: "FolkDances",
                keyColumn: "ID",
                keyValue: "3cfeea53-0927-469d-a28d-f314b5f6cf3e");

            migrationBuilder.DeleteData(
                table: "FolkDances",
                keyColumn: "ID",
                keyValue: "5f0c9c1a-03f8-4618-8c94-39dcedf86c92");

            migrationBuilder.DeleteData(
                table: "FolkDances",
                keyColumn: "ID",
                keyValue: "6630af9d-d7b7-4d56-8fb5-9f86763dc8cb");

            migrationBuilder.DeleteData(
                table: "FolkDances",
                keyColumn: "ID",
                keyValue: "749a385c-3364-488a-8b59-e0aa3716d828");

            migrationBuilder.DeleteData(
                table: "FolkDances",
                keyColumn: "ID",
                keyValue: "9c4c90ff-1401-49e6-9af2-fbc3ad017efe");

            migrationBuilder.DeleteData(
                table: "FolkDances",
                keyColumn: "ID",
                keyValue: "b3101db7-be63-4606-8e67-48f24ad2884f");

            migrationBuilder.DeleteData(
                table: "PracticeSchedules",
                keyColumn: "ID",
                keyValue: "1722a156-f4e0-43f2-8427-3782b8f54129");

            migrationBuilder.DeleteData(
                table: "PracticeSchedules",
                keyColumn: "ID",
                keyValue: "7f24645e-1792-4165-85fc-77c9625ec9f7");

            migrationBuilder.DeleteData(
                table: "PracticeSchedules",
                keyColumn: "ID",
                keyValue: "ab903747-6c24-460a-901b-a055e2abb2bd");

            migrationBuilder.DeleteData(
                table: "PracticeSchedules",
                keyColumn: "ID",
                keyValue: "ccdd3130-c857-4dc9-aca8-cac4a5f10a23");

            migrationBuilder.DeleteData(
                table: "PracticeSchedules",
                keyColumn: "ID",
                keyValue: "fb946194-0996-4804-b877-8d37d322b4d4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: "29df3ebd-6048-4bb7-997b-99cface6a1f2");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: "3ffb5349-0af7-483b-8ef2-c06ce56870da");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: "549d7849-5036-428e-917e-972f15eafb7f");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: "6935c5ac-98e7-4beb-a5ae-97ee1c50f235");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: "7edffdcf-54d2-4f86-bfef-79d86006fea3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: "88021783-7318-444b-bb27-100aa867f95c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: "94434732-94af-4c5c-b25a-d6028ad01a52");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: "a23e99ca-39ff-4708-81f8-2d222f05530c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: "b1ac4bf7-b3ba-4e95-9e86-592f1145f0d3");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: "b458b8b0-01eb-439e-907b-dd95f5527910");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: "b60b920b-fd6f-4432-90fd-0198cb3ec862");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: "d5e1c59f-9247-4450-a062-a1df12d0b7ab");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: "f0744446-c997-4e9b-9121-ee0ccd9a9d08");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: "f61556ae-e77d-4cd7-8953-dadecb0dd4bf");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: "fb437f8d-aaa6-4312-a603-382cddccaba4");

            migrationBuilder.DeleteData(
                table: "DanceGroups",
                keyColumn: "ID",
                keyValue: "05de77c1-985f-47cc-bc12-879e0e3614e5");

            migrationBuilder.DeleteData(
                table: "DanceGroups",
                keyColumn: "ID",
                keyValue: "c4225970-65b0-4003-842b-d231e8ad63df");

            migrationBuilder.DeleteData(
                table: "DanceGroups",
                keyColumn: "ID",
                keyValue: "e0de92fa-845e-4bf9-bb7e-46172df21f75");
        }
    }
}
