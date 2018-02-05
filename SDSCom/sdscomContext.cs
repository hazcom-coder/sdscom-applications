using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SDSCom.Models;

namespace SDSCom
{
    public partial class sdscomContext : DbContext
    {
        public virtual DbSet<ApplicationSetting> ApplicationSetting { get; set; }
      //  public virtual DbSet<Datasheetfeedimport> Datasheetfeedimport { get; set; }
        public virtual DbSet<DataSheetFeedImport> DataSheetFeedImport { get; set; }
        public virtual DbSet<Entity> Entity { get; set; }
       // public virtual DbSet<Entitychapter> Entitychapter { get; set; }
        public virtual DbSet<EntityChapter> EntityChapter { get; set; }
        public virtual DbSet<EntityType> EntityType { get; set; }
        public virtual DbSet<Facet> Facet { get; set; }
      //  public virtual DbSet<Facetphraselink> Facetphraselink { get; set; }
        public virtual DbSet<FacetPhraseLink> FacetPhraseLink { get; set; }
      //  public virtual DbSet<Facetrestriction> Facetrestriction { get; set; }
        public virtual DbSet<FacetRestriction> FacetRestriction { get; set; }
      //  public virtual DbSet<Facetvalue> Facetvalue { get; set; }
        public virtual DbSet<FacetValue> FacetValue { get; set; }
        public virtual DbSet<Phrase> Phrases { get; set; }
        public virtual DbSet<User> User { get; set; }
     //   public virtual DbSet<Validationmessage> Validationmessage { get; set; }
        public virtual DbSet<ValidationMessage> ValidationMessage { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql(@"Server=sdscom.c5o9b1nqgmsb.us-east-1.rds.amazonaws.com;Port=5432;Database=sdscom;User Id=sdscom;Password=Gollum17;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationSetting>(entity =>
            {
                entity.ToTable("application_setting");

                entity.Property(e => e.Id).HasColumnName("id");

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

            //modelBuilder.Entity<Datasheetfeedimport>(entity =>
            //{
            //    entity.ToTable("datasheetfeedimport");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Datestamp).HasColumnName("datestamp");

            //    entity.Property(e => e.Filecontent).HasColumnName("filecontent");

            //    entity.Property(e => e.Filename).HasColumnName("filename");

            //    entity.Property(e => e.Isvalid).HasColumnName("isvalid");

            //    entity.Property(e => e.Userid).HasColumnName("userid");

            //    entity.Property(e => e.Validationmessage).HasColumnName("validationmessage");
            //});

            modelBuilder.Entity<DataSheetFeedImport>(entity =>
            {
                entity.ToTable("data_sheet_feed_import");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateStamp).HasColumnName("date_stamp");

                entity.Property(e => e.FileContent).HasColumnName("file_content");

                entity.Property(e => e.FileName).HasColumnName("file_name");

                entity.Property(e => e.IsValid).HasColumnName("is_valid");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.ValidationMessage).HasColumnName("validation_message");
            });

            modelBuilder.Entity<Entity>(entity =>
            {
                entity.ToTable("entity");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.DateStamp).HasColumnName("date_stamp");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasColumnName("entity_name");

                entity.Property(e => e.EntityType).HasColumnName("entity_type");

                entity.Property(e => e.OtherId).HasColumnName("other_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            //modelBuilder.Entity<Entitychapter>(entity =>
            //{
            //    entity.ToTable("entitychapter");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Chaptername)
            //        .IsRequired()
            //        .HasColumnName("chaptername");

            //    entity.Property(e => e.Data).HasColumnName("data");

            //    entity.Property(e => e.Datestamp).HasColumnName("datestamp");

            //    entity.Property(e => e.Entityid).HasColumnName("entityid");

            //    entity.Property(e => e.Userid).HasColumnName("userid");
            //});

            modelBuilder.Entity<EntityChapter>(entity =>
            {
                entity.ToTable("entity_chapter");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ChapterName)
                    .IsRequired()
                    .HasColumnName("chapter_name");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.DateStamp).HasColumnName("date_stamp");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<EntityType>(entity =>
            {
                entity.ToTable("entity_type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EntityTypeName)
                    .IsRequired()
                    .HasColumnName("entity_type_name");
            });

            modelBuilder.Entity<Facet>(entity =>
            {
                entity.ToTable("facet");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.Datatype)
                    .IsRequired()
                    .HasColumnName("datatype");

                entity.Property(e => e.Datestamp).HasColumnName("datestamp");

                entity.Property(e => e.Maxoccurs)
                    .IsRequired()
                    .HasColumnName("maxoccurs");

                entity.Property(e => e.Maxsize).HasColumnName("maxsize");

                entity.Property(e => e.Minoccurs)
                    .IsRequired()
                    .HasColumnName("minoccurs");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Parentid).HasColumnName("parentid");

                entity.Property(e => e.Parentpath)
                    .IsRequired()
                    .HasColumnName("parentpath");

                entity.Property(e => e.Schemafilename)
                    .IsRequired()
                    .HasColumnName("schemafilename");

                entity.Property(e => e.Sdscomversion)
                    .IsRequired()
                    .HasColumnName("sdscomversion");
            });

            //modelBuilder.Entity<Facetphraselink>(entity =>
            //{
            //    entity.ToTable("facetphraselink");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Entityid).HasColumnName("entityid");

            //    entity.Property(e => e.Facetid).HasColumnName("facetid");

            //    entity.Property(e => e.Phraseid).HasColumnName("phraseid");

            //    entity.Property(e => e.Startdatestamp).HasColumnName("startdatestamp");

            //    entity.Property(e => e.Stopdatestamp).HasColumnName("stopdatestamp");

            //    entity.Property(e => e.Userid).HasColumnName("userid");
            //});

            modelBuilder.Entity<FacetPhraseLink>(entity =>
            {
                entity.ToTable("facet_phrase_link");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.FacetId).HasColumnName("facet_id");

                entity.Property(e => e.PhraseId).HasColumnName("phrase_id");

                entity.Property(e => e.StartDateStamp).HasColumnName("start_date_stamp");

                entity.Property(e => e.StopDateStamp).HasColumnName("stop_date_stamp");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            //modelBuilder.Entity<Facetrestriction>(entity =>
            //{
            //    entity.ToTable("facetrestriction");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Enumerations).HasColumnName("enumerations");

            //    entity.Property(e => e.Facetid).HasColumnName("facetid");

            //    entity.Property(e => e.Islist).HasColumnName("islist");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasColumnName("name");

            //    entity.Property(e => e.Otherinfo).HasColumnName("otherinfo");

            //    entity.Property(e => e.Regularexpressionpattern).HasColumnName("regularexpressionpattern");
            //});

            modelBuilder.Entity<FacetRestriction>(entity =>
            {
                entity.ToTable("facet_restriction");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Enumerations).HasColumnName("enumerations");

                entity.Property(e => e.FacetId).HasColumnName("facet_id");

                entity.Property(e => e.IsList).HasColumnName("is_list");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.OtherInfo).HasColumnName("other_info");

                entity.Property(e => e.RegularExpressionPattern).HasColumnName("regular_expression_pattern");
            });

            //modelBuilder.Entity<Facetvalue>(entity =>
            //{
            //    entity.ToTable("facetvalue");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Data)
            //        .IsRequired()
            //        .HasColumnName("data");

            //    entity.Property(e => e.Entityid).HasColumnName("entityid");

            //    entity.Property(e => e.Facetid).HasColumnName("facetid");

            //    entity.Property(e => e.Startdatestamp).HasColumnName("startdatestamp");

            //    entity.Property(e => e.Stopdatestamp).HasColumnName("stopdatestamp");

            //    entity.Property(e => e.Userid).HasColumnName("userid");
            //});

            modelBuilder.Entity<FacetValue>(entity =>
            {
                entity.ToTable("facet_value");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data");

                entity.Property(e => e.EntityId).HasColumnName("entity_id");

                entity.Property(e => e.FacetId).HasColumnName("facet_id");

                entity.Property(e => e.StartDateStamp).HasColumnName("start_date_stamp");

                entity.Property(e => e.StopDateStamp).HasColumnName("stop_date_stamp");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<Phrases>(entity =>
            {
                entity.HasKey(e => e.StructureCode);

                entity.ToTable("phrases");

                entity.Property(e => e.StructureCode)
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

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreateDate).HasColumnName("create_date");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.FirstName).HasColumnName("first_name");

                entity.Property(e => e.LastName).HasColumnName("last_name");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.UpdateDate).HasColumnName("update_date");

                entity.Property(e => e.UserName).HasColumnName("user_name");
            });

            modelBuilder.Entity<Validationmessage>(entity =>
            {
                entity.ToTable("validationmessage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Facetid).HasColumnName("facetid");
            });

            modelBuilder.Entity<ValidationMessage>(entity =>
            {
                entity.ToTable("validation_message");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FacetId).HasColumnName("facet_id");
            });
        }
    }
}
