using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataAccess
{
    public class AppDbContext : IdentityDbContext<User, Role, Guid, IdentityUserClaim<Guid>, UserRole, IdentityUserLogin<Guid>, IdentityRoleClaim<Guid>, IdentityUserToken<Guid>>
    {
        public AppDbContext(DbContextOptions options) : base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
      
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Deposit> Deposit { get; set; }
        public DbSet<Exercise> Exercise { get; set; }
        public DbSet<ExerciseDetail> ExerciseDetail { get; set; }
        public DbSet<ExerciseFeedback> ExerciseFeedback { get; set; }
        public DbSet<ExerciseVideo> ExerciseVideo { get; set; }
        public DbSet<ExerciseImage> ExerciseImage { get; set; }
        public DbSet<Fee> Fee { get; set; }
        public DbSet<Feedback> Feedback { get; set; }
        public DbSet<FreeDay> FreeDay { get; set; }
        public DbSet<FreePhysioSchedule> FreePhysioSchedule { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<PhysiotherapistDetail> PhysiotherapistDetail { get; set; }
        public DbSet<ScheduleDetail> ScheduleDetail { get; set; }
        public DbSet<ScheduleType> ScheduleType { get; set; }
        public DbSet<TotalSchedule> TotalSchedule { get; set; }
        public DbSet<TypeOfFee> TypeOfFee { get; set; }
        public DbSet<UserExercise> UserExercise { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Role> Role { get; set; }

    }
}
