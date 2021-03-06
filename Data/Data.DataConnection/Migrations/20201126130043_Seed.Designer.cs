﻿// <auto-generated />
using Data.DataConnection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.DataConnection.Migrations
{
    [DbContext(typeof(ScheduleDbContext))]
    [Migration("20201126130043_Seed")]
    partial class Seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.Models.Models.DanceCloth", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ClothType")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("ShoesType")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("ID");

                    b.ToTable("DanceCloths");

                    b.HasData(
                        new
                        {
                            ID = "340d13fa-1e61-44db-b445-2d8eacb7633d",
                            ClothType = "Женска носия",
                            ShoesType = "Скарпини"
                        },
                        new
                        {
                            ID = "8940c0ca-367b-4ee1-8be5-56cd83ebb213",
                            ClothType = "Мъжка носия",
                            ShoesType = "Скарпини"
                        },
                        new
                        {
                            ID = "d2ffc119-8b3b-41c5-a15e-a1d7d6c65a9e",
                            ClothType = "Женска носия",
                            ShoesType = "Цървули"
                        },
                        new
                        {
                            ID = "9401ec3f-1b6b-41db-95d3-2fae3bed2990",
                            ClothType = "Мъжка носия",
                            ShoesType = "Цървули"
                        });
                });

            modelBuilder.Entity("Data.Models.Models.DanceGroup", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DanceGroupName")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.ToTable("DanceGroups");

                    b.HasData(
                        new
                        {
                            ID = "e0de92fa-845e-4bf9-bb7e-46172df21f75",
                            DanceGroupName = "Начинаещи"
                        },
                        new
                        {
                            ID = "05de77c1-985f-47cc-bc12-879e0e3614e5",
                            DanceGroupName = "Напреднали"
                        },
                        new
                        {
                            ID = "c4225970-65b0-4003-842b-d231e8ad63df",
                            DanceGroupName = "Майстори"
                        });
                });

            modelBuilder.Entity("Data.Models.Models.DanceGroupFolkDance", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DanceGroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FolkDanceId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("DanceGroupId");

                    b.HasIndex("FolkDanceId");

                    b.ToTable("DanceGroupFolkDances");
                });

            modelBuilder.Entity("Data.Models.Models.DanceSong", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SongName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("SongUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("DanceSongs");

                    b.HasData(
                        new
                        {
                            ID = "4d1934ad-6a55-47c8-951f-b7942dbd73bb",
                            SongName = "Pesen1",
                            SongUrl = "123"
                        },
                        new
                        {
                            ID = "059620e7-71f7-41e9-9f07-14e3d7dfd0ce",
                            SongName = "Pesen2",
                            SongUrl = "123"
                        },
                        new
                        {
                            ID = "c87dfb96-3cf0-4823-b497-206825fb8dd3",
                            SongName = "Pesen3",
                            SongUrl = "123"
                        },
                        new
                        {
                            ID = "c66deb2c-3326-48a8-a54e-538acf3c14f3",
                            SongName = "Pesen4",
                            SongUrl = "123"
                        },
                        new
                        {
                            ID = "abfbe360-76aa-4c16-8b13-a8dc8ccbc8cd",
                            SongName = "Pesen5",
                            SongUrl = "123"
                        },
                        new
                        {
                            ID = "3cf6a68c-331b-452c-86b3-2a83d717daf4",
                            SongName = "Pesen6",
                            SongUrl = "123"
                        },
                        new
                        {
                            ID = "852003e2-2e15-44f5-b4ad-787bc4afe6a5",
                            SongName = "Pesen7",
                            SongUrl = "123"
                        },
                        new
                        {
                            ID = "e57e5215-6f0e-44d3-b64c-36b037a10304",
                            SongName = "Pesen8",
                            SongUrl = "123"
                        },
                        new
                        {
                            ID = "0dbb7320-ea95-4631-a94b-f373cd580fc7",
                            SongName = "Pesen9",
                            SongUrl = "123"
                        },
                        new
                        {
                            ID = "7154734b-f603-4a40-a87d-527538c382d2",
                            SongName = "Pesen10",
                            SongUrl = "123"
                        });
                });

            modelBuilder.Entity("Data.Models.Models.FolkDance", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DanceClothId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FolkDanceName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("FolkDanceRegion")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("FolkDanceSize")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("ID");

                    b.HasIndex("DanceClothId")
                        .IsUnique()
                        .HasFilter("[DanceClothId] IS NOT NULL");

                    b.ToTable("FolkDances");

                    b.HasData(
                        new
                        {
                            ID = "109dc466-fbc6-474a-b60c-e3b6498bc607",
                            FolkDanceName = "Svornato",
                            FolkDanceSize = "2/4"
                        },
                        new
                        {
                            ID = "3cfeea53-0927-469d-a28d-f314b5f6cf3e",
                            FolkDanceName = "Chichovo",
                            FolkDanceSize = "2/4"
                        },
                        new
                        {
                            ID = "749a385c-3364-488a-8b59-e0aa3716d828",
                            FolkDanceName = "Pravo",
                            FolkDanceSize = "2/4"
                        },
                        new
                        {
                            ID = "9c4c90ff-1401-49e6-9af2-fbc3ad017efe",
                            FolkDanceName = "Lyavata",
                            FolkDanceSize = "2/4"
                        },
                        new
                        {
                            ID = "0df25e8c-f459-4636-8cb7-14924525558c",
                            FolkDanceName = "Pandalaj",
                            FolkDanceSize = "2/4"
                        },
                        new
                        {
                            ID = "b3101db7-be63-4606-8e67-48f24ad2884f",
                            FolkDanceName = "Ginka",
                            FolkDanceSize = "2/4"
                        },
                        new
                        {
                            ID = "6630af9d-d7b7-4d56-8fb5-9f86763dc8cb",
                            FolkDanceName = "Dunavsko",
                            FolkDanceSize = "2/4"
                        },
                        new
                        {
                            ID = "07de1e70-a334-404d-8012-100b3b94cac1",
                            FolkDanceName = "Pravo Trakiisko",
                            FolkDanceSize = "2/4"
                        },
                        new
                        {
                            ID = "28448c8c-f975-4183-9491-f7a1e37b1504",
                            FolkDanceName = "Sborenka",
                            FolkDanceSize = "2/4"
                        },
                        new
                        {
                            ID = "5f0c9c1a-03f8-4618-8c94-39dcedf86c92",
                            FolkDanceName = "Graovsko",
                            FolkDanceSize = "2/4"
                        });
                });

            modelBuilder.Entity("Data.Models.Models.FolkDanceSong", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DanceSongId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FolkDanceId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("DanceSongId");

                    b.HasIndex("FolkDanceId");

                    b.ToTable("FolkDanceSong");
                });

            modelBuilder.Entity("Data.Models.Models.Image", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DanceGroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DanceGroupId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Data.Models.Models.PracticeSchedule", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DanceGroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DayName")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("PracticeTime")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("ID");

                    b.HasIndex("DanceGroupId");

                    b.ToTable("PracticeSchedules");

                    b.HasData(
                        new
                        {
                            ID = "7f24645e-1792-4165-85fc-77c9625ec9f7",
                            DanceGroupId = "e0de92fa-845e-4bf9-bb7e-46172df21f75",
                            DayName = "Ponedelnik",
                            PracticeTime = "18:30"
                        },
                        new
                        {
                            ID = "1722a156-f4e0-43f2-8427-3782b8f54129",
                            DanceGroupId = "05de77c1-985f-47cc-bc12-879e0e3614e5",
                            DayName = "Ponedelnik",
                            PracticeTime = "19:40"
                        },
                        new
                        {
                            ID = "fb946194-0996-4804-b877-8d37d322b4d4",
                            DanceGroupId = "c4225970-65b0-4003-842b-d231e8ad63df",
                            DayName = "Ponedelnik",
                            PracticeTime = "20:50"
                        },
                        new
                        {
                            ID = "ccdd3130-c857-4dc9-aca8-cac4a5f10a23",
                            DanceGroupId = "e0de92fa-845e-4bf9-bb7e-46172df21f75",
                            DayName = "Vtornik",
                            PracticeTime = "17:30"
                        },
                        new
                        {
                            ID = "ab903747-6c24-460a-901b-a055e2abb2bd",
                            DanceGroupId = "05de77c1-985f-47cc-bc12-879e0e3614e5",
                            DayName = "Vtornik",
                            PracticeTime = "18:40"
                        });
                });

            modelBuilder.Entity("Data.Models.Models.User", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DanceGroupId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("ID");

                    b.HasIndex("DanceGroupId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = "94434732-94af-4c5c-b25a-d6028ad01a52",
                            DanceGroupId = "e0de92fa-845e-4bf9-bb7e-46172df21f75",
                            Email = "abc@abc.bg",
                            FirstName = "Ivan",
                            LastName = "Ivanov",
                            Password = "123a+",
                            PhoneNumber = "0123456789"
                        },
                        new
                        {
                            ID = "6935c5ac-98e7-4beb-a5ae-97ee1c50f235",
                            DanceGroupId = "05de77c1-985f-47cc-bc12-879e0e3614e5",
                            Email = "goshka@abv.bg",
                            FirstName = "Ginka",
                            LastName = "Goshkova",
                            Password = "123g+",
                            PhoneNumber = "0123457789"
                        },
                        new
                        {
                            ID = "f0744446-c997-4e9b-9121-ee0ccd9a9d08",
                            DanceGroupId = "e0de92fa-845e-4bf9-bb7e-46172df21f75",
                            Email = "dragana@abc.bg",
                            FirstName = "Dragana",
                            LastName = "Draganova",
                            Password = "123d+",
                            PhoneNumber = "0124456789"
                        },
                        new
                        {
                            ID = "7edffdcf-54d2-4f86-bfef-79d86006fea3",
                            DanceGroupId = "c4225970-65b0-4003-842b-d231e8ad63df",
                            Email = "abc@abc.bg",
                            FirstName = "Desa",
                            LastName = "Ivanova",
                            Password = "123a+",
                            PhoneNumber = "0123456789"
                        },
                        new
                        {
                            ID = "549d7849-5036-428e-917e-972f15eafb7f",
                            DanceGroupId = "05de77c1-985f-47cc-bc12-879e0e3614e5",
                            Email = "goshka@abv.bg",
                            FirstName = "Gena",
                            LastName = "Genova",
                            Password = "123g+",
                            PhoneNumber = "0123457789"
                        },
                        new
                        {
                            ID = "3ffb5349-0af7-483b-8ef2-c06ce56870da",
                            DanceGroupId = "e0de92fa-845e-4bf9-bb7e-46172df21f75",
                            Email = "dragana@abc.bg",
                            FirstName = "Pepa",
                            LastName = "Draginova",
                            Password = "123d+",
                            PhoneNumber = "0124456789"
                        },
                        new
                        {
                            ID = "88021783-7318-444b-bb27-100aa867f95c",
                            DanceGroupId = "e0de92fa-845e-4bf9-bb7e-46172df21f75",
                            Email = "abc@abc.bg",
                            FirstName = "Petko",
                            LastName = "Ivanovic",
                            Password = "123a+",
                            PhoneNumber = "0123456789"
                        },
                        new
                        {
                            ID = "b60b920b-fd6f-4432-90fd-0198cb3ec862",
                            DanceGroupId = "05de77c1-985f-47cc-bc12-879e0e3614e5",
                            Email = "goshka@abv.bg",
                            FirstName = "Reni",
                            LastName = "Renova",
                            Password = "123g+",
                            PhoneNumber = "0123457789"
                        },
                        new
                        {
                            ID = "d5e1c59f-9247-4450-a062-a1df12d0b7ab",
                            DanceGroupId = "e0de92fa-845e-4bf9-bb7e-46172df21f75",
                            Email = "dragana@abc.bg",
                            FirstName = "Andreya",
                            LastName = "Draganova",
                            Password = "123d+",
                            PhoneNumber = "0124456789"
                        },
                        new
                        {
                            ID = "b1ac4bf7-b3ba-4e95-9e86-592f1145f0d3",
                            DanceGroupId = "c4225970-65b0-4003-842b-d231e8ad63df",
                            Email = "abc@abc.bg",
                            FirstName = "Dimitar",
                            LastName = "Penkov",
                            Password = "123a+",
                            PhoneNumber = "0123453789"
                        },
                        new
                        {
                            ID = "b458b8b0-01eb-439e-907b-dd95f5527910",
                            DanceGroupId = "05de77c1-985f-47cc-bc12-879e0e3614e5",
                            Email = "goshka@abv.bg",
                            FirstName = "Petya",
                            LastName = "Peteva",
                            Password = "123g+",
                            PhoneNumber = "0123459789"
                        },
                        new
                        {
                            ID = "29df3ebd-6048-4bb7-997b-99cface6a1f2",
                            DanceGroupId = "c4225970-65b0-4003-842b-d231e8ad63df",
                            Email = "dragana@abc.bg",
                            FirstName = "Ivana",
                            LastName = "Sokolova",
                            Password = "123d+",
                            PhoneNumber = "0124456949"
                        },
                        new
                        {
                            ID = "a23e99ca-39ff-4708-81f8-2d222f05530c",
                            DanceGroupId = "05de77c1-985f-47cc-bc12-879e0e3614e5",
                            Email = "abc@abc.bg",
                            FirstName = "Ivanitsa",
                            LastName = "Ivanova",
                            Password = "123a+",
                            PhoneNumber = "01234556789"
                        },
                        new
                        {
                            ID = "f61556ae-e77d-4cd7-8953-dadecb0dd4bf",
                            DanceGroupId = "c4225970-65b0-4003-842b-d231e8ad63df",
                            Email = "goshka@abv.bg",
                            FirstName = "Viki",
                            LastName = "Viktorova",
                            Password = "123g+",
                            PhoneNumber = "0123432789"
                        },
                        new
                        {
                            ID = "fb437f8d-aaa6-4312-a603-382cddccaba4",
                            DanceGroupId = "c4225970-65b0-4003-842b-d231e8ad63df",
                            Email = "dragana@abc.bg",
                            FirstName = "Petkana",
                            LastName = "Draganova",
                            Password = "123d+",
                            PhoneNumber = "0124456789"
                        });
                });

            modelBuilder.Entity("Data.Models.Models.DanceGroupFolkDance", b =>
                {
                    b.HasOne("Data.Models.Models.DanceGroup", "DanceGroup")
                        .WithMany("DanceGroupFolkDances")
                        .HasForeignKey("DanceGroupId");

                    b.HasOne("Data.Models.Models.FolkDance", "FolkDance")
                        .WithMany("DanceGroupFolkDances")
                        .HasForeignKey("FolkDanceId");
                });

            modelBuilder.Entity("Data.Models.Models.FolkDance", b =>
                {
                    b.HasOne("Data.Models.Models.DanceCloth", "DanceCloth")
                        .WithOne("FolkDance")
                        .HasForeignKey("Data.Models.Models.FolkDance", "DanceClothId");
                });

            modelBuilder.Entity("Data.Models.Models.FolkDanceSong", b =>
                {
                    b.HasOne("Data.Models.Models.DanceSong", "DanceSong")
                        .WithMany("FolkDanceSongs")
                        .HasForeignKey("DanceSongId");

                    b.HasOne("Data.Models.Models.FolkDance", "FolkDance")
                        .WithMany("FolkDanceSongs")
                        .HasForeignKey("FolkDanceId");
                });

            modelBuilder.Entity("Data.Models.Models.Image", b =>
                {
                    b.HasOne("Data.Models.Models.DanceGroup", "DanceGroup")
                        .WithMany("Images")
                        .HasForeignKey("DanceGroupId");
                });

            modelBuilder.Entity("Data.Models.Models.PracticeSchedule", b =>
                {
                    b.HasOne("Data.Models.Models.DanceGroup", "DanceGroup")
                        .WithMany("PracticeSchedules")
                        .HasForeignKey("DanceGroupId");
                });

            modelBuilder.Entity("Data.Models.Models.User", b =>
                {
                    b.HasOne("Data.Models.Models.DanceGroup", "DanceGroup")
                        .WithMany("Users")
                        .HasForeignKey("DanceGroupId");
                });
#pragma warning restore 612, 618
        }
    }
}
