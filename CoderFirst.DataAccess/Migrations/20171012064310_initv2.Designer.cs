﻿// <auto-generated />
using CoderFirst.Common.Enum;
using CoderFirst.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CoderFirst.DataAccess.Migrations
{
    [DbContext(typeof(BaseContext))]
    [Migration("20171012064310_initv2")]
    partial class initv2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("CoderFirst.DataAccess.Model.Advertisment", b =>
                {
                    b.Property<int>("AdvertismentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddsImageName");

                    b.Property<Guid>("AdvertismentGuid");

                    b.Property<string>("ClickUrl");

                    b.Property<DateTime>("ClosingOn");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("Description");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.Property<int>("TotalClick");

                    b.Property<string>("WebUrl");

                    b.HasKey("AdvertismentId");

                    b.ToTable("Advertisment");
                });
#pragma warning restore 612, 618
        }
    }
}