namespace CenterWebMake.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model123 : DbContext
    {
        public Model123()
            : base("name=Model1231")
        {
        }

        public virtual DbSet<CenterNewsCreate> CenterNewsCreate { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Culturalexchanges> Culturalexchanges { get; set; }
        public virtual DbSet<AchievementShow> AchievementShows { get; set; }
        public virtual DbSet<Notice> Notice { get; set; }
        public virtual DbSet<Labintroduce> Labintroduce { get; set; }
        public virtual DbSet<AcademicExchange> AcademicExchange { get; set; }
        public virtual DbSet<PhotoControl> PhotoControl { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}