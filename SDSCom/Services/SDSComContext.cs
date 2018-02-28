using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SDSCom.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Caching.Memory;
using JetBrains.Annotations;

namespace SDSCom
{
    public class SDSComContext : DbContext
    {      
        public SDSComContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Document> Documents { get; set; }

        public IQueryable<Document> DocumentsReader
        {
            get { return Set<Document>().AsNoTracking(); }
        }

        public DbSet<ApplicationSetting> AppSettings { get; set; }

        public IQueryable<ApplicationSetting> AppSettingsReader
        {
            get{return Set<ApplicationSetting>().AsNoTracking();}
        }

        //================================================================================

        public DbSet<Entity> Entities { get; set; }

        public IQueryable<Entity> EntitiesReader
        {
            get { return Set<Entity>().AsNoTracking(); }
        }

        //================================================================================

        public DbSet<EntityType> EntityTypes { get; set; }

        public IQueryable<EntityType> EntityTypesReader
        {
            get { return Set<EntityType>().AsNoTracking(); }
        }

        //================================================================================

        public DbSet<EuphracPhrase> Phrases { get; set; }

        public IQueryable<EuphracPhrase> PhrasesReader
        {
            get { return Set<EuphracPhrase>().AsNoTracking(); }
        }

        //================================================================================
        
        public DbSet<Facet> Facets { get; set; }

        public IQueryable<Facet> FacetsReader
        {
            get { return Set<Facet>().AsNoTracking(); }
        }

        //================================================================================
        
        public DbSet<EntityChapter> EntityChapters { get; set; }

        public IQueryable<EntityChapter> EntityChaptersReader
        {
            get { return Set<EntityChapter>().AsNoTracking(); }
        }

        //================================================================================

        public DbSet<User> Users { get; set; }

        public IQueryable<User> UsersReader
        {
            get { return Set<User>().AsNoTracking(); }
        }

        //================================================================================
        
        public DbSet<FacetPhraseLink> FacetPhraseLinks { get; set; }

        public IQueryable<FacetPhraseLink> FacetPhraseLinksReader
        {
            get { return Set<FacetPhraseLink>().AsNoTracking(); }
        }

        //================================================================================

        public DbSet<FacetRestriction> FacetRestrictions { get; set; }

        public IQueryable<FacetRestriction> FacetRestrictionsReader
        {
            get { return Set<FacetRestriction>().AsNoTracking(); }
        }

        //================================================================================

        public DbSet<DataSheetFeedImport> Imports { get; set; }

        public IQueryable<DataSheetFeedImport> ImportsReader
        {
            get { return Set<DataSheetFeedImport>().AsNoTracking(); }
        }

        //================================================================================
        
        public DbSet<ValidationMessage> ValidationMessages { get; set; }

        public IQueryable<ValidationMessage> ValidationMessagesReader
        {
            get { return Set<ValidationMessage>().AsNoTracking(); }
        }

        //================================================================================
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                SDSComApp app = new SDSComApp();
                optionsBuilder.UseNpgsql(app.GetConnectionString());
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

            modelBuilder.Entity<Document>(entity =>
            {
                entity.ToTable("document");

                entity.Property(e => e.Id).HasColumnName("id").IsRequired().UseNpgsqlSerialColumn<long>();

                entity.Property(e => e.EntityID).HasColumnName("entity_id").IsRequired();

                entity.Property(e => e.EntityName).HasColumnName("entity_name").IsRequired();

                entity.Property(e => e.CreatedDate).HasColumnName("created_date").IsRequired();

                entity.Property(e => e.CreatedUser).HasColumnName("created_user").IsRequired();

                entity.Property(e => e.Content).HasColumnName("content").IsRequired();

                entity.Property(e => e.Source).HasColumnName("source").IsRequired();

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Language).HasColumnName("language");

            });
        }

    }
}
