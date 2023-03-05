using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HealingAndHealthCareSystem.Migrations
{
    /// <inheritdoc />
    public partial class hehdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "varchar(350)", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    firstName = table.Column<string>(type: "varchar(1000)", nullable: false),
                    lastName = table.Column<string>(type: "varchar(1000)", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    dob = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    gender = table.Column<bool>(type: "boolean", nullable: false),
                    bookingStatus = table.Column<bool>(type: "boolean", nullable: false),
                    banStatus = table.Column<bool>(type: "boolean", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    categoryID = table.Column<Guid>(type: "uuid", nullable: false),
                    categoryName = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.categoryID);
                });

            migrationBuilder.CreateTable(
                name: "Deposit",
                columns: table => new
                {
                    depositID = table.Column<Guid>(type: "uuid", nullable: false),
                    deposit = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deposit", x => x.depositID);
                });

            migrationBuilder.CreateTable(
                name: "Exercise",
                columns: table => new
                {
                    exerciseID = table.Column<Guid>(type: "uuid", nullable: false),
                    exerciseName = table.Column<string>(type: "text", nullable: false),
                    exerciseTimePerWeek = table.Column<int>(type: "integer", nullable: false),
                    flag = table.Column<bool>(type: "boolean", nullable: false),
                    status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercise", x => x.exerciseID);
                });

            migrationBuilder.CreateTable(
                name: "FreeDay",
                columns: table => new
                {
                    freeDayID = table.Column<Guid>(type: "uuid", nullable: false),
                    freeDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    timeStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    timeEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreeDay", x => x.freeDayID);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    imageID = table.Column<Guid>(type: "uuid", nullable: false),
                    imageURL = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.imageID);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleType",
                columns: table => new
                {
                    scheduleTypeID = table.Column<Guid>(type: "uuid", nullable: false),
                    typeOfName = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleType", x => x.scheduleTypeID);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfFee",
                columns: table => new
                {
                    typeOfFeeID = table.Column<Guid>(type: "uuid", nullable: false),
                    serviceCharge = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfFee", x => x.typeOfFeeID);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    videoID = table.Column<Guid>(type: "uuid", nullable: false),
                    videoURL = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.videoID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId1 = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysiotherapistDetail",
                columns: table => new
                {
                    physiotherapistID = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    specialize = table.Column<string>(type: "text", nullable: false),
                    skill = table.Column<string>(type: "text", nullable: false),
                    schedulingStatus = table.Column<int>(type: "integer", nullable: false),
                    scheduleStatus = table.Column<int>(type: "integer", nullable: false),
                    workingStatus = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysiotherapistDetail", x => x.physiotherapistID);
                    table.ForeignKey(
                        name: "FK_PhysiotherapistDetail_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseDetail",
                columns: table => new
                {
                    exerciseDetailID = table.Column<Guid>(type: "uuid", nullable: false),
                    exerciseID = table.Column<Guid>(type: "uuid", nullable: false),
                    categoryID = table.Column<Guid>(type: "uuid", nullable: false),
                    exerciseTimePerSet = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    description = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseDetail", x => x.exerciseDetailID);
                    table.ForeignKey(
                        name: "FK_ExerciseDetail_Category_categoryID",
                        column: x => x.categoryID,
                        principalTable: "Category",
                        principalColumn: "categoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseDetail_Exercise_exerciseID",
                        column: x => x.exerciseID,
                        principalTable: "Exercise",
                        principalColumn: "exerciseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseFeedback",
                columns: table => new
                {
                    exerciseFeedbackID = table.Column<Guid>(type: "uuid", nullable: false),
                    physiotherapistID = table.Column<Guid>(type: "uuid", nullable: false),
                    exerciseID = table.Column<Guid>(type: "uuid", nullable: false),
                    feedbackContent = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseFeedback", x => x.exerciseFeedbackID);
                    table.ForeignKey(
                        name: "FK_ExerciseFeedback_Exercise_exerciseID",
                        column: x => x.exerciseID,
                        principalTable: "Exercise",
                        principalColumn: "exerciseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserExercise",
                columns: table => new
                {
                    userExercise = table.Column<Guid>(type: "uuid", nullable: false),
                    exerciseID = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserExercise", x => x.userExercise);
                    table.ForeignKey(
                        name: "FK_UserExercise_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserExercise_Exercise_exerciseID",
                        column: x => x.exerciseID,
                        principalTable: "Exercise",
                        principalColumn: "exerciseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fee",
                columns: table => new
                {
                    feeID = table.Column<Guid>(type: "uuid", nullable: false),
                    typeOfFeeID = table.Column<Guid>(type: "uuid", nullable: false),
                    fee = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fee", x => x.feeID);
                    table.ForeignKey(
                        name: "FK_Fee_TypeOfFee_typeOfFeeID",
                        column: x => x.typeOfFeeID,
                        principalTable: "TypeOfFee",
                        principalColumn: "typeOfFeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FreePhysioSchedule",
                columns: table => new
                {
                    freeScheduleID = table.Column<Guid>(type: "uuid", nullable: false),
                    freeDayID = table.Column<Guid>(type: "uuid", nullable: false),
                    physiotherapistID = table.Column<Guid>(type: "uuid", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FreePhysioSchedule", x => x.freeScheduleID);
                    table.ForeignKey(
                        name: "FK_FreePhysioSchedule_FreeDay_freeDayID",
                        column: x => x.freeDayID,
                        principalTable: "FreeDay",
                        principalColumn: "freeDayID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FreePhysioSchedule_PhysiotherapistDetail_physiotherapistID",
                        column: x => x.physiotherapistID,
                        principalTable: "PhysiotherapistDetail",
                        principalColumn: "physiotherapistID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseImage",
                columns: table => new
                {
                    exerciseImageID = table.Column<Guid>(type: "uuid", nullable: false),
                    imageID = table.Column<Guid>(type: "uuid", nullable: false),
                    exerciseDetailID = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseImage", x => x.exerciseImageID);
                    table.ForeignKey(
                        name: "FK_ExerciseImage_ExerciseDetail_exerciseDetailID",
                        column: x => x.exerciseDetailID,
                        principalTable: "ExerciseDetail",
                        principalColumn: "exerciseDetailID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseImage_Image_imageID",
                        column: x => x.imageID,
                        principalTable: "Image",
                        principalColumn: "imageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseVideo",
                columns: table => new
                {
                    exerciseVideoID = table.Column<Guid>(type: "uuid", nullable: false),
                    videoID = table.Column<Guid>(type: "uuid", nullable: false),
                    exerciseDetailID = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseVideo", x => x.exerciseVideoID);
                    table.ForeignKey(
                        name: "FK_ExerciseVideo_ExerciseDetail_exerciseDetailID",
                        column: x => x.exerciseDetailID,
                        principalTable: "ExerciseDetail",
                        principalColumn: "exerciseDetailID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseVideo_Video_videoID",
                        column: x => x.videoID,
                        principalTable: "Video",
                        principalColumn: "videoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TotalSchedule",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    totalScheduleID = table.Column<Guid>(type: "uuid", nullable: false),
                    physiotherapistID = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: true),
                    freeScheduleID = table.Column<Guid>(type: "uuid", nullable: false),
                    freescheduleID = table.Column<Guid>(type: "uuid", nullable: false),
                    timeStart = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    timeEnd = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    duaration = table.Column<int>(type: "integer", nullable: false),
                    dateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    dateUpdated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    isDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TotalSchedule", x => x.id);
                    table.ForeignKey(
                        name: "FK_TotalSchedule_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TotalSchedule_FreePhysioSchedule_freescheduleID",
                        column: x => x.freescheduleID,
                        principalTable: "FreePhysioSchedule",
                        principalColumn: "freeScheduleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TotalSchedule_PhysiotherapistDetail_physiotherapistID",
                        column: x => x.physiotherapistID,
                        principalTable: "PhysiotherapistDetail",
                        principalColumn: "physiotherapistID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScheduleDetail",
                columns: table => new
                {
                    scheduleDetailID = table.Column<Guid>(type: "uuid", nullable: false),
                    exerciseID = table.Column<Guid>(type: "uuid", nullable: false),
                    totalScheduleID = table.Column<Guid>(type: "uuid", nullable: false),
                    scheduleTypeID = table.Column<Guid>(type: "uuid", nullable: false),
                    feeID = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleDetail", x => x.scheduleDetailID);
                    table.ForeignKey(
                        name: "FK_ScheduleDetail_Exercise_exerciseID",
                        column: x => x.exerciseID,
                        principalTable: "Exercise",
                        principalColumn: "exerciseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleDetail_Fee_feeID",
                        column: x => x.feeID,
                        principalTable: "Fee",
                        principalColumn: "feeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleDetail_ScheduleType_scheduleTypeID",
                        column: x => x.scheduleTypeID,
                        principalTable: "ScheduleType",
                        principalColumn: "scheduleTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleDetail_TotalSchedule_totalScheduleID",
                        column: x => x.totalScheduleID,
                        principalTable: "TotalSchedule",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    feedbackID = table.Column<Guid>(type: "uuid", nullable: false),
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    scheduleDetailID = table.Column<Guid>(type: "uuid", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: false),
                    ratingStar = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.feedbackID);
                    table.ForeignKey(
                        name: "FK_Feedback_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedback_ScheduleDetail_scheduleDetailID",
                        column: x => x.scheduleDetailID,
                        principalTable: "ScheduleDetail",
                        principalColumn: "scheduleDetailID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    paymentID = table.Column<Guid>(type: "uuid", nullable: false),
                    scheduleDetailID = table.Column<Guid>(type: "uuid", nullable: false),
                    totalPrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.paymentID);
                    table.ForeignKey(
                        name: "FK_Payment_ScheduleDetail_scheduleDetailID",
                        column: x => x.scheduleDetailID,
                        principalTable: "ScheduleDetail",
                        principalColumn: "scheduleDetailID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId1",
                table: "AspNetUserRoles",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseDetail_categoryID",
                table: "ExerciseDetail",
                column: "categoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseDetail_exerciseID",
                table: "ExerciseDetail",
                column: "exerciseID");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseFeedback_exerciseID",
                table: "ExerciseFeedback",
                column: "exerciseID");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseImage_exerciseDetailID",
                table: "ExerciseImage",
                column: "exerciseDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseImage_imageID",
                table: "ExerciseImage",
                column: "imageID");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseVideo_exerciseDetailID",
                table: "ExerciseVideo",
                column: "exerciseDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseVideo_videoID",
                table: "ExerciseVideo",
                column: "videoID");

            migrationBuilder.CreateIndex(
                name: "IX_Fee_typeOfFeeID",
                table: "Fee",
                column: "typeOfFeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_Id",
                table: "Feedback",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_scheduleDetailID",
                table: "Feedback",
                column: "scheduleDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_FreePhysioSchedule_freeDayID",
                table: "FreePhysioSchedule",
                column: "freeDayID");

            migrationBuilder.CreateIndex(
                name: "IX_FreePhysioSchedule_physiotherapistID",
                table: "FreePhysioSchedule",
                column: "physiotherapistID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_scheduleDetailID",
                table: "Payment",
                column: "scheduleDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_PhysiotherapistDetail_Id",
                table: "PhysiotherapistDetail",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleDetail_exerciseID",
                table: "ScheduleDetail",
                column: "exerciseID");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleDetail_feeID",
                table: "ScheduleDetail",
                column: "feeID");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleDetail_scheduleTypeID",
                table: "ScheduleDetail",
                column: "scheduleTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleDetail_totalScheduleID",
                table: "ScheduleDetail",
                column: "totalScheduleID");

            migrationBuilder.CreateIndex(
                name: "IX_TotalSchedule_freescheduleID",
                table: "TotalSchedule",
                column: "freescheduleID");

            migrationBuilder.CreateIndex(
                name: "IX_TotalSchedule_Id",
                table: "TotalSchedule",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TotalSchedule_physiotherapistID",
                table: "TotalSchedule",
                column: "physiotherapistID");

            migrationBuilder.CreateIndex(
                name: "IX_UserExercise_exerciseID",
                table: "UserExercise",
                column: "exerciseID");

            migrationBuilder.CreateIndex(
                name: "IX_UserExercise_Id",
                table: "UserExercise",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Deposit");

            migrationBuilder.DropTable(
                name: "ExerciseFeedback");

            migrationBuilder.DropTable(
                name: "ExerciseImage");

            migrationBuilder.DropTable(
                name: "ExerciseVideo");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "UserExercise");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "ExerciseDetail");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "ScheduleDetail");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Exercise");

            migrationBuilder.DropTable(
                name: "Fee");

            migrationBuilder.DropTable(
                name: "ScheduleType");

            migrationBuilder.DropTable(
                name: "TotalSchedule");

            migrationBuilder.DropTable(
                name: "TypeOfFee");

            migrationBuilder.DropTable(
                name: "FreePhysioSchedule");

            migrationBuilder.DropTable(
                name: "FreeDay");

            migrationBuilder.DropTable(
                name: "PhysiotherapistDetail");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
