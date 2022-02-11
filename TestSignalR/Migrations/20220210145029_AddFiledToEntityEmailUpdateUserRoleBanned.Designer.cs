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
    [Migration("20220210145029_AddFiledToEntityEmailUpdateUserRoleBanned")]
    partial class AddFiledToEntityEmailUpdateUserRoleBanned
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TradingPlatformBlazor.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("NameCategory")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nameCategory");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TradingPlatformBlazor.Data.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BodyComment")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("body_comment");

                    b.Property<DateTime>("DateComment")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_comment");

                    b.Property<int>("FromUserId")
                        .HasColumnType("int")
                        .HasColumnName("from_user_id");

                    b.Property<int>("OfferId")
                        .HasColumnType("int")
                        .HasColumnName("offer_id");

                    b.Property<int>("ToUserId")
                        .HasColumnType("int")
                        .HasColumnName("to_user_id");

                    b.Property<byte>("ValueRating")
                        .HasColumnType("tinyint")
                        .HasColumnName("value_rating");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("TradingPlatformBlazor.Data.Models.Lot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<string>("DescLot")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("descLot");

                    b.Property<string>("NameLot")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nameLot");

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasColumnName("price");

                    b.Property<int>("VendorId")
                        .HasColumnType("int")
                        .HasColumnName("vendor_id");

                    b.Property<string>("VendorsNick")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("vendorNick");

                    b.HasKey("Id");

                    b.ToTable("Lots");
                });

            modelBuilder.Entity("TradingPlatformBlazor.Data.Models.Message", b =>
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

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("TradingPlatformBlazor.Data.Models.MessageShop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BodyMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateMessage")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_message");

                    b.Property<bool>("IsShopMessage")
                        .HasColumnType("bit")
                        .HasColumnName("is_shop_message");

                    b.Property<int>("ShopId")
                        .HasColumnType("int")
                        .HasColumnName("shop_id");

                    b.Property<int>("ShopMemberId")
                        .HasColumnType("int")
                        .HasColumnName("shop_member_id");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.ToTable("MessageShops");
                });

            modelBuilder.Entity("TradingPlatformBlazor.Data.Models.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    b.Property<DateTime>("DateClosing")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_closing");

                    b.Property<DateTime>("DateOpenning")
                        .HasColumnType("datetime2")
                        .HasColumnName("date_openning");

                    b.Property<string>("IdentifierName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("identifier_name");

                    b.Property<bool>("IsCommented")
                        .HasColumnType("bit")
                        .HasColumnName("is_commented");

                    b.Property<bool>("IsManyBack")
                        .HasColumnType("bit")
                        .HasColumnName("is_manyback");

                    b.Property<bool>("IsOpenned")
                        .HasColumnType("bit")
                        .HasColumnName("is_openned");

                    b.Property<int>("LotId")
                        .HasColumnType("int")
                        .HasColumnName("lot_id");

                    b.Property<string>("LotsDesc")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("lots_desc");

                    b.Property<string>("LotsName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("lots_name");

                    b.Property<double>("LotsPrice")
                        .HasColumnType("float")
                        .HasColumnName("lots_price");

                    b.Property<int>("ShopLotId")
                        .HasColumnType("int")
                        .HasColumnName("shop_lot_id");

                    b.Property<int>("StateOffer")
                        .HasColumnType("int")
                        .HasColumnName("state_offer");

                    b.Property<int>("VendorId")
                        .HasColumnType("int")
                        .HasColumnName("vendor_id");

                    b.Property<int>("VendorShopId")
                        .HasColumnType("int")
                        .HasColumnName("shop_vendor_id");

                    b.HasKey("Id");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("TradingPlatformBlazor.Data.Models.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedId")
                        .HasColumnType("int")
                        .HasColumnName("id_created");

                    b.Property<string>("DescShop")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("desc_shop");

                    b.Property<string>("NameShop")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name_shop");

                    b.Property<string>("PathAvatarShop")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("shop_avatar");

                    b.Property<string>("ShortNameShop")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("short_name_shop");

                    b.HasKey("Id");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("TradingPlatformBlazor.Data.Models.ShopLot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<string>("DescLot")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("descLot");

                    b.Property<string>("NameLot")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nameLot");

                    b.Property<double>("Price")
                        .HasColumnType("float")
                        .HasColumnName("price");

                    b.Property<int>("ShopId")
                        .HasColumnType("int")
                        .HasColumnName("shop_Id");

                    b.HasKey("Id");

                    b.ToTable("ShopLots");
                });

            modelBuilder.Entity("TradingPlatformBlazor.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Balance")
                        .HasColumnType("float")
                        .HasColumnName("balance");

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("datetime2")
                        .HasColumnName("dateRegistration");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<int>("IdShop")
                        .HasColumnType("int")
                        .HasColumnName("id_shop");

                    b.Property<int>("LevelUser")
                        .HasColumnType("int")
                        .HasColumnName("level_user");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("login");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nickname");

                    b.Property<string>("PassCrypt")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("passcrypt");

                    b.Property<string>("PathAvatar")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("avatar");

                    b.Property<int>("Role")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
