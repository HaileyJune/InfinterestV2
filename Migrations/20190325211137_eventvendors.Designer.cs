﻿// <auto-generated />
using System;
using Infinterest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infinterest.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20190325211137_eventvendors")]
    partial class eventvendors
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Infinterest.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BrokerUserId");

                    b.Property<bool>("Confimed");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ListingId");

                    b.Property<DateTime>("OpenHouseDate");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("VendorUserId");

                    b.HasKey("EventId");

                    b.HasIndex("BrokerUserId");

                    b.HasIndex("ListingId");

                    b.HasIndex("VendorUserId");

                    b.ToTable("events");
                });

            modelBuilder.Entity("Infinterest.Models.Listing", b =>
                {
                    b.Property<int>("ListingId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AreaOfHouseToFeature");

                    b.Property<int>("BrokerId");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImgUrl");

                    b.Property<string>("MLSLink");

                    b.Property<int>("Price");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Zip");

                    b.HasKey("ListingId");

                    b.HasIndex("BrokerId");

                    b.ToTable("listings");
                });

            modelBuilder.Entity("Infinterest.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AffiliateCode");

                    b.Property<string>("Bio");

                    b.Property<string>("Company");

                    b.Property<string>("Contact");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomID");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("UserType");

                    b.Property<string>("Website");

                    b.HasKey("UserId");

                    b.ToTable("users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("Infinterest.Models.Broker", b =>
                {
                    b.HasBaseType("Infinterest.Models.User");


                    b.ToTable("Broker");

                    b.HasDiscriminator().HasValue("Broker");
                });

            modelBuilder.Entity("Infinterest.Models.Vendor", b =>
                {
                    b.HasBaseType("Infinterest.Models.User");

                    b.Property<string>("AreaOfHouse");

                    b.Property<string>("BusinessCategory");

                    b.ToTable("Vendor");

                    b.HasDiscriminator().HasValue("Vendor");
                });

            modelBuilder.Entity("Infinterest.Models.Event", b =>
                {
                    b.HasOne("Infinterest.Models.Broker")
                        .WithMany("Events")
                        .HasForeignKey("BrokerUserId");

                    b.HasOne("Infinterest.Models.Listing", "Listing")
                        .WithMany("Events")
                        .HasForeignKey("ListingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infinterest.Models.Vendor")
                        .WithMany("Events")
                        .HasForeignKey("VendorUserId");
                });

            modelBuilder.Entity("Infinterest.Models.Listing", b =>
                {
                    b.HasOne("Infinterest.Models.Broker", "Broker")
                        .WithMany("Listings")
                        .HasForeignKey("BrokerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
