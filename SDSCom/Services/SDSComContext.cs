using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SDSCom.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Caching.Memory;

namespace SDSCom
{
    public class SDSComContext : DbContext
    {
        private readonly IConfiguration config;

        public SDSComContext(IConfiguration _config) 
        {
            config = _config;
        }

        public virtual DbSet<ApplicationSetting> AppSettings { get; set; }

        public virtual IQueryable<ApplicationSetting> AppSettingsReader
        {
            get{return Set<ApplicationSetting>().AsNoTracking();}
        }

        //================================================================================

        public virtual DbSet<Entity> Entities { get; set; }

        public virtual IQueryable<Entity> EntitiesReader
        {
            get { return Set<Entity>().AsNoTracking(); }
        }

        //================================================================================

        public virtual DbSet<EntityType> EntityTypes { get; set; }

        public virtual IQueryable<EntityType> EntityTypesReader
        {
            get { return Set<EntityType>().AsNoTracking(); }
        }

        //================================================================================

        public virtual DbSet<EuphracPhrase> Phrases { get; set; }

        public virtual IQueryable<EuphracPhrase> PhrasesReader
        {
            get { return Set<EuphracPhrase>().AsNoTracking(); }
        }

        //================================================================================
        
        public virtual DbSet<Facet> Facets { get; set; }

        public virtual IQueryable<Facet> FacetsReader
        {
            get { return Set<Facet>().AsNoTracking(); }
        }

        //================================================================================
        
        public virtual DbSet<EntityChapter> EntityChapters { get; set; }

        public virtual IQueryable<EntityChapter> EntityChaptersReader
        {
            get { return Set<EntityChapter>().AsNoTracking(); }
        }

        //================================================================================

        public virtual DbSet<User> Users { get; set; }

        public virtual IQueryable<User> UsersReader
        {
            get { return Set<User>().AsNoTracking(); }
        }

        //================================================================================
        
        public virtual DbSet<FacetPhraseLink> FacetPhraseLinks { get; set; }

        public virtual IQueryable<FacetPhraseLink> FacetPhraseLinksReader
        {
            get { return Set<FacetPhraseLink>().AsNoTracking(); }
        }

        //================================================================================

        public virtual DbSet<FacetRestriction> FacetRestrictions { get; set; }

        public virtual IQueryable<FacetRestriction> FacetRestrictionsReader
        {
            get { return Set<FacetRestriction>().AsNoTracking(); }
        }

        //================================================================================

        public virtual DbSet<DataSheetFeedImport> Imports { get; set; }

        public virtual IQueryable<DataSheetFeedImport> ImportsReader
        {
            get { return Set<DataSheetFeedImport>().AsNoTracking(); }
        }

        //================================================================================
        
        public virtual DbSet<ValidationMessage> ValidationMessages { get; set; }

        public virtual IQueryable<ValidationMessage> ValidationMessagesReader
        {
            get { return Set<ValidationMessage>().AsNoTracking(); }
        }

