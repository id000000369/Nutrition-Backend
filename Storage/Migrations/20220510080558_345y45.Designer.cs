﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Storage;

namespace Storage.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20220510080558_345y45")]
    partial class _345y45
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Domain.ActivationCode", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActivate")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Number")
                        .HasColumnType("text");

                    b.Property<int>("PhoneNumberType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ActivationCodes");
                });

            modelBuilder.Entity("Domain.AdditionalOptions", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AdditionalOptions");
                });

            modelBuilder.Entity("Domain.AdditionalOptionsServant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long?>("AdditionalOptionsId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long?>("ServantId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AdditionalOptionsId");

                    b.HasIndex("ServantId");

                    b.ToTable("AdditionalOptionsServants");
                });

            modelBuilder.Entity("Domain.AfterBuyAdditionalServant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long?>("AdditionalOptionsId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long?>("ServantId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AdditionalOptionsId");

                    b.HasIndex("ServantId");

                    b.ToTable("AfterBuyAdditionalServants");
                });

            modelBuilder.Entity("Domain.BloodTestPhoto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("FromUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.Property<long>("QuestionnaireId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("FromUserId");

                    b.HasIndex("QuestionnaireId");

                    b.ToTable("BloodTestPhotos");
                });

            modelBuilder.Entity("Domain.CalendarOfEvent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("CalendarOfEvents");
                });

            modelBuilder.Entity("Domain.Comments", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<long>("FoodDiaryId")
                        .HasColumnType("bigint");

                    b.Property<long>("FromUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("FoodDiaryId");

                    b.HasIndex("FromUserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Domain.CommentsFile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("CommentsId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("File")
                        .HasColumnType("text");

                    b.Property<long>("FromUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("CommentsId");

                    b.HasIndex("FromUserId");

                    b.ToTable("CommentsFile");
                });

            modelBuilder.Entity("Domain.Consultations", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Consultations");
                });

            modelBuilder.Entity("Domain.Country", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Domain.FoodDiary", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Breakfast")
                        .HasColumnType("text");

                    b.Property<string>("Brunch")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Lunch")
                        .HasColumnType("text");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("FoodDiaries");
                });

            modelBuilder.Entity("Domain.GiftSertificate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("GiftSertificates");
                });

            modelBuilder.Entity("Domain.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("AgreementIsChecked")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<int>("SexType")
                        .HasColumnType("integer");

                    b.Property<string>("SurName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Domain.Questionnaire", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AboutMeInfo")
                        .HasColumnType("integer");

                    b.Property<int>("AlcoholDrink")
                        .HasColumnType("integer");

                    b.Property<string>("Allergies")
                        .HasColumnType("text");

                    b.Property<double>("BreastVolume")
                        .HasColumnType("double precision");

                    b.Property<string>("ChronicDiseases")
                        .HasColumnType("text");

                    b.Property<int>("CoffeeDependence")
                        .HasColumnType("integer");

                    b.Property<string>("ConsultationPurpose")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("CurrentWeight")
                        .HasColumnType("double precision");

                    b.Property<string>("DailyDiet")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double>("DesiredWeight")
                        .HasColumnType("double precision");

                    b.Property<string>("Diabetes")
                        .HasColumnType("text");

                    b.Property<string>("DietarySupplements")
                        .HasColumnType("text");

                    b.Property<int>("EndOfTheDayEnergy")
                        .HasColumnType("integer");

                    b.Property<long>("FromUserId")
                        .HasColumnType("bigint");

                    b.Property<double>("Heigh")
                        .HasColumnType("double precision");

                    b.Property<double>("Hips")
                        .HasColumnType("double precision");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("MealsPerDay")
                        .HasColumnType("text");

                    b.Property<double>("NeckVolume")
                        .HasColumnType("double precision");

                    b.Property<long?>("PersonId")
                        .HasColumnType("bigint");

                    b.Property<int>("Pressure")
                        .HasColumnType("integer");

                    b.Property<int>("RegularStool")
                        .HasColumnType("integer");

                    b.Property<string>("SkinManifestations")
                        .HasColumnType("text");

                    b.Property<int>("SleepTime")
                        .HasColumnType("integer");

                    b.Property<int>("Smoking")
                        .HasColumnType("integer");

                    b.Property<string>("SportActivities")
                        .HasColumnType("text");

                    b.Property<int>("SupplySystem")
                        .HasColumnType("integer");

                    b.Property<string>("TonguePlaque")
                        .HasColumnType("text");

                    b.Property<double>("Waist")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("FromUserId");

                    b.HasIndex("PersonId");

                    b.ToTable("Questionnaire");
                });

            modelBuilder.Entity("Domain.Questions", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<long>("FromUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<long>("ToUserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("FromUserId");

                    b.HasIndex("ToUserId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Domain.QuestionsPhoto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("FromUserId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.Property<long>("QuestionsId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("FromUserId");

                    b.HasIndex("QuestionsId");

                    b.ToTable("QuestionsPhotos");
                });

            modelBuilder.Entity("Domain.RequestForm", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<long>("FoodDiaryId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("FoodDiaryId");

                    b.HasIndex("UserId");

                    b.ToTable("RequestForm");
                });

            modelBuilder.Entity("Domain.Servant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActivated")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("ServantType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Servants");
                });

            modelBuilder.Entity("Domain.ServantPhoto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.Property<long>("ServantId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ServantId");

                    b.ToTable("ServantPhotos");
                });

            modelBuilder.Entity("Domain.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActivated")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<long>("PersonId")
                        .HasColumnType("bigint");

                    b.Property<long?>("SubscribeId")
                        .HasColumnType("bigint");

                    b.Property<int>("UserRole")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Domain.UserAdditionalOptions", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("AdditionalOptionsId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AdditionalOptionsId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAdditionalOptions");
                });

            modelBuilder.Entity("Domain.UserGiftSertificate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<long>("GiftSertificateId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("SurName")
                        .HasColumnType("text");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("GiftSertificateId");

                    b.HasIndex("UserId");

                    b.ToTable("UserGiftSertificates");
                });

            modelBuilder.Entity("Domain.UserServant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActivated")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsSkypePayed")
                        .HasColumnType("boolean");

                    b.Property<long>("ServantId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ServantId");

                    b.HasIndex("UserId");

                    b.ToTable("UserServants");
                });

            modelBuilder.Entity("Domain.AdditionalOptionsServant", b =>
                {
                    b.HasOne("Domain.AdditionalOptions", "AdditionalOptions")
                        .WithMany()
                        .HasForeignKey("AdditionalOptionsId");

                    b.HasOne("Domain.Servant", "Servant")
                        .WithMany()
                        .HasForeignKey("ServantId");
                });

            modelBuilder.Entity("Domain.AfterBuyAdditionalServant", b =>
                {
                    b.HasOne("Domain.AdditionalOptions", "AdditionalOptions")
                        .WithMany()
                        .HasForeignKey("AdditionalOptionsId");

                    b.HasOne("Domain.Servant", "Servant")
                        .WithMany()
                        .HasForeignKey("ServantId");
                });

            modelBuilder.Entity("Domain.BloodTestPhoto", b =>
                {
                    b.HasOne("Domain.User", "FromUser")
                        .WithMany()
                        .HasForeignKey("FromUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Questionnaire", "Questionnaire")
                        .WithMany()
                        .HasForeignKey("QuestionnaireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Comments", b =>
                {
                    b.HasOne("Domain.FoodDiary", "FoodDiary")
                        .WithMany()
                        .HasForeignKey("FoodDiaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.User", "FromUser")
                        .WithMany()
                        .HasForeignKey("FromUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.CommentsFile", b =>
                {
                    b.HasOne("Domain.Comments", "Comments")
                        .WithMany()
                        .HasForeignKey("CommentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.User", "FromUser")
                        .WithMany()
                        .HasForeignKey("FromUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Consultations", b =>
                {
                    b.HasOne("Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.FoodDiary", b =>
                {
                    b.HasOne("Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Questionnaire", b =>
                {
                    b.HasOne("Domain.User", "FromUser")
                        .WithMany()
                        .HasForeignKey("FromUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Domain.Questions", b =>
                {
                    b.HasOne("Domain.User", "FromUser")
                        .WithMany()
                        .HasForeignKey("FromUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.User", "ToUser")
                        .WithMany()
                        .HasForeignKey("ToUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.QuestionsPhoto", b =>
                {
                    b.HasOne("Domain.User", "FromUser")
                        .WithMany()
                        .HasForeignKey("FromUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Questions", "Questions")
                        .WithMany()
                        .HasForeignKey("QuestionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.RequestForm", b =>
                {
                    b.HasOne("Domain.FoodDiary", "FoodDiary")
                        .WithMany()
                        .HasForeignKey("FoodDiaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.ServantPhoto", b =>
                {
                    b.HasOne("Domain.Servant", "Servant")
                        .WithMany()
                        .HasForeignKey("ServantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.User", b =>
                {
                    b.HasOne("Domain.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.UserAdditionalOptions", b =>
                {
                    b.HasOne("Domain.AdditionalOptions", "AdditionalOptions")
                        .WithMany()
                        .HasForeignKey("AdditionalOptionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.UserGiftSertificate", b =>
                {
                    b.HasOne("Domain.GiftSertificate", "GiftSertificate")
                        .WithMany()
                        .HasForeignKey("GiftSertificateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.UserServant", b =>
                {
                    b.HasOne("Domain.Servant", "Servant")
                        .WithMany()
                        .HasForeignKey("ServantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
