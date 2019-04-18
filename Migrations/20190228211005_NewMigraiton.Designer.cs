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
    [Migration("20190228211005_NewMigraiton")]
    partial class NewMigraiton
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Infinterest.Models.Broker", b =>
                {
                    b.Property<int>("BrokerId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("BrokerId");

                    b.ToTable("brokers");
                });

            modelBuilder.Entity("Infinterest.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BrokerId");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EventVendorsId");

                    b.Property<int>("ListingId");

                    b.Property<DateTime>("OpenHouseDate");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("VendorUserId");

                    b.Property<int?>("VendorUserId1");

                    b.HasKey("EventId");

                    b.HasIndex("BrokerId");

                    b.HasIndex("EventVendorsId");

                    b.HasIndex("ListingId");

                    b.HasIndex("VendorUserId");

                    b.HasIndex("VendorUserId1");

                    b.ToTable("events");
                });

            modelBuilder.Entity("Infinterest.Models.EventVendors", b =>
                {
                    b.Property<int>("EventVendorsId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("EventVendorsId");

                    b.ToTable("EventVendors");
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

                    b.Property<string>("MLSNumber");

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

            modelBuilder.Entity("Infinterest.Models.Vendor", b =>
                {
                    b.HasBaseType("Infinterest.Models.User");

                    b.Property<string>("AreaOfHouse");

                    b.Property<string>("BusinessCategory");

                    b.Property<int?>("EventVendorsId");

                    b.Property<int?>("EventVendorsId1");

                    b.Property<int>("VendorId");

                    b.HasIndex("EventVendorsId");

                    b.HasIndex("EventVendorsId1");

                    b.ToTable("Vendor");

                    b.HasDiscriminator().HasValue("Vendor");
                });

            modelBuilder.Entity("Infinterest.Models.Event", b =>
                {
                    b.HasOne("Infinterest.Models.Broker")
                        .WithMany("Events")
                        .HasForeignKey("BrokerId");

                    b.HasOne("Infinterest.Models.EventVendors", "EventVendors")
                        .WithMany()
                        .HasForeignKey("EventVendorsId");

                    b.HasOne("Infinterest.Models.Listing", "Listing")
                        .WithMany("Events")
                        .HasForeignKey("ListingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Infinterest.Models.Vendor")
                        .WithMany("ConfimedEvents")
                        .HasForeignKey("VendorUserId");

                    b.HasOne("Infinterest.Models.Vendor")
                        .WithMany("PendingEvents")
                        .HasForeignKey("VendorUserId1");
                });

            modelBuilder.Entity("Infinterest.Models.Listing", b =>
                {
                    b.HasOne("Infinterest.Models.Broker", "Broker")
                        .WithMany("Listings")
                        .HasForeignKey("BrokerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infinterest.Models.Vendor", b =>
                {
                    b.HasOne("Infinterest.Models.EventVendors")
                        .WithMany("ConfirmedVendors")
                        .HasForeignKey("EventVendorsId");

                    b.HasOne("Infinterest.Models.EventVendors")
                        .WithMany("PendingVendors")
                        .HasForeignKey("EventVendorsId1");
                });
#pragma warning restore 612, 618
        }
    }
}
