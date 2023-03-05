﻿// <auto-generated />
using System;
using Data.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HealingAndHealthCareSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Data.Entities.Category", b =>
                {
                    b.Property<Guid>("categoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("categoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("categoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Data.Entities.Deposit", b =>
                {
                    b.Property<Guid>("depositID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<float>("deposit")
                        .HasColumnType("real");

                    b.HasKey("depositID");

                    b.ToTable("Deposit");
                });

            modelBuilder.Entity("Data.Entities.Exercise", b =>
                {
                    b.Property<Guid>("exerciseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("exerciseName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("exerciseTimePerWeek")
                        .HasColumnType("integer");

                    b.Property<bool>("flag")
                        .HasColumnType("boolean");

                    b.Property<bool>("status")
                        .HasColumnType("boolean");

                    b.HasKey("exerciseID");

                    b.ToTable("Exercise");
                });

            modelBuilder.Entity("Data.Entities.ExerciseDetail", b =>
                {
                    b.Property<Guid>("exerciseDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("categoryID")
                        .HasColumnType("uuid");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("exerciseID")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("exerciseTimePerSet")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("exerciseDetailID");

                    b.HasIndex("categoryID");

                    b.HasIndex("exerciseID");

                    b.ToTable("ExerciseDetail");
                });

            modelBuilder.Entity("Data.Entities.ExerciseFeedback", b =>
                {
                    b.Property<Guid>("exerciseFeedbackID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("exerciseID")
                        .HasColumnType("uuid");

                    b.Property<string>("feedbackContent")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("physiotherapistID")
                        .HasColumnType("uuid");

                    b.HasKey("exerciseFeedbackID");

                    b.HasIndex("exerciseID");

                    b.ToTable("ExerciseFeedback");
                });

            modelBuilder.Entity("Data.Entities.ExerciseImage", b =>
                {
                    b.Property<Guid>("exerciseImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("exerciseDetailID")
                        .HasColumnType("uuid");

                    b.Property<Guid>("imageID")
                        .HasColumnType("uuid");

                    b.HasKey("exerciseImageID");

                    b.HasIndex("exerciseDetailID");

                    b.HasIndex("imageID");

                    b.ToTable("ExerciseImage");
                });

            modelBuilder.Entity("Data.Entities.ExerciseVideo", b =>
                {
                    b.Property<Guid>("exerciseVideoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("exerciseDetailID")
                        .HasColumnType("uuid");

                    b.Property<Guid>("videoID")
                        .HasColumnType("uuid");

                    b.HasKey("exerciseVideoID");

                    b.HasIndex("exerciseDetailID");

                    b.HasIndex("videoID");

                    b.ToTable("ExerciseVideo");
                });

            modelBuilder.Entity("Data.Entities.Fee", b =>
                {
                    b.Property<Guid>("feeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<float>("fee")
                        .HasColumnType("real");

                    b.Property<Guid>("typeOfFeeID")
                        .HasColumnType("uuid");

                    b.HasKey("feeID");

                    b.HasIndex("typeOfFeeID");

                    b.ToTable("Fee");
                });

            modelBuilder.Entity("Data.Entities.Feedback", b =>
                {
                    b.Property<Guid>("feedbackID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ratingStar")
                        .HasColumnType("integer");

                    b.Property<Guid>("scheduleDetailID")
                        .HasColumnType("uuid");

                    b.HasKey("feedbackID");

                    b.HasIndex("Id");

                    b.HasIndex("scheduleDetailID");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("Data.Entities.FreeDay", b =>
                {
                    b.Property<Guid>("freeDayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("freeDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("timeEnd")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("timeStart")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("freeDayID");

                    b.ToTable("FreeDay");
                });

            modelBuilder.Entity("Data.Entities.FreePhysioSchedule", b =>
                {
                    b.Property<Guid>("freeScheduleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("freeDayID")
                        .HasColumnType("uuid");

                    b.Property<Guid>("physiotherapistID")
                        .HasColumnType("uuid");

                    b.HasKey("freeScheduleID");

                    b.HasIndex("freeDayID");

                    b.HasIndex("physiotherapistID");

                    b.ToTable("FreePhysioSchedule");
                });

            modelBuilder.Entity("Data.Entities.Image", b =>
                {
                    b.Property<Guid>("imageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("imageURL")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("imageID");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("Data.Entities.Payment", b =>
                {
                    b.Property<Guid>("paymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("scheduleDetailID")
                        .HasColumnType("uuid");

                    b.Property<float>("totalPrice")
                        .HasColumnType("real");

                    b.HasKey("paymentID");

                    b.HasIndex("scheduleDetailID");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("Data.Entities.PhysiotherapistDetail", b =>
                {
                    b.Property<Guid>("physiotherapistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<int>("scheduleStatus")
                        .HasColumnType("integer");

                    b.Property<int>("schedulingStatus")
                        .HasColumnType("integer");

                    b.Property<string>("skill")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("specialize")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("workingStatus")
                        .HasColumnType("integer");

                    b.HasKey("physiotherapistID");

                    b.HasIndex("Id");

                    b.ToTable("PhysiotherapistDetail");
                });

            modelBuilder.Entity("Data.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(350)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Data.Entities.ScheduleDetail", b =>
                {
                    b.Property<Guid>("scheduleDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("exerciseID")
                        .HasColumnType("uuid");

                    b.Property<Guid>("feeID")
                        .HasColumnType("uuid");

                    b.Property<Guid>("scheduleTypeID")
                        .HasColumnType("uuid");

                    b.Property<Guid>("totalScheduleID")
                        .HasColumnType("uuid");

                    b.HasKey("scheduleDetailID");

                    b.HasIndex("exerciseID");

                    b.HasIndex("feeID");

                    b.HasIndex("scheduleTypeID");

                    b.HasIndex("totalScheduleID");

                    b.ToTable("ScheduleDetail");
                });

            modelBuilder.Entity("Data.Entities.ScheduleType", b =>
                {
                    b.Property<Guid>("scheduleTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("typeOfName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("scheduleTypeID");

                    b.ToTable("ScheduleType");
                });

            modelBuilder.Entity("Data.Entities.TotalSchedule", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("dateCreated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("dateUpdated")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("duaration")
                        .HasColumnType("integer");

                    b.Property<Guid>("freeScheduleID")
                        .HasColumnType("uuid");

                    b.Property<Guid>("freescheduleID")
                        .HasColumnType("uuid");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid>("physiotherapistID")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("timeEnd")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("timeStart")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("totalScheduleID")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("Id");

                    b.HasIndex("freescheduleID");

                    b.HasIndex("physiotherapistID");

                    b.ToTable("TotalSchedule");
                });

            modelBuilder.Entity("Data.Entities.TypeOfFee", b =>
                {
                    b.Property<Guid>("typeOfFeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("serviceCharge")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("typeOfFeeID");

                    b.ToTable("TypeOfFee");
                });

            modelBuilder.Entity("Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("banStatus")
                        .HasColumnType("boolean");

                    b.Property<bool>("bookingStatus")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("dob")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<bool>("gender")
                        .HasColumnType("boolean");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Data.Entities.UserExercise", b =>
                {
                    b.Property<Guid>("userExercise")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("exerciseID")
                        .HasColumnType("uuid");

                    b.HasKey("userExercise");

                    b.HasIndex("Id");

                    b.HasIndex("exerciseID");

                    b.ToTable("UserExercise");
                });

            modelBuilder.Entity("Data.Entities.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("UserId1")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId1");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Data.Entities.Video", b =>
                {
                    b.Property<Guid>("videoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("videoURL")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("videoID");

                    b.ToTable("Video");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Data.Entities.ExerciseDetail", b =>
                {
                    b.HasOne("Data.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("exerciseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("Data.Entities.ExerciseFeedback", b =>
                {
                    b.HasOne("Data.Entities.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("exerciseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("Data.Entities.ExerciseImage", b =>
                {
                    b.HasOne("Data.Entities.ExerciseDetail", "ExerciseDetail")
                        .WithMany()
                        .HasForeignKey("exerciseDetailID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Image", "Image")
                        .WithMany()
                        .HasForeignKey("imageID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExerciseDetail");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Data.Entities.ExerciseVideo", b =>
                {
                    b.HasOne("Data.Entities.ExerciseDetail", "ExerciseDetail")
                        .WithMany()
                        .HasForeignKey("exerciseDetailID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Video", "Video")
                        .WithMany()
                        .HasForeignKey("videoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExerciseDetail");

                    b.Navigation("Video");
                });

            modelBuilder.Entity("Data.Entities.Fee", b =>
                {
                    b.HasOne("Data.Entities.TypeOfFee", "TypeOfFee")
                        .WithMany()
                        .HasForeignKey("typeOfFeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeOfFee");
                });

            modelBuilder.Entity("Data.Entities.Feedback", b =>
                {
                    b.HasOne("Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.ScheduleDetail", "ScheduleDetail")
                        .WithMany()
                        .HasForeignKey("scheduleDetailID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ScheduleDetail");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.Entities.FreePhysioSchedule", b =>
                {
                    b.HasOne("Data.Entities.FreeDay", "FreeDay")
                        .WithMany()
                        .HasForeignKey("freeDayID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.PhysiotherapistDetail", "PhysiotherapistDetail")
                        .WithMany()
                        .HasForeignKey("physiotherapistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FreeDay");

                    b.Navigation("PhysiotherapistDetail");
                });

            modelBuilder.Entity("Data.Entities.Payment", b =>
                {
                    b.HasOne("Data.Entities.ScheduleDetail", "ScheduleDetail")
                        .WithMany()
                        .HasForeignKey("scheduleDetailID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ScheduleDetail");
                });

            modelBuilder.Entity("Data.Entities.PhysiotherapistDetail", b =>
                {
                    b.HasOne("Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.Entities.ScheduleDetail", b =>
                {
                    b.HasOne("Data.Entities.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("exerciseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Fee", "Fee")
                        .WithMany()
                        .HasForeignKey("feeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.ScheduleType", "ScheduleType")
                        .WithMany()
                        .HasForeignKey("scheduleTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.TotalSchedule", "TotalSchedule")
                        .WithMany()
                        .HasForeignKey("totalScheduleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Fee");

                    b.Navigation("ScheduleType");

                    b.Navigation("TotalSchedule");
                });

            modelBuilder.Entity("Data.Entities.TotalSchedule", b =>
                {
                    b.HasOne("Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("Id");

                    b.HasOne("Data.Entities.FreePhysioSchedule", "FreePhysioSchedule")
                        .WithMany()
                        .HasForeignKey("freescheduleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.PhysiotherapistDetail", "PhysiotherapistDetail")
                        .WithMany()
                        .HasForeignKey("physiotherapistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FreePhysioSchedule");

                    b.Navigation("PhysiotherapistDetail");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.Entities.UserExercise", b =>
                {
                    b.HasOne("Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("exerciseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.Entities.UserRole", b =>
                {
                    b.HasOne("Data.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.User", null)
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Data.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}