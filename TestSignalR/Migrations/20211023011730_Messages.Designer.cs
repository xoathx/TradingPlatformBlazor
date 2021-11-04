﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TradingPlatformBlazor.Data;

namespace TradingPlatformBlazor.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20211023011730_Messages")]
    partial class Messages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            

            

            modelBuilder.Entity("TestSignalR.Data.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BodyMessage")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("body_message");

                    b.Property<DateTime>("DateMessage")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_message");

                    b.Property<int>("FromUserId")
                        .HasColumnType("int")
                        .HasColumnName("from_user_id");

                    b.Property<int>("ToUserId")
                        .HasColumnType("int")
                        .HasColumnName("to_user_id");

                    b.HasKey("Id");

                    b.HasIndex("FromUserId");

                    b.HasIndex("ToUserId");

                    b.ToTable("Messages");
                });

            
            modelBuilder.Entity("TestSignalR.Data.Models.Message", b =>
                {
                    b.HasOne("TestSignalR.Data.Models.User", "FromUser")
                        .WithMany()
                        .HasForeignKey("FromUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestSignalR.Data.Models.User", "ToUser")
                        .WithMany()
                        .HasForeignKey("ToUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FromUser");

                    b.Navigation("ToUser");
                });
#pragma warning restore 612, 618
        }
    }
}