        //================================================================================


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseNpgsql(@"Server=sdscom.c5o9b1nqgmsb.us-east-1.rds.amazonaws.com;Port=5432;Database=sdscom;User Id=sdscom;Password=Gollum17;");
                optionsBuilder.UseNpgsql(config.GetConnectionString("SDSCom"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationSetting>(entity =>
            {
                entity.ToTable("application_setting");
                
                entity.Property(e => e.Id).HasColumnName("id")
                    .IsRequired()
                    .UseNpgsqlSerialColumn();

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasColumnName("area");

                entity.Property(e => e.DataValue)
                    .IsRequired()
                    .HasColumnName("data_value");

                entity.Property(e => e.Setting)
                    .IsRequired()
                    .HasColumnName("setting");
            });
        
            modelBuilder.Entity<DataSheetFeedImport>(entity =>
            {
                entity.ToTable("data_sheet_feed_import");

                entity.Property(e => e.Id).HasColumnName("id")
                                .IsRequired()
                                .UseNpgsqlSerialColumn();

                entity.Property(e => e.DateStamp).HasColumnName("date_stamp")
                                .IsRequired();

                entity.Property(e => e.FileContent).HasColumnName("file_content");

                entity.Property(e => e.FileName).HasColumnName("file_name");

                entity.Property(e => e.IsValid).HasColumnName("is_valid")
                                .IsRequired();

                entity.Property(e => e.UserId).HasColumnName("user_id")
                                .IsRequired();

                entity.Property(e => e.ValidationMessage).HasColumnName("validation_message");
            });

            modelBuilder.Entity<Entity>(entity =>
            {
                entity.ToTable("entity");

                entity.Property(e => e.Id).HasColumnName("id")
                                .IsRequired()
                                .UseNpgsqlSerialColumn();

                entity.Property(e => e.Active).HasColumnName("active")
                                 .IsRequired();

                entity.Property(e => e.DateStamp).HasColumnName("date_stamp")
                                .IsRequired();

                entity.Property(e => e.EntityName)
                                .IsRequired()
                                .HasColumnName("entity_name")
                                .HasMaxLength(1000);

                entity.Property(e => e.EntityType).HasColumnName("entity_type")
                                .IsRequired();

                entity.Property(e => e.OtherId).HasColumnName("other_id").HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("user_id")
                                .IsRequired();
            });          

            modelBuilder.Entity<EntityChapter>(entity =>
            {
                entity.ToTable("entity_chapter");

                entity.Property(e => e.Id).HasColumnName("id")
                                .IsRequired()
                                .UseNpgsqlSerialColumn();

                entity.Property(e => e.ChapterName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("chapter_name");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.DateStamp).HasColumnName("date_stamp")
                                    .IsRequired();

                entity.Property(e => e.EntityId).HasColumnName("entity_id")
                                    .IsRequired();

                entity.Property(e => e.UserId).HasColumnName("user_id")
                                    .IsRequired();
            });

            modelBuilder.Entity<EntityType>(entity =>
            {
                entity.ToTable("entity_type");

                entity.Property(e => e.ID)
                                    .HasColumnName("id")
                                    .IsRequired()
                                    .UseNpgsqlSerialColumn();

                entity.Property(e => e.EntityTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("entity_type_name");
            });

            modelBuilder.Entity<Facet>(entity =>
            {
                entity.ToTable("facet");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasColumnName("datatype");

                entity.Property(e => e.DateStamp).HasColumnName("datestamp");

                entity.Property(e => e.MaxOccurs)
                    .IsRequired()
                    .HasColumnName("maxoccurs");

                entity.Property(e => e.MaxSize)
                    .IsRequired()
                    .HasColumnName("maxsize");

                entity.Property(e => e.MinOccurs)
                    .IsRequired()
                    .HasColumnName("minoccurs");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.ParentId)
                    .IsRequired()
                    .HasColumnName("parentid");

                entity.Property(e => e.ParentPath)
                    .IsRequired()
                    .HasColumnName("parentpath");

                entity.Property(e => e.SchemaFileName)
                    .IsRequired()
                    .HasColumnName("schemafilename");

                entity.Property(e => e.SDSComVersion)
                    .IsRequired()
                    .HasColumnName("sdscomversion");
            });
                      

            modelBuilder.Entity<FacetPhraseLink>(entity =>
            {
                entity.ToTable("facet_phrase_link");

                entity.Property(e => e.Id).HasColumnName("id").IsRequired();

                entity.Property(e => e.EntityId).HasColumnName("entity_id").IsRequired();

                entity.Property(e => e.FacetId).HasColumnName("facet_id").IsRequired();

                entity.Property(e => e.PhraseId).HasColumnName("phrase_id").IsRequired();

                entity.Property(e => e.StartDateStamp).HasColumnName("start_date_stamp").IsRequired();

                entity.Property(e => e.StopDateStamp).HasColumnName("stop_date_stamp").IsRequired();

                entity.Property(e => e.UserId).HasColumnName("user_id").IsRequired();
            });          

            modelBuilder.Entity<FacetRestriction>(entity =>
            {
                entity.ToTable("facet_restriction");

                entity.Property(e => e.Id).HasColumnName("id").IsRequired().UseNpgsqlSerialColumn<int>();

                entity.Property(e => e.Enumerations).HasColumnName("enumerations");

                entity.Property(e => e.FacetId).HasColumnName("facet_id").IsRequired();

                entity.Property(e => e.IsList).HasColumnName("is_list").IsRequired();

                entity.Property(e => e.Name).IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.OtherInfo).HasColumnName("other_info");

                entity.Property(e => e.RegularExpressionPattern).HasColumnName("regular_expression_pattern");
            });

            modelBuilder.Entity<FacetValue>(entity =>
            {
                entity.ToTable("facet_value");

                entity.Property(e => e.Id).HasColumnName("id").IsRequired().UseNpgsqlSerialColumn<int>();

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data");

                entity.Property(e => e.EntityId).HasColumnName("entity_id").IsRequired();

                entity.Property(e => e.FacetId).HasColumnName("facet_id").IsRequired();

                entity.Property(e => e.StartDateStamp).HasColumnName("start_date_stamp").IsRequired();

                entity.Property(e => e.StopDateStamp).HasColumnName("stop_date_stamp").IsRequired();

                entity.Property(e => e.UserId).HasColumnName("user_id").IsRequired();
            });

            modelBuilder.Entity<EuphracPhrase>(entity =>
            {
                entity.HasKey(e => e.EuPhraCStructureCode);

                entity.ToTable("phrases");

                entity.Property(e => e.EuPhraCStructureCode)
                    .HasColumnName("structure_code")
                    .HasColumnType("varchar")
                    .ValueGeneratedNever();

                entity.Property(e => e.English).HasColumnName("english");

                entity.Property(e => e.German).HasColumnName("german");

                entity.Property(e => e.Info).HasColumnName("info");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasColumnType("varchar");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("varchar");

                entity.Property(e => e.RevisionDate)
                    .HasColumnName("revision_date")
                    .HasColumnType("varchar");

                entity.Property(e => e.Source).HasColumnName("source");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.Id).HasColumnName("id").IsRequired().UseNpgsqlSerialColumn<int>();

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.IsAdmin).HasColumnName("is_admin");

                entity.Property(e => e.CreateDate).HasColumnName("create_date").IsRequired();

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.FirstName).HasColumnName("first_name");

                entity.Property(e => e.LastName).HasColumnName("last_name");

                entity.Property(e => e.Password).HasColumnName("password").IsRequired();

                entity.Property(e => e.UpdateDate).HasColumnName("update_date").IsRequired();

                entity.Property(e => e.UserName).HasColumnName("user_name").IsRequired();
            });           

            modelBuilder.Entity<ValidationMessage>(entity =>
            {
                entity.ToTable("validation_message");

                entity.Property(e => e.Id).HasColumnName("id").IsRequired().UseNpgsqlSerialColumn<int>();

                entity.Property(e => e.FacetId).HasColumnName("facet_id").IsRequired();

                entity.Property(e => e.Data).HasColumnName("data").IsRequired();
            });
        }

    }
}
