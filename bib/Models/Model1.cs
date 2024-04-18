using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace bib.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }
        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Jury> Jury { get; set; }
        public virtual DbSet<Moderator> Moderator { get; set; }
        public virtual DbSet<Organizer> Organizer { get; set; }
        public virtual DbSet<Participant> Participant { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>()
                .Property(e => e.NameEvent)
                .IsUnicode(false);

            modelBuilder.Entity<Activity>()
                .Property(e => e.Activity1)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.City1)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Event)
                .WithOptional(e => e.City1)
                .HasForeignKey(e => e.City);

            modelBuilder.Entity<Country>()
                .Property(e => e.RuName)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.EnName)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.Code1)
                .IsUnicode(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Jury)
                .WithOptional(e => e.Country1)
                .HasForeignKey(e => e.Country);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Moderator)
                .WithOptional(e => e.Country1)
                .HasForeignKey(e => e.Country);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Organizer)
                .WithOptional(e => e.Country1)
                .HasForeignKey(e => e.Country);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Participant)
                .WithOptional(e => e.Country1)
                .HasForeignKey(e => e.Country);

            modelBuilder.Entity<Event>()
                .Property(e => e.Event1)
                .IsUnicode(false);

            modelBuilder.Entity<Jury>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Jury>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Jury>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Jury>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Jury>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Jury>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Jury>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<Jury>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Jury>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<Moderator>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Moderator>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Moderator>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Moderator>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Moderator>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Moderator>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Moderator>()
                .Property(e => e.Direction)
                .IsUnicode(false);

            modelBuilder.Entity<Moderator>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Moderator>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<Moderator>()
                .HasMany(e => e.Activity)
                .WithOptional(e => e.Moderator1)
                .HasForeignKey(e => e.Moderator);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<Organizer>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Photo)
                .IsUnicode(false);

            modelBuilder.Entity<Participant>()
                .Property(e => e.Gender)
                .IsUnicode(false);
        }
    }
}
