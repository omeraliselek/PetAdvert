using PetAdvert.Core.Entity;
using PetAdvert.Map.Option;
using PetAdvert.Model.Option;
using PetAdvert.Utility;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PetAdvert.DAL.Context
{
    public class ProjectContext: DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=PetDatabase;uid=tnr;pwd=123456;";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdvertisementMap());
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new DistrictMap());
            modelBuilder.Configurations.Add(new GeneralSettingMap());
            modelBuilder.Configurations.Add(new MessageMap());
            modelBuilder.Configurations.Add(new PettypeMap());
            modelBuilder.Configurations.Add(new QuestionAnswerMap());
            modelBuilder.Configurations.Add(new RaceMap());
            modelBuilder.Configurations.Add(new StaticPageMap());

        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Advertisement> advertisements { get; set; }
        public DbSet<AppUser> appUsers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<GeneralSetting> generalSettings { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Pettype> Pettypes { get; set; }
        public DbSet<QuestionAnswer> questionAnswers { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<StaticPage> staticPages { get; set; }
        public override int SaveChanges()

        {
            var modifiedEntries = ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State == EntityState.Modified);

            string identity = WindowsIdentity.GetCurrent().Name;
            string computerName = Environment.MachineName;
            DateTime dateTime = DateTime.Now;
            string GetIp = RemoteIP.IpAddress;

            foreach (var item in modifiedEntries)
            {
                CoreEntity entity = item.Entity as CoreEntity;

                if (item.State == EntityState.Added)
                {
                    entity.CreatedUserName = identity;
                    entity.CreatedComputerName = computerName;
                    entity.CreatedDate = dateTime;
                    entity.CreatedIP = GetIp;
                }
                else if (item.State == EntityState.Modified)
                {
                    entity.ModifiedUserName = identity;
                    entity.ModifiedComputerName = computerName;
                    entity.ModifiedDate = dateTime;
                    entity.ModifiedIP = GetIp;
                }
            }
            return base.SaveChanges();
        }
    }
}
