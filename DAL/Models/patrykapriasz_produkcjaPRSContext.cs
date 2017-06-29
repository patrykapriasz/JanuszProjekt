using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class patrykapriasz_produkcjaPRSContext : DbContext
    {
        public virtual DbSet<CzynnosciTab> CzynnosciTab { get; set; }
        public virtual DbSet<Grafik> Grafik { get; set; }
        public virtual DbSet<Instalacja> Instalacja { get; set; }
        public virtual DbSet<InstalacjaTab> InstalacjaTab { get; set; }
        public virtual DbSet<KolumnyTab> KolumnyTab { get; set; }
        public virtual DbSet<LogiTab> LogiTab { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<PracaTab> PracaTab { get; set; }
        public virtual DbSet<Pracownicy> Pracownicy { get; set; }
        public virtual DbSet<UserTable> UserTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=mssql.webio.pl,2401;Initial Catalog=patrykapriasz_produkcjaPRS;User ID=patrykapriasz_patryk;Password=Milorad1!");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CzynnosciTab>(entity =>
            {
                entity.ToTable("Czynnosci_tab");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nazwa).HasColumnType("varchar(50)");

                entity.Property(e => e.Opis).HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<Grafik>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data).HasColumnType("nchar(10)");

                entity.HasOne(d => d.PracownikNavigation)
                    .WithMany(p => p.Grafik)
                    .HasForeignKey(d => d.Pracownik)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Grafik_Pracownicy");
            });

            modelBuilder.Entity<Instalacja>(entity =>
            {
                entity.Property(e => e.BufWyparki).HasColumnName("Buf_wyparki");

                entity.Property(e => e.BuforKolumna).HasColumnName("Bufor_kolumna");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.Gotowy1).HasColumnName("Gotowy_1");

                entity.Property(e => e.Gotowy2).HasColumnName("Gotowy_2");

                entity.Property(e => e.Kat1).HasColumnName("Kat_1");

                entity.Property(e => e.Kat2).HasColumnName("Kat_2");

                entity.Property(e => e.Neutralizator1).HasColumnName("Neutralizator_1");

                entity.Property(e => e.Neutralizator2).HasColumnName("Neutralizator_2");

                entity.Property(e => e.P1).HasColumnName("P_1");

                entity.Property(e => e.P2).HasColumnName("P_2");

                entity.Property(e => e.P3).HasColumnName("P_3");

                entity.Property(e => e.P4).HasColumnName("P_4");

                entity.Property(e => e.R1).HasColumnName("R_1");

                entity.Property(e => e.R2).HasColumnName("R_2");

                entity.Property(e => e.R3).HasColumnName("R_3");

                entity.Property(e => e.R4).HasColumnName("R_4");

                entity.Property(e => e.R5).HasColumnName("R_5");

                entity.Property(e => e.R6).HasColumnName("R_6");

                entity.Property(e => e.Wkt).HasColumnName("WKT");

                entity.Property(e => e.Wlewa1).HasColumnName("WLewa_1");

                entity.Property(e => e.Wlewa2).HasColumnName("WLewa_2");

                entity.Property(e => e.WodaChlodzenie).HasColumnName("Woda_chlodzenie");

                entity.Property(e => e.Wprawa1).HasColumnName("WPrawa_1");

                entity.Property(e => e.Wprawa2).HasColumnName("WPrawa_2");

                entity.Property(e => e.ZakwasGliceryny1).HasColumnName("Zakwas_gliceryny_1");

                entity.Property(e => e.ZakwasGliceryny2).HasColumnName("Zakwas_gliceryny_2");
            });

            modelBuilder.Entity<InstalacjaTab>(entity =>
            {
                entity.ToTable("Instalacja_tab");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Nazwa).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<KolumnyTab>(entity =>
            {
                entity.ToTable("Kolumny_tab");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.TempDestyl).HasColumnName("Temp_destyl");

                entity.Property(e => e.TempRektDol).HasColumnName("Temp_rektDol");

                entity.Property(e => e.TempRektGora).HasColumnName("Temp_rektGora");

                entity.Property(e => e.TempSkraplacz).HasColumnName("Temp_skraplacz");
            });

            modelBuilder.Entity<LogiTab>(entity =>
            {
                entity.ToTable("Logi_tab");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.HasOne(d => d.CzynnoscNavigation)
                    .WithMany(p => p.LogiTab)
                    .HasForeignKey(d => d.Czynnosc)
                    .HasConstraintName("FK_Logi_tab_Praca_tab");

                entity.HasOne(d => d.UrzadzenieNavigation)
                    .WithMany(p => p.LogiTab)
                    .HasForeignKey(d => d.Urzadzenie)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Logi_tab_Instalacja_tab");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<PracaTab>(entity =>
            {
                entity.ToTable("Praca_tab");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Data).HasColumnType("datetime");

                entity.Property(e => e.TempDestyl).HasColumnName("Temp_destyl");

                entity.Property(e => e.TempRektDol).HasColumnName("Temp_rektDol");

                entity.Property(e => e.TempRektGora).HasColumnName("Temp_rektGora");

                entity.Property(e => e.TempSkraplacz).HasColumnName("Temp_skraplacz");
            });

            modelBuilder.Entity<Pracownicy>(entity =>
            {
                entity.Property(e => e.Kontakt).HasColumnType("varchar(50)");

                entity.Property(e => e.Nazwisko).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<UserTable>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_user_table");

                entity.ToTable("user_table");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserEmail)
                    .HasColumnName("user_email")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.UserPassword)
                    .HasColumnName("user_password")
                    .HasColumnType("varchar(50)");
            });
        }
    }
}