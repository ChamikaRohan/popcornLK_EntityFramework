// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PopcornEntityFramework.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230301100939_sec")]
    partial class sec
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.Property<int>("BelongsToGenre_ID")
                        .HasColumnType("int");

                    b.Property<int>("BelongsToM_ID")
                        .HasColumnType("int");

                    b.HasKey("BelongsToGenre_ID", "BelongsToM_ID");

                    b.HasIndex("BelongsToM_ID");

                    b.ToTable("GenreMovie");
                });

            modelBuilder.Entity("popcornLK.Models.Customer", b =>
                {
                    b.Property<string>("NIC")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("C_Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("C_Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("C_age")
                        .HasColumnType("int");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("NIC");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("popcornLK.Models.Genre", b =>
                {
                    b.Property<int>("Genre_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Genre_Discriptionj")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Genre_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Movies_Count")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Genre_ID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("popcornLK.Models.Movie", b =>
                {
                    b.Property<int>("M_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("M_Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Ratings")
                        .HasColumnType("int");

                    b.Property<string>("RunTime")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("three_d_or_not")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("M_ID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("popcornLK.Models.Theater", b =>
                {
                    b.Property<int>("T_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Facilities")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("T_Address")
                        .HasColumnType("int");

                    b.Property<string>("T_Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("T_Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("T_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("T_Phone_No")
                        .HasColumnType("int");

                    b.Property<string>("T_Ratings")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("T_Reviews")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("T_ID");

                    b.ToTable("Theaters");
                });

            modelBuilder.Entity("popcornLK.Models.Ticket", b =>
                {
                    b.Property<int>("T_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CustomerNIC")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("M_ID")
                        .HasColumnType("int");

                    b.Property<int>("MovieM_ID")
                        .HasColumnType("int");

                    b.Property<string>("Seat_No")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TheaterID")
                        .HasColumnType("int");

                    b.Property<string>("Ticket_Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("T_ID");

                    b.HasIndex("CustomerNIC");

                    b.HasIndex("MovieM_ID");

                    b.HasIndex("TheaterID");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.HasOne("popcornLK.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("BelongsToGenre_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("popcornLK.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("BelongsToM_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("popcornLK.Models.Ticket", b =>
                {
                    b.HasOne("popcornLK.Models.Customer", "Customer")
                        .WithMany("Buys")
                        .HasForeignKey("CustomerNIC")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("popcornLK.Models.Movie", "Movie")
                        .WithMany("Has")
                        .HasForeignKey("MovieM_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("popcornLK.Models.Theater", "Theater")
                        .WithMany("Releases")
                        .HasForeignKey("TheaterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Movie");

                    b.Navigation("Theater");
                });

            modelBuilder.Entity("popcornLK.Models.Customer", b =>
                {
                    b.Navigation("Buys");
                });

            modelBuilder.Entity("popcornLK.Models.Movie", b =>
                {
                    b.Navigation("Has");
                });

            modelBuilder.Entity("popcornLK.Models.Theater", b =>
                {
                    b.Navigation("Releases");
                });
#pragma warning restore 612, 618
        }
    }
}
