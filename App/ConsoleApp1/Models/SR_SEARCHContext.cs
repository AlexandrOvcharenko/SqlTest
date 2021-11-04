using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ConsoleApp1.Models
{
    public partial class SR_SEARCHContext : DbContext
    {
        public SR_SEARCHContext()
        {
        }

        public SR_SEARCHContext(DbContextOptions<SR_SEARCHContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SrDirectoryCountry> SrDirectoryCountries { get; set; }
        public virtual DbSet<SrDirectoryPort> SrDirectoryPorts { get; set; }
        public virtual DbSet<SrDirectoryRank> SrDirectoryRanks { get; set; }
        public virtual DbSet<SrDirectoryStatusdocument> SrDirectoryStatusdocuments { get; set; }
        public virtual DbSet<SrDirectoryTypedocument> SrDirectoryTypedocuments { get; set; }
        public virtual DbSet<SrQdServiceInfo> SrQdServiceInfos { get; set; }
        public virtual DbSet<SrQualifDoc> SrQualifDocs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = Environment.GetEnvironmentVariable("db");
                var connectionStringPostgres = Environment.GetEnvironmentVariable("dbP");
                
                //optionsBuilder.UseNpgsql("User ID=postgres;Password=postgres;Host=localhost;Port=5432;Database=consoleTest;Pooling=true;", builder =>
                //{
                //    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
                //});
                //optionsBuilder.UseNpgsql("User ID=postgres;Password=postgres;Host=postgres;Port=5432;Database=consoleTest;Pooling=true;");
                Console.WriteLine("Connection string is");
                Console.WriteLine(connectionString);
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "");

            modelBuilder.Entity<SrDirectoryCountry>(entity =>
            {
                entity.ToTable("SR_directory_country");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .HasColumnName("value")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.ValueAbbr)
                    .HasMaxLength(255)
                    .HasColumnName("value_abbr")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.ValueEng)
                    .HasMaxLength(255)
                    .HasColumnName("value_eng")
                    .UseCollation("Ukrainian_CS_AS");
            });

            modelBuilder.Entity<SrDirectoryPort>(entity =>
            {
                entity.ToTable("SR_directory_port");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CodePort)
                    .HasMaxLength(255)
                    .HasColumnName("code_port")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.IsDisable).HasColumnName("is_disable");

                entity.Property(e => e.NameEng)
                    .HasMaxLength(255)
                    .HasColumnName("name_eng")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.NameUkr)
                    .HasMaxLength(255)
                    .HasColumnName("name_ukr")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.PositionCapitanEng)
                    .HasMaxLength(255)
                    .HasColumnName("position_capitan_eng")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.PositionCapitanUkr)
                    .HasMaxLength(255)
                    .HasColumnName("position_capitan_ukr")
                    .UseCollation("Ukrainian_CS_AS");
            });

            modelBuilder.Entity<SrDirectoryRank>(entity =>
            {
                entity.ToTable("SR_directory_rank");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DirectionId).HasColumnName("direction_id");

                entity.Property(e => e.IsDisable).HasColumnName("is_disable");

                entity.Property(e => e.IsDkk).HasColumnName("is_dkk");

                entity.Property(e => e.NameEng)
                    .HasMaxLength(255)
                    .HasColumnName("name_eng")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.NameUkr)
                    .HasMaxLength(255)
                    .HasColumnName("name_ukr")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.TypeDocumentId).HasColumnName("type_document_id");

                entity.Property(e => e.TypeRankId).HasColumnName("type_rank_id");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(255)
                    .HasColumnName("uuid")
                    .UseCollation("Ukrainian_CS_AS");
            });

            modelBuilder.Entity<SrDirectoryStatusdocument>(entity =>
            {
                entity.ToTable("SR_directory_statusdocument");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CanUserChange).HasColumnName("can_user_change");

                entity.Property(e => e.ForService)
                    .HasMaxLength(255)
                    .HasColumnName("for_service")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.IsDisable).HasColumnName("is_disable");

                entity.Property(e => e.NameEng)
                    .HasMaxLength(255)
                    .HasColumnName("name_eng")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.NameUkr)
                    .HasMaxLength(255)
                    .HasColumnName("name_ukr")
                    .UseCollation("Ukrainian_CS_AS");
            });

            modelBuilder.Entity<SrDirectoryTypedocument>(entity =>
            {
                entity.ToTable("SR_directory_typedocument");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.ForService)
                    .HasMaxLength(255)
                    .HasColumnName("for_service")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.IsDisable).HasColumnName("is_disable");

                entity.Property(e => e.NameEng)
                    .HasMaxLength(255)
                    .HasColumnName("name_eng")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.NameUkr)
                    .HasMaxLength(255)
                    .HasColumnName("name_ukr")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<SrQdServiceInfo>(entity =>
            {
                entity.ToTable("SR_QD_SERVICE_INFO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Link)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LINK")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.MrId).HasColumnName("MR_ID");

                entity.Property(e => e.PrId).HasColumnName("PR_ID");

                entity.Property(e => e.QdId).HasColumnName("QD_ID");

                entity.HasOne(d => d.Qd)
                    .WithMany(p => p.SrQdServiceInfos)
                    .HasForeignKey(d => d.QdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SR_QD_SERVICE_INFO_SR_QUALIF_DOCS");
            });

            modelBuilder.Entity<SrQualifDoc>(entity =>
            {
                entity.ToTable("SR_QUALIF_DOCS");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID")
                    .HasComment("Идентификатор записи");

                entity.Property(e => e.DStatus)
                    .HasColumnName("D_STATUS")
                    .HasComment("Статус документа");

                entity.Property(e => e.DType)
                    .HasColumnName("D_TYPE")
                    .HasComment("Тип документа");

                entity.Property(e => e.DnNumber)
                    .HasColumnName("DN_NUMBER")
                    .HasComment("Составной номер документа. Номер документа");

                entity.Property(e => e.DnPort)
                    .HasColumnName("DN_PORT")
                    .HasComment("Составной номер документа. Код порта выдачи документа");

                entity.Property(e => e.DnYaer)
                    .HasColumnName("DN_YAER")
                    .HasComment("Составной номер документа. Год выдачи документа");

                entity.Property(e => e.DtIssue)
                    .HasColumnType("date")
                    .HasColumnName("DT_ISSUE")
                    .HasComment("Дата выдачи документа");

                entity.Property(e => e.PortCapitan)
                    .HasColumnName("PORT_CAPITAN")
                    .HasComment("Капитан порта выдавшего документ");

                entity.Property(e => e.Rank)
                    .HasColumnName("RANK")
                    .HasComment("Звание");

                entity.Property(e => e.SbLeter)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SB_LETER")
                    .HasComment("Серия бланка строгой отчетности ")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.SbNumber)
                    .HasColumnName("SB_NUMBER")
                    .HasComment("Номер бланка строгой отчетности");

                entity.Property(e => e.SfCs)
                    .HasColumnName("SF_CS")
                    .HasComment("Гражданство");

                entity.Property(e => e.SfDob)
                    .HasColumnType("date")
                    .HasColumnName("SF_DOB")
                    .HasComment("Дата рождения");

                entity.Property(e => e.SfFn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SF_FN")
                    .HasComment("Seafarer first name")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.SfLn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SF_LN")
                    .HasComment("Seafarer last name")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.SfName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SF_NAME")
                    .HasComment("Имя моряка (укр.)")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.SfPatronymic)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SF_PATRONYMIC")
                    .HasComment("Отчество (укр.)")
                    .UseCollation("Ukrainian_CS_AS");

                entity.Property(e => e.SfSurname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SF_SURNAME")
                    .HasComment("Фамилия моряка (укр.)")
                    .UseCollation("Ukrainian_CS_AS");

                entity.HasOne(d => d.DStatusNavigation)
                    .WithMany(p => p.SrQualifDocs)
                    .HasForeignKey(d => d.DStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SR_QUALIF_DOCS_SR_directory_statusdocument");

                entity.HasOne(d => d.DTypeNavigation)
                    .WithMany(p => p.SrQualifDocs)
                    .HasForeignKey(d => d.DType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SR_QUALIF_DOCS_SR_directory_typedocument");

                entity.HasOne(d => d.DnPortNavigation)
                    .WithMany(p => p.SrQualifDocs)
                    .HasForeignKey(d => d.DnPort)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SR_QUALIF_DOCS_SR_directory_port");

                entity.HasOne(d => d.RankNavigation)
                    .WithMany(p => p.SrQualifDocs)
                    .HasForeignKey(d => d.Rank)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SR_QUALIF_DOCS_SR_directory_rank");

                entity.HasOne(d => d.SfCsNavigation)
                    .WithMany(p => p.SrQualifDocs)
                    .HasForeignKey(d => d.SfCs)
                    .HasConstraintName("FK_SR_QUALIF_DOCS_SR_directory_country");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
