using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Library.DataAccessLayer.Models
{
    public partial class TestContext : DbContext
    {
        public TestContext()
        {
        }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbNkdientu> TbNkdientus { get; set; } = null!;
        public virtual DbSet<TbNkthuyngan> TbNkthuyngans { get; set; } = null!;
        public virtual DbSet<Tbcanban> Tbcanbans { get; set; } = null!;
        public virtual DbSet<Tbcandium> Tbcandia { get; set; } = null!;
        public virtual DbSet<Tbcankythuat> Tbcankythuats { get; set; } = null!;
        public virtual DbSet<Tbcankythuat1> Tbcankythuat1s { get; set; } = null!;
        public virtual DbSet<Tbcanphantich> Tbcanphantiches { get; set; } = null!;
        public virtual DbSet<Tbdienapke> Tbdienapkes { get; set; } = null!;
        public virtual DbSet<Tbdientim> Tbdientims { get; set; } = null!;
        public virtual DbSet<Tbkiemdinh> Tbkiemdinhs { get; set; } = null!;
        public virtual DbSet<Tbsscan> Tbsscans { get; set; } = null!;
        public virtual DbSet<Tbthongtincan> Tbthongtincans { get; set; } = null!;
        public virtual DbSet<Tbthongtinkiemdinh> Tbthongtinkiemdinhs { get; set; } = null!;
        public virtual DbSet<Trubom> Truboms { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbNkdientu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbNKdientu");

                entity.Property(e => e.Capchinhxac).HasMaxLength(100);

                entity.Property(e => e.Chedokiemdinh).HasMaxLength(100);

                entity.Property(e => e.Clcc)
                    .HasMaxLength(100)
                    .HasColumnName("CLCC");

                entity.Property(e => e.Cllnda1)
                    .HasMaxLength(100)
                    .HasColumnName("cllnda1");

                entity.Property(e => e.Cllnda2)
                    .HasMaxLength(100)
                    .HasColumnName("cllnda2");

                entity.Property(e => e.Cllnda3)
                    .HasMaxLength(100)
                    .HasColumnName("cllnda3");

                entity.Property(e => e.Cllndl1)
                    .HasMaxLength(100)
                    .HasColumnName("cllndl1");

                entity.Property(e => e.Cllndl2)
                    .HasMaxLength(100)
                    .HasColumnName("cllndl2");

                entity.Property(e => e.Cllndl3)
                    .HasMaxLength(100)
                    .HasColumnName("cllndl3");

                entity.Property(e => e.Cososd).HasMaxLength(100);

                entity.Property(e => e.Dannn1)
                    .HasMaxLength(100)
                    .HasColumnName("dannn1");

                entity.Property(e => e.Dannn2)
                    .HasMaxLength(100)
                    .HasColumnName("dannn2");

                entity.Property(e => e.Dannn3)
                    .HasMaxLength(100)
                    .HasColumnName("dannn3");

                entity.Property(e => e.Diachisd).HasMaxLength(100);

                entity.Property(e => e.Diadiemth).HasMaxLength(100);

                entity.Property(e => e.Doam).HasMaxLength(100);

                entity.Property(e => e.I1da1)
                    .HasMaxLength(100)
                    .HasColumnName("i1da1");

                entity.Property(e => e.I1da2)
                    .HasMaxLength(100)
                    .HasColumnName("i1da2");

                entity.Property(e => e.I1da3)
                    .HasMaxLength(100)
                    .HasColumnName("i1da3");

                entity.Property(e => e.I1dl1)
                    .HasMaxLength(100)
                    .HasColumnName("i1dl1");

                entity.Property(e => e.I1dl2)
                    .HasMaxLength(100)
                    .HasColumnName("i1dl2");

                entity.Property(e => e.I1dl3)
                    .HasMaxLength(100)
                    .HasColumnName("i1dl3");

                entity.Property(e => e.I2da1)
                    .HasMaxLength(100)
                    .HasColumnName("i2da1");

                entity.Property(e => e.I2da2)
                    .HasMaxLength(100)
                    .HasColumnName("i2da2");

                entity.Property(e => e.I2da3)
                    .HasMaxLength(100)
                    .HasColumnName("i2da3");

                entity.Property(e => e.I2dl1)
                    .HasMaxLength(100)
                    .HasColumnName("i2dl1");

                entity.Property(e => e.I2dl2)
                    .HasMaxLength(100)
                    .HasColumnName("i2dl2");

                entity.Property(e => e.I2dl3)
                    .HasMaxLength(100)
                    .HasColumnName("i2dl3");

                entity.Property(e => e.Kieu).HasMaxLength(100);

                entity.Property(e => e.Maqd).HasMaxLength(100);

                entity.Property(e => e.Namsx).HasMaxLength(100);

                entity.Property(e => e.Ngay).HasMaxLength(100);

                entity.Property(e => e.Nguoithuchien).HasMaxLength(100);

                entity.Property(e => e.Nhietdo).HasMaxLength(100);

                entity.Property(e => e.Nuocsx).HasMaxLength(100);

                entity.Property(e => e.Phamvido).HasMaxLength(100);

                entity.Property(e => e.Ppthuchien)
                    .HasMaxLength(100)
                    .HasColumnName("PPthuchien");

                entity.Property(e => e.So).HasMaxLength(100);

                entity.Property(e => e.Sscpda1)
                    .HasMaxLength(100)
                    .HasColumnName("sscpda1");

                entity.Property(e => e.Sscpda2)
                    .HasMaxLength(100)
                    .HasColumnName("sscpda2");

                entity.Property(e => e.Sscpda3)
                    .HasMaxLength(100)
                    .HasColumnName("sscpda3");

                entity.Property(e => e.Sscpdl1)
                    .HasMaxLength(100)
                    .HasColumnName("sscpdl1");

                entity.Property(e => e.Sscpdl2)
                    .HasMaxLength(100)
                    .HasColumnName("sscpdl2");

                entity.Property(e => e.Sscpdl3)
                    .HasMaxLength(100)
                    .HasColumnName("sscpdl3");

                entity.Property(e => e.Tenpt).HasMaxLength(100);
            });

            modelBuilder.Entity<TbNkthuyngan>(entity =>
            {
                entity.HasKey(e => e.So);

                entity.ToTable("tbNKthuyngan");

                entity.Property(e => e.Capchinhxac).HasMaxLength(100);

                entity.Property(e => e.Chedokiemdinh).HasMaxLength(100);

                entity.Property(e => e.Clcc)
                    .HasMaxLength(100)
                    .HasColumnName("CLCC");

                entity.Property(e => e.Cllnmax)
                    .HasMaxLength(100)
                    .HasColumnName("cllnmax");

                entity.Property(e => e.Cllnmin)
                    .HasMaxLength(100)
                    .HasColumnName("cllnmin");

                entity.Property(e => e.Cososd).HasMaxLength(100);

                entity.Property(e => e.Diachisd).HasMaxLength(100);

                entity.Property(e => e.Diadiemth).HasMaxLength(100);

                entity.Property(e => e.Dk)
                    .HasMaxLength(100)
                    .HasColumnName("dk");

                entity.Property(e => e.Doam).HasMaxLength(100);

                entity.Property(e => e.I1max)
                    .HasMaxLength(100)
                    .HasColumnName("i1max");

                entity.Property(e => e.I1min)
                    .HasMaxLength(100)
                    .HasColumnName("i1min");

                entity.Property(e => e.I2max)
                    .HasMaxLength(100)
                    .HasColumnName("i2max");

                entity.Property(e => e.I2min)
                    .HasMaxLength(100)
                    .HasColumnName("i2min");

                entity.Property(e => e.Kieu).HasMaxLength(100);

                entity.Property(e => e.Kldoluong).HasColumnName("kldoluong");

                entity.Property(e => e.Klqtnhiet).HasColumnName("klqtnhiet");

                entity.Property(e => e.Maqd).HasMaxLength(100);

                entity.Property(e => e.Namsx).HasMaxLength(100);

                entity.Property(e => e.Ngay).HasMaxLength(100);

                entity.Property(e => e.Nguoithuchien).HasMaxLength(100);

                entity.Property(e => e.Nhietdo).HasMaxLength(100);

                entity.Property(e => e.Nuocsx).HasMaxLength(100);

                entity.Property(e => e.Phamvido).HasMaxLength(100);

                entity.Property(e => e.Ppthuchien)
                    .HasMaxLength(100)
                    .HasColumnName("PPthuchien");

                entity.Property(e => e.So).HasMaxLength(100);

                entity.Property(e => e.Sscpmax)
                    .HasMaxLength(100)
                    .HasColumnName("sscpmax");

                entity.Property(e => e.Sscpmin)
                    .HasMaxLength(100)
                    .HasColumnName("sscpmin");

                entity.Property(e => e.T1)
                    .HasMaxLength(100)
                    .HasColumnName("t1");

                entity.Property(e => e.T2)
                    .HasMaxLength(100)
                    .HasColumnName("t2");

                entity.Property(e => e.T2p)
                    .HasMaxLength(100)
                    .HasColumnName("t2p");

                entity.Property(e => e.T2pp)
                    .HasMaxLength(100)
                    .HasColumnName("t2pp");

                entity.Property(e => e.T2pptt2)
                    .HasMaxLength(100)
                    .HasColumnName("t2pptt2");

                entity.Property(e => e.T2pptt2p)
                    .HasMaxLength(100)
                    .HasColumnName("t2pptt2p");

                entity.Property(e => e.T2ptt2)
                    .HasMaxLength(100)
                    .HasColumnName("t2ptt2");

                entity.Property(e => e.Tenpt).HasMaxLength(100);
            });

            modelBuilder.Entity<Tbcanban>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbcanban");

                entity.Property(e => e.A1)
                    .HasMaxLength(100)
                    .HasColumnName("a1");

                entity.Property(e => e.A10)
                    .HasMaxLength(100)
                    .HasColumnName("a10");

                entity.Property(e => e.A11)
                    .HasMaxLength(100)
                    .HasColumnName("a11");

                entity.Property(e => e.A12)
                    .HasMaxLength(100)
                    .HasColumnName("a12");

                entity.Property(e => e.A13)
                    .HasMaxLength(100)
                    .HasColumnName("a13");

                entity.Property(e => e.A14)
                    .HasMaxLength(100)
                    .HasColumnName("a14");

                entity.Property(e => e.A15)
                    .HasMaxLength(100)
                    .HasColumnName("a15");

                entity.Property(e => e.A16)
                    .HasMaxLength(100)
                    .HasColumnName("a16");

                entity.Property(e => e.A17)
                    .HasMaxLength(100)
                    .HasColumnName("a17");

                entity.Property(e => e.A18)
                    .HasMaxLength(100)
                    .HasColumnName("a18");

                entity.Property(e => e.A19)
                    .HasMaxLength(100)
                    .HasColumnName("a19");

                entity.Property(e => e.A2)
                    .HasMaxLength(100)
                    .HasColumnName("a2");

                entity.Property(e => e.A20)
                    .HasMaxLength(100)
                    .HasColumnName("a20");

                entity.Property(e => e.A3)
                    .HasMaxLength(100)
                    .HasColumnName("a3");

                entity.Property(e => e.A4)
                    .HasMaxLength(100)
                    .HasColumnName("a4");

                entity.Property(e => e.A5)
                    .HasMaxLength(100)
                    .HasColumnName("a5");

                entity.Property(e => e.A6)
                    .HasMaxLength(100)
                    .HasColumnName("a6");

                entity.Property(e => e.A7)
                    .HasMaxLength(100)
                    .HasColumnName("a7");

                entity.Property(e => e.A8)
                    .HasMaxLength(100)
                    .HasColumnName("a8");

                entity.Property(e => e.A9)
                    .HasMaxLength(100)
                    .HasColumnName("a9");

                entity.Property(e => e.B1)
                    .HasMaxLength(100)
                    .HasColumnName("b1");

                entity.Property(e => e.B10)
                    .HasMaxLength(100)
                    .HasColumnName("b10");

                entity.Property(e => e.B11)
                    .HasMaxLength(100)
                    .HasColumnName("b11");

                entity.Property(e => e.B12)
                    .HasMaxLength(100)
                    .HasColumnName("b12");

                entity.Property(e => e.B13)
                    .HasMaxLength(100)
                    .HasColumnName("b13");

                entity.Property(e => e.B14)
                    .HasMaxLength(100)
                    .HasColumnName("b14");

                entity.Property(e => e.B15)
                    .HasMaxLength(100)
                    .HasColumnName("b15");

                entity.Property(e => e.B16)
                    .HasMaxLength(100)
                    .HasColumnName("b16");

                entity.Property(e => e.B17)
                    .HasMaxLength(100)
                    .HasColumnName("b17");

                entity.Property(e => e.B18)
                    .HasMaxLength(100)
                    .HasColumnName("b18");

                entity.Property(e => e.B19)
                    .HasMaxLength(100)
                    .HasColumnName("b19");

                entity.Property(e => e.B2)
                    .HasMaxLength(100)
                    .HasColumnName("b2");

                entity.Property(e => e.B20)
                    .HasMaxLength(100)
                    .HasColumnName("b20");

                entity.Property(e => e.B3)
                    .HasMaxLength(100)
                    .HasColumnName("b3");

                entity.Property(e => e.B4)
                    .HasMaxLength(100)
                    .HasColumnName("b4");

                entity.Property(e => e.B5)
                    .HasMaxLength(100)
                    .HasColumnName("b5");

                entity.Property(e => e.B6)
                    .HasMaxLength(100)
                    .HasColumnName("b6");

                entity.Property(e => e.B7)
                    .HasMaxLength(100)
                    .HasColumnName("b7");

                entity.Property(e => e.B8)
                    .HasMaxLength(100)
                    .HasColumnName("b8");

                entity.Property(e => e.B9)
                    .HasMaxLength(100)
                    .HasColumnName("b9");

                entity.Property(e => e.C1)
                    .HasMaxLength(100)
                    .HasColumnName("c1");

                entity.Property(e => e.C10)
                    .HasMaxLength(100)
                    .HasColumnName("c10");

                entity.Property(e => e.C11)
                    .HasMaxLength(100)
                    .HasColumnName("c11");

                entity.Property(e => e.C12)
                    .HasMaxLength(100)
                    .HasColumnName("c12");

                entity.Property(e => e.C13)
                    .HasMaxLength(100)
                    .HasColumnName("c13");

                entity.Property(e => e.C14)
                    .HasMaxLength(100)
                    .HasColumnName("c14");

                entity.Property(e => e.C15)
                    .HasMaxLength(100)
                    .HasColumnName("c15");

                entity.Property(e => e.C16)
                    .HasMaxLength(100)
                    .HasColumnName("c16");

                entity.Property(e => e.C17)
                    .HasMaxLength(100)
                    .HasColumnName("c17");

                entity.Property(e => e.C18)
                    .HasMaxLength(100)
                    .HasColumnName("c18");

                entity.Property(e => e.C19)
                    .HasMaxLength(100)
                    .HasColumnName("c19");

                entity.Property(e => e.C2)
                    .HasMaxLength(100)
                    .HasColumnName("c2");

                entity.Property(e => e.C20)
                    .HasMaxLength(100)
                    .HasColumnName("c20");

                entity.Property(e => e.C3)
                    .HasMaxLength(100)
                    .HasColumnName("c3");

                entity.Property(e => e.C4)
                    .HasMaxLength(100)
                    .HasColumnName("c4");

                entity.Property(e => e.C5)
                    .HasMaxLength(100)
                    .HasColumnName("c5");

                entity.Property(e => e.C6)
                    .HasMaxLength(100)
                    .HasColumnName("c6");

                entity.Property(e => e.C7)
                    .HasMaxLength(100)
                    .HasColumnName("c7");

                entity.Property(e => e.C8)
                    .HasMaxLength(100)
                    .HasColumnName("c8");

                entity.Property(e => e.C9)
                    .HasMaxLength(100)
                    .HasColumnName("c9");

                entity.Property(e => e.Capchinhxac).HasMaxLength(100);

                entity.Property(e => e.Chedokd).HasMaxLength(100);

                entity.Property(e => e.Chuantb).HasMaxLength(100);

                entity.Property(e => e.D1)
                    .HasMaxLength(100)
                    .HasColumnName("d1");

                entity.Property(e => e.D2)
                    .HasMaxLength(100)
                    .HasColumnName("d2");

                entity.Property(e => e.D3)
                    .HasMaxLength(100)
                    .HasColumnName("d3");

                entity.Property(e => e.D4)
                    .HasMaxLength(100)
                    .HasColumnName("d4");

                entity.Property(e => e.Delta1lt)
                    .HasMaxLength(100)
                    .HasColumnName("delta1lt");

                entity.Property(e => e.Delta1maxll)
                    .HasMaxLength(100)
                    .HasColumnName("delta1maxll");

                entity.Property(e => e.Delta1nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("delta1nuamax");

                entity.Property(e => e.Delta2lt)
                    .HasMaxLength(100)
                    .HasColumnName("delta2lt");

                entity.Property(e => e.Delta2maxll)
                    .HasMaxLength(100)
                    .HasColumnName("delta2maxll");

                entity.Property(e => e.Delta2nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("delta2nuamax");

                entity.Property(e => e.Delta3lt)
                    .HasMaxLength(100)
                    .HasColumnName("delta3lt");

                entity.Property(e => e.Delta3maxll)
                    .HasMaxLength(100)
                    .HasColumnName("delta3maxll");

                entity.Property(e => e.Delta3nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("delta3nuamax");

                entity.Property(e => e.Delta4lt)
                    .HasMaxLength(100)
                    .HasColumnName("delta4lt");

                entity.Property(e => e.Delta4maxll)
                    .HasMaxLength(100)
                    .HasColumnName("delta4maxll");

                entity.Property(e => e.Delta4nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("delta4nuamax");

                entity.Property(e => e.Delta5maxll)
                    .HasMaxLength(100)
                    .HasColumnName("delta5maxll");

                entity.Property(e => e.Delta5nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("delta5nuamax");

                entity.Property(e => e.Delta6maxll)
                    .HasMaxLength(100)
                    .HasColumnName("delta6maxll");

                entity.Property(e => e.Delta6nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("delta6nuamax");

                entity.Property(e => e.Deltaglt)
                    .HasMaxLength(100)
                    .HasColumnName("deltaglt");

                entity.Property(e => e.Diachisd).HasMaxLength(100);

                entity.Property(e => e.Dkmt).HasMaxLength(100);

                entity.Property(e => e.Donvisd).HasMaxLength(100);

                entity.Property(e => e.E1)
                    .HasMaxLength(100)
                    .HasColumnName("e1");

                entity.Property(e => e.E2)
                    .HasMaxLength(100)
                    .HasColumnName("e2");

                entity.Property(e => e.E3)
                    .HasMaxLength(100)
                    .HasColumnName("e3");

                entity.Property(e => e.E4)
                    .HasMaxLength(100)
                    .HasColumnName("e4");

                entity.Property(e => e.Ec1lt)
                    .HasMaxLength(100)
                    .HasColumnName("ec1lt");

                entity.Property(e => e.Ec2lt)
                    .HasMaxLength(100)
                    .HasColumnName("ec2lt");

                entity.Property(e => e.Ec3lt)
                    .HasMaxLength(100)
                    .HasColumnName("ec3lt");

                entity.Property(e => e.Ec4lt)
                    .HasMaxLength(100)
                    .HasColumnName("ec4lt");

                entity.Property(e => e.Ecglt)
                    .HasMaxLength(100)
                    .HasColumnName("ecglt");

                entity.Property(e => e.G1)
                    .HasMaxLength(100)
                    .HasColumnName("g1");

                entity.Property(e => e.G10)
                    .HasMaxLength(100)
                    .HasColumnName("g10");

                entity.Property(e => e.G11)
                    .HasMaxLength(100)
                    .HasColumnName("g11");

                entity.Property(e => e.G12)
                    .HasMaxLength(100)
                    .HasColumnName("g12");

                entity.Property(e => e.G13)
                    .HasMaxLength(100)
                    .HasColumnName("g13");

                entity.Property(e => e.G14)
                    .HasMaxLength(100)
                    .HasColumnName("g14");

                entity.Property(e => e.G15)
                    .HasMaxLength(100)
                    .HasColumnName("g15");

                entity.Property(e => e.G16)
                    .HasMaxLength(100)
                    .HasColumnName("g16");

                entity.Property(e => e.G17)
                    .HasMaxLength(100)
                    .HasColumnName("g17");

                entity.Property(e => e.G18)
                    .HasMaxLength(100)
                    .HasColumnName("g18");

                entity.Property(e => e.G19)
                    .HasMaxLength(100)
                    .HasColumnName("g19");

                entity.Property(e => e.G2)
                    .HasMaxLength(100)
                    .HasColumnName("g2");

                entity.Property(e => e.G20)
                    .HasMaxLength(100)
                    .HasColumnName("g20");

                entity.Property(e => e.G3)
                    .HasMaxLength(100)
                    .HasColumnName("g3");

                entity.Property(e => e.G4)
                    .HasMaxLength(100)
                    .HasColumnName("g4");

                entity.Property(e => e.G5)
                    .HasMaxLength(100)
                    .HasColumnName("g5");

                entity.Property(e => e.G6)
                    .HasMaxLength(100)
                    .HasColumnName("g6");

                entity.Property(e => e.G7)
                    .HasMaxLength(100)
                    .HasColumnName("g7");

                entity.Property(e => e.G8)
                    .HasMaxLength(100)
                    .HasColumnName("g8");

                entity.Property(e => e.G9)
                    .HasMaxLength(100)
                    .HasColumnName("g9");

                entity.Property(e => e.Glt)
                    .HasMaxLength(100)
                    .HasColumnName("glt");

                entity.Property(e => e.Gmucmin)
                    .HasMaxLength(100)
                    .HasColumnName("gmucmin");

                entity.Property(e => e.H1)
                    .HasMaxLength(100)
                    .HasColumnName("h1");

                entity.Property(e => e.H10)
                    .HasMaxLength(100)
                    .HasColumnName("h10");

                entity.Property(e => e.H11)
                    .HasMaxLength(100)
                    .HasColumnName("h11");

                entity.Property(e => e.H12)
                    .HasMaxLength(100)
                    .HasColumnName("h12");

                entity.Property(e => e.H13)
                    .HasMaxLength(100)
                    .HasColumnName("h13");

                entity.Property(e => e.H14)
                    .HasMaxLength(100)
                    .HasColumnName("h14");

                entity.Property(e => e.H15)
                    .HasMaxLength(100)
                    .HasColumnName("h15");

                entity.Property(e => e.H16)
                    .HasMaxLength(100)
                    .HasColumnName("h16");

                entity.Property(e => e.H17)
                    .HasMaxLength(100)
                    .HasColumnName("h17");

                entity.Property(e => e.H18)
                    .HasMaxLength(100)
                    .HasColumnName("h18");

                entity.Property(e => e.H19)
                    .HasMaxLength(100)
                    .HasColumnName("h19");

                entity.Property(e => e.H2)
                    .HasMaxLength(100)
                    .HasColumnName("h2");

                entity.Property(e => e.H20)
                    .HasMaxLength(100)
                    .HasColumnName("h20");

                entity.Property(e => e.H3)
                    .HasMaxLength(100)
                    .HasColumnName("h3");

                entity.Property(e => e.H4)
                    .HasMaxLength(100)
                    .HasColumnName("h4");

                entity.Property(e => e.H5)
                    .HasMaxLength(100)
                    .HasColumnName("h5");

                entity.Property(e => e.H6)
                    .HasMaxLength(100)
                    .HasColumnName("h6");

                entity.Property(e => e.H7)
                    .HasMaxLength(100)
                    .HasColumnName("h7");

                entity.Property(e => e.H8)
                    .HasMaxLength(100)
                    .HasColumnName("h8");

                entity.Property(e => e.H9)
                    .HasMaxLength(100)
                    .HasColumnName("h9");

                entity.Property(e => e.I1)
                    .HasMaxLength(100)
                    .HasColumnName("i1");

                entity.Property(e => e.I10)
                    .HasMaxLength(100)
                    .HasColumnName("i10");

                entity.Property(e => e.I11)
                    .HasMaxLength(100)
                    .HasColumnName("i11");

                entity.Property(e => e.I12)
                    .HasMaxLength(100)
                    .HasColumnName("i12");

                entity.Property(e => e.I13)
                    .HasMaxLength(100)
                    .HasColumnName("i13");

                entity.Property(e => e.I14)
                    .HasMaxLength(100)
                    .HasColumnName("i14");

                entity.Property(e => e.I15)
                    .HasMaxLength(100)
                    .HasColumnName("i15");

                entity.Property(e => e.I16)
                    .HasMaxLength(100)
                    .HasColumnName("i16");

                entity.Property(e => e.I17)
                    .HasMaxLength(100)
                    .HasColumnName("i17");

                entity.Property(e => e.I18)
                    .HasMaxLength(100)
                    .HasColumnName("i18");

                entity.Property(e => e.I19)
                    .HasMaxLength(100)
                    .HasColumnName("i19");

                entity.Property(e => e.I1maxll)
                    .HasMaxLength(100)
                    .HasColumnName("i1maxll");

                entity.Property(e => e.I1nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("i1nuamaxll");

                entity.Property(e => e.I2)
                    .HasMaxLength(100)
                    .HasColumnName("i2");

                entity.Property(e => e.I20)
                    .HasMaxLength(100)
                    .HasColumnName("i20");

                entity.Property(e => e.I2max)
                    .HasMaxLength(100)
                    .HasColumnName("i2max");

                entity.Property(e => e.I2maxll)
                    .HasMaxLength(100)
                    .HasColumnName("i2maxll");

                entity.Property(e => e.I2min)
                    .HasMaxLength(100)
                    .HasColumnName("i2min");

                entity.Property(e => e.I2nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("i2nuamax");

                entity.Property(e => e.I2nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("i2nuamaxll");

                entity.Property(e => e.I2ti1)
                    .HasMaxLength(100)
                    .HasColumnName("i2ti1");

                entity.Property(e => e.I2ti1max)
                    .HasMaxLength(100)
                    .HasColumnName("i2ti1max");

                entity.Property(e => e.I2ti1nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("i2ti1nuamax");

                entity.Property(e => e.I3)
                    .HasMaxLength(100)
                    .HasColumnName("i3");

                entity.Property(e => e.I3maxll)
                    .HasMaxLength(100)
                    .HasColumnName("i3maxll");

                entity.Property(e => e.I3nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("i3nuamaxll");

                entity.Property(e => e.I4)
                    .HasMaxLength(100)
                    .HasColumnName("i4");

                entity.Property(e => e.I4maxll)
                    .HasMaxLength(100)
                    .HasColumnName("i4maxll");

                entity.Property(e => e.I4nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("i4nuamaxll");

                entity.Property(e => e.I5)
                    .HasMaxLength(100)
                    .HasColumnName("i5");

                entity.Property(e => e.I5maxll)
                    .HasMaxLength(100)
                    .HasColumnName("i5maxll");

                entity.Property(e => e.I5nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("i5nuamaxll");

                entity.Property(e => e.I6)
                    .HasMaxLength(100)
                    .HasColumnName("i6");

                entity.Property(e => e.I6maxll)
                    .HasMaxLength(100)
                    .HasColumnName("i6maxll");

                entity.Property(e => e.I6nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("i6nuamaxll");

                entity.Property(e => e.I7)
                    .HasMaxLength(100)
                    .HasColumnName("i7");

                entity.Property(e => e.I8)
                    .HasMaxLength(100)
                    .HasColumnName("i8");

                entity.Property(e => e.I9)
                    .HasMaxLength(100)
                    .HasColumnName("i9");

                entity.Property(e => e.Imucmin)
                    .HasMaxLength(100)
                    .HasColumnName("imucmin");

                entity.Property(e => e.K1)
                    .HasMaxLength(100)
                    .HasColumnName("k1");

                entity.Property(e => e.K10)
                    .HasMaxLength(100)
                    .HasColumnName("k10");

                entity.Property(e => e.K11)
                    .HasMaxLength(100)
                    .HasColumnName("k11");

                entity.Property(e => e.K12)
                    .HasMaxLength(100)
                    .HasColumnName("k12");

                entity.Property(e => e.K13)
                    .HasMaxLength(100)
                    .HasColumnName("k13");

                entity.Property(e => e.K14)
                    .HasMaxLength(100)
                    .HasColumnName("k14");

                entity.Property(e => e.K15)
                    .HasMaxLength(100)
                    .HasColumnName("k15");

                entity.Property(e => e.K16)
                    .HasMaxLength(100)
                    .HasColumnName("k16");

                entity.Property(e => e.K17)
                    .HasMaxLength(100)
                    .HasColumnName("k17");

                entity.Property(e => e.K18)
                    .HasMaxLength(100)
                    .HasColumnName("k18");

                entity.Property(e => e.K19)
                    .HasMaxLength(100)
                    .HasColumnName("k19");

                entity.Property(e => e.K2)
                    .HasMaxLength(100)
                    .HasColumnName("k2");

                entity.Property(e => e.K20)
                    .HasMaxLength(100)
                    .HasColumnName("k20");

                entity.Property(e => e.K3)
                    .HasMaxLength(100)
                    .HasColumnName("k3");

                entity.Property(e => e.K4)
                    .HasMaxLength(100)
                    .HasColumnName("k4");

                entity.Property(e => e.K5)
                    .HasMaxLength(100)
                    .HasColumnName("k5");

                entity.Property(e => e.K6)
                    .HasMaxLength(100)
                    .HasColumnName("k6");

                entity.Property(e => e.K7)
                    .HasMaxLength(100)
                    .HasColumnName("k7");

                entity.Property(e => e.K8)
                    .HasMaxLength(100)
                    .HasColumnName("k8");

                entity.Property(e => e.K9)
                    .HasMaxLength(100)
                    .HasColumnName("k9");

                entity.Property(e => e.Kiemdinhvien).HasMaxLength(100);

                entity.Property(e => e.Kieu).HasMaxLength(100);

                entity.Property(e => e.L1)
                    .HasMaxLength(100)
                    .HasColumnName("l1");

                entity.Property(e => e.L10)
                    .HasMaxLength(100)
                    .HasColumnName("l10");

                entity.Property(e => e.L11)
                    .HasMaxLength(100)
                    .HasColumnName("l11");

                entity.Property(e => e.L12)
                    .HasMaxLength(100)
                    .HasColumnName("l12");

                entity.Property(e => e.L13)
                    .HasMaxLength(100)
                    .HasColumnName("l13");

                entity.Property(e => e.L14)
                    .HasMaxLength(100)
                    .HasColumnName("l14");

                entity.Property(e => e.L15)
                    .HasMaxLength(100)
                    .HasColumnName("l15");

                entity.Property(e => e.L16)
                    .HasMaxLength(100)
                    .HasColumnName("l16");

                entity.Property(e => e.L17)
                    .HasMaxLength(100)
                    .HasColumnName("l17");

                entity.Property(e => e.L18)
                    .HasMaxLength(100)
                    .HasColumnName("l18");

                entity.Property(e => e.L19)
                    .HasMaxLength(100)
                    .HasColumnName("l19");

                entity.Property(e => e.L1lt)
                    .HasMaxLength(100)
                    .HasColumnName("l1lt");

                entity.Property(e => e.L2)
                    .HasMaxLength(100)
                    .HasColumnName("l2");

                entity.Property(e => e.L20)
                    .HasMaxLength(100)
                    .HasColumnName("l20");

                entity.Property(e => e.L2lt)
                    .HasMaxLength(100)
                    .HasColumnName("l2lt");

                entity.Property(e => e.L3)
                    .HasMaxLength(100)
                    .HasColumnName("l3");

                entity.Property(e => e.L3lt)
                    .HasMaxLength(100)
                    .HasColumnName("l3lt");

                entity.Property(e => e.L4)
                    .HasMaxLength(100)
                    .HasColumnName("l4");

                entity.Property(e => e.L4lt)
                    .HasMaxLength(100)
                    .HasColumnName("l4lt");

                entity.Property(e => e.L5)
                    .HasMaxLength(100)
                    .HasColumnName("l5");

                entity.Property(e => e.L6)
                    .HasMaxLength(100)
                    .HasColumnName("l6");

                entity.Property(e => e.L7)
                    .HasMaxLength(100)
                    .HasColumnName("l7");

                entity.Property(e => e.L8)
                    .HasMaxLength(100)
                    .HasColumnName("l8");

                entity.Property(e => e.L9)
                    .HasMaxLength(100)
                    .HasColumnName("l9");

                entity.Property(e => e.Layrannmax)
                    .HasMaxLength(100)
                    .HasColumnName("layrannmax");

                entity.Property(e => e.Layrannmin)
                    .HasMaxLength(100)
                    .HasColumnName("layrannmin");

                entity.Property(e => e.Layrannnuamax)
                    .HasMaxLength(100)
                    .HasColumnName("layrannnuamax");

                entity.Property(e => e.M1)
                    .HasMaxLength(100)
                    .HasColumnName("m1");

                entity.Property(e => e.M10)
                    .HasMaxLength(100)
                    .HasColumnName("m10");

                entity.Property(e => e.M11)
                    .HasMaxLength(100)
                    .HasColumnName("m11");

                entity.Property(e => e.M12)
                    .HasMaxLength(100)
                    .HasColumnName("m12");

                entity.Property(e => e.M13)
                    .HasMaxLength(100)
                    .HasColumnName("m13");

                entity.Property(e => e.M14)
                    .HasMaxLength(100)
                    .HasColumnName("m14");

                entity.Property(e => e.M15)
                    .HasMaxLength(100)
                    .HasColumnName("m15");

                entity.Property(e => e.M16)
                    .HasMaxLength(100)
                    .HasColumnName("m16");

                entity.Property(e => e.M17)
                    .HasMaxLength(100)
                    .HasColumnName("m17");

                entity.Property(e => e.M18)
                    .HasMaxLength(100)
                    .HasColumnName("m18");

                entity.Property(e => e.M19)
                    .HasMaxLength(100)
                    .HasColumnName("m19");

                entity.Property(e => e.M2)
                    .HasMaxLength(100)
                    .HasColumnName("m2");

                entity.Property(e => e.M20)
                    .HasMaxLength(100)
                    .HasColumnName("m20");

                entity.Property(e => e.M3)
                    .HasMaxLength(100)
                    .HasColumnName("m3");

                entity.Property(e => e.M4)
                    .HasMaxLength(100)
                    .HasColumnName("m4");

                entity.Property(e => e.M5)
                    .HasMaxLength(100)
                    .HasColumnName("m5");

                entity.Property(e => e.M6)
                    .HasMaxLength(100)
                    .HasColumnName("m6");

                entity.Property(e => e.M7)
                    .HasMaxLength(100)
                    .HasColumnName("m7");

                entity.Property(e => e.M8)
                    .HasMaxLength(100)
                    .HasColumnName("m8");

                entity.Property(e => e.M9)
                    .HasMaxLength(100)
                    .HasColumnName("m9");

                entity.Property(e => e.Maqd).HasMaxLength(100);

                entity.Property(e => e.Max1)
                    .HasMaxLength(100)
                    .HasColumnName("max1");

                entity.Property(e => e.Max2)
                    .HasMaxLength(100)
                    .HasColumnName("max2");

                entity.Property(e => e.Max3)
                    .HasMaxLength(100)
                    .HasColumnName("max3");

                entity.Property(e => e.Max4)
                    .HasMaxLength(100)
                    .HasColumnName("max4");

                entity.Property(e => e.Mil1dd)
                    .HasMaxLength(100)
                    .HasColumnName("mil1dd");

                entity.Property(e => e.Mtmucmin)
                    .HasMaxLength(100)
                    .HasColumnName("mtmucmin");

                entity.Property(e => e.Muccan).HasMaxLength(100);

                entity.Property(e => e.Mucmax).HasMaxLength(100);

                entity.Property(e => e.Mucmin).HasMaxLength(100);

                entity.Property(e => e.Muctailt)
                    .HasMaxLength(100)
                    .HasColumnName("muctailt");

                entity.Property(e => e.Mxl1dd)
                    .HasMaxLength(100)
                    .HasColumnName("mxl1dd");

                entity.Property(e => e.N1)
                    .HasMaxLength(100)
                    .HasColumnName("n1");

                entity.Property(e => e.N10)
                    .HasMaxLength(100)
                    .HasColumnName("n10");

                entity.Property(e => e.N11)
                    .HasMaxLength(100)
                    .HasColumnName("n11");

                entity.Property(e => e.N12)
                    .HasMaxLength(100)
                    .HasColumnName("n12");

                entity.Property(e => e.N13)
                    .HasMaxLength(100)
                    .HasColumnName("n13");

                entity.Property(e => e.N14)
                    .HasMaxLength(100)
                    .HasColumnName("n14");

                entity.Property(e => e.N15)
                    .HasMaxLength(100)
                    .HasColumnName("n15");

                entity.Property(e => e.N16)
                    .HasMaxLength(100)
                    .HasColumnName("n16");

                entity.Property(e => e.N17)
                    .HasMaxLength(100)
                    .HasColumnName("n17");

                entity.Property(e => e.N18)
                    .HasMaxLength(100)
                    .HasColumnName("n18")
                    .IsFixedLength();

                entity.Property(e => e.N19)
                    .HasMaxLength(100)
                    .HasColumnName("n19");

                entity.Property(e => e.N2)
                    .HasMaxLength(100)
                    .HasColumnName("n2");

                entity.Property(e => e.N20)
                    .HasMaxLength(100)
                    .HasColumnName("n20");

                entity.Property(e => e.N3)
                    .HasMaxLength(100)
                    .HasColumnName("n3");

                entity.Property(e => e.N4)
                    .HasMaxLength(100)
                    .HasColumnName("n4");

                entity.Property(e => e.N5)
                    .HasMaxLength(100)
                    .HasColumnName("n5");

                entity.Property(e => e.N6)
                    .HasMaxLength(100)
                    .HasColumnName("n6");

                entity.Property(e => e.N7)
                    .HasMaxLength(100)
                    .HasColumnName("n7");

                entity.Property(e => e.N8)
                    .HasMaxLength(100)
                    .HasColumnName("n8");

                entity.Property(e => e.N9)
                    .HasMaxLength(100)
                    .HasColumnName("n9");

                entity.Property(e => e.NamSx)
                    .HasMaxLength(100)
                    .HasColumnName("NamSX");

                entity.Property(e => e.Ngay).HasMaxLength(100);

                entity.Property(e => e.Nmxl1dd)
                    .HasMaxLength(100)
                    .HasColumnName("nmxl1dd");

                entity.Property(e => e.NuocSx)
                    .HasMaxLength(100)
                    .HasColumnName("NuocSX");

                entity.Property(e => e.P1maxll)
                    .HasMaxLength(100)
                    .HasColumnName("p1maxll");

                entity.Property(e => e.P1nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("p1nuamaxll");

                entity.Property(e => e.P2maxll)
                    .HasMaxLength(100)
                    .HasColumnName("p2maxll");

                entity.Property(e => e.P2nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("p2nuamaxll");

                entity.Property(e => e.P3maxll)
                    .HasMaxLength(100)
                    .HasColumnName("p3maxll");

                entity.Property(e => e.P3nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("p3nuamaxll");

                entity.Property(e => e.P4maxll)
                    .HasMaxLength(100)
                    .HasColumnName("p4maxll");

                entity.Property(e => e.P4nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("p4nuamaxll");

                entity.Property(e => e.P5maxll)
                    .HasMaxLength(100)
                    .HasColumnName("p5maxll");

                entity.Property(e => e.P5nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("p5nuamaxll");

                entity.Property(e => e.P6maxll)
                    .HasMaxLength(100)
                    .HasColumnName("p6maxll");

                entity.Property(e => e.P6nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("p6nuamaxll");

                entity.Property(e => e.Pimaxmin)
                    .HasMaxLength(100)
                    .HasColumnName("pimaxmin");

                entity.Property(e => e.Pjmaxmin)
                    .HasMaxLength(100)
                    .HasColumnName("pjmaxmin");

                entity.Property(e => e.Ppthuchien)
                    .HasMaxLength(100)
                    .HasColumnName("PPthuchien");

                entity.Property(e => e.Saisoe0mucmin)
                    .HasMaxLength(100)
                    .HasColumnName("saisoe0mucmin");

                entity.Property(e => e.So).HasMaxLength(100);

                entity.Property(e => e.Ss1lt)
                    .HasMaxLength(100)
                    .HasColumnName("ss1lt");

                entity.Property(e => e.Ss2lt)
                    .HasMaxLength(100)
                    .HasColumnName("ss2lt");

                entity.Property(e => e.Ss3lt)
                    .HasMaxLength(100)
                    .HasColumnName("ss3lt");

                entity.Property(e => e.Ss4lt)
                    .HasMaxLength(100)
                    .HasColumnName("ss4lt");

                entity.Property(e => e.Sscp1)
                    .HasMaxLength(100)
                    .HasColumnName("sscp1");

                entity.Property(e => e.Sscp2)
                    .HasMaxLength(100)
                    .HasColumnName("sscp2");

                entity.Property(e => e.Sscp3)
                    .HasMaxLength(100)
                    .HasColumnName("sscp3");

                entity.Property(e => e.Sscp4)
                    .HasMaxLength(100)
                    .HasColumnName("sscp4");

                entity.Property(e => e.Sscpg)
                    .HasMaxLength(100)
                    .HasColumnName("sscpg");

                entity.Property(e => e.Sscpmax)
                    .HasMaxLength(100)
                    .HasColumnName("sscpmax");

                entity.Property(e => e.Sscpmucmin)
                    .HasMaxLength(100)
                    .HasColumnName("sscpmucmin");

                entity.Property(e => e.Sscpnuamax)
                    .HasMaxLength(100)
                    .HasColumnName("sscpnuamax");

                entity.Property(e => e.Ssglt)
                    .HasMaxLength(100)
                    .HasColumnName("ssglt");

                entity.Property(e => e.Tenphuongtien).HasMaxLength(100);

                entity.Property(e => e.Themvao1p10dmax)
                    .HasMaxLength(100)
                    .HasColumnName("themvao1p10dmax");

                entity.Property(e => e.Themvao1p10dmin)
                    .HasMaxLength(100)
                    .HasColumnName("themvao1p10dmin");

                entity.Property(e => e.Themvao1p10dnuamax)
                    .HasMaxLength(100)
                    .HasColumnName("themvao1p10dnuamax");

                entity.Property(e => e.Themvao1p4dmax)
                    .HasMaxLength(100)
                    .HasColumnName("themvao1p4dmax");

                entity.Property(e => e.Themvao1p4dmin)
                    .HasMaxLength(100)
                    .HasColumnName("themvao1p4dmin");

                entity.Property(e => e.Themvao1p4dnuamax)
                    .HasMaxLength(100)
                    .HasColumnName("themvao1p4dnuamax");
            });

            modelBuilder.Entity<Tbcandium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbcandia");

                entity.Property(e => e.A1)
                    .HasMaxLength(100)
                    .HasColumnName("a1");

                entity.Property(e => e.A10)
                    .HasMaxLength(100)
                    .HasColumnName("a10");

                entity.Property(e => e.A11)
                    .HasMaxLength(100)
                    .HasColumnName("a11");

                entity.Property(e => e.A12)
                    .HasMaxLength(100)
                    .HasColumnName("a12");

                entity.Property(e => e.A13)
                    .HasMaxLength(100)
                    .HasColumnName("a13");

                entity.Property(e => e.A14)
                    .HasMaxLength(100)
                    .HasColumnName("a14");

                entity.Property(e => e.A15)
                    .HasMaxLength(100)
                    .HasColumnName("a15");

                entity.Property(e => e.A16)
                    .HasMaxLength(100)
                    .HasColumnName("a16");

                entity.Property(e => e.A17)
                    .HasMaxLength(100)
                    .HasColumnName("a17");

                entity.Property(e => e.A18)
                    .HasMaxLength(100)
                    .HasColumnName("a18");

                entity.Property(e => e.A19)
                    .HasMaxLength(100)
                    .HasColumnName("a19");

                entity.Property(e => e.A2)
                    .HasMaxLength(100)
                    .HasColumnName("a2");

                entity.Property(e => e.A20)
                    .HasMaxLength(100)
                    .HasColumnName("a20");

                entity.Property(e => e.A3)
                    .HasMaxLength(100)
                    .HasColumnName("a3");

                entity.Property(e => e.A4)
                    .HasMaxLength(100)
                    .HasColumnName("a4");

                entity.Property(e => e.A5)
                    .HasMaxLength(100)
                    .HasColumnName("a5");

                entity.Property(e => e.A6)
                    .HasMaxLength(100)
                    .HasColumnName("a6");

                entity.Property(e => e.A7)
                    .HasMaxLength(100)
                    .HasColumnName("a7");

                entity.Property(e => e.A8)
                    .HasMaxLength(100)
                    .HasColumnName("a8");

                entity.Property(e => e.A9)
                    .HasMaxLength(100)
                    .HasColumnName("a9");

                entity.Property(e => e.B1)
                    .HasMaxLength(100)
                    .HasColumnName("b1");

                entity.Property(e => e.B10)
                    .HasMaxLength(100)
                    .HasColumnName("b10");

                entity.Property(e => e.B11)
                    .HasMaxLength(100)
                    .HasColumnName("b11");

                entity.Property(e => e.B12)
                    .HasMaxLength(100)
                    .HasColumnName("b12");

                entity.Property(e => e.B13)
                    .HasMaxLength(100)
                    .HasColumnName("b13");

                entity.Property(e => e.B14)
                    .HasMaxLength(100)
                    .HasColumnName("b14");

                entity.Property(e => e.B15)
                    .HasMaxLength(100)
                    .HasColumnName("b15");

                entity.Property(e => e.B16)
                    .HasMaxLength(100)
                    .HasColumnName("b16");

                entity.Property(e => e.B17)
                    .HasMaxLength(100)
                    .HasColumnName("b17");

                entity.Property(e => e.B18)
                    .HasMaxLength(100)
                    .HasColumnName("b18");

                entity.Property(e => e.B19)
                    .HasMaxLength(100)
                    .HasColumnName("b19");

                entity.Property(e => e.B2)
                    .HasMaxLength(100)
                    .HasColumnName("b2");

                entity.Property(e => e.B20)
                    .HasMaxLength(100)
                    .HasColumnName("b20");

                entity.Property(e => e.B3)
                    .HasMaxLength(100)
                    .HasColumnName("b3");

                entity.Property(e => e.B4)
                    .HasMaxLength(100)
                    .HasColumnName("b4");

                entity.Property(e => e.B5)
                    .HasMaxLength(100)
                    .HasColumnName("b5");

                entity.Property(e => e.B6)
                    .HasMaxLength(100)
                    .HasColumnName("b6");

                entity.Property(e => e.B7)
                    .HasMaxLength(100)
                    .HasColumnName("b7");

                entity.Property(e => e.B8)
                    .HasMaxLength(100)
                    .HasColumnName("b8");

                entity.Property(e => e.B9)
                    .HasMaxLength(100)
                    .HasColumnName("b9");

                entity.Property(e => e.C1)
                    .HasMaxLength(100)
                    .HasColumnName("c1");

                entity.Property(e => e.C10)
                    .HasMaxLength(100)
                    .HasColumnName("c10");

                entity.Property(e => e.C11)
                    .HasMaxLength(100)
                    .HasColumnName("c11");

                entity.Property(e => e.C12)
                    .HasMaxLength(100)
                    .HasColumnName("c12");

                entity.Property(e => e.C13)
                    .HasMaxLength(100)
                    .HasColumnName("c13");

                entity.Property(e => e.C14)
                    .HasMaxLength(100)
                    .HasColumnName("c14");

                entity.Property(e => e.C15)
                    .HasMaxLength(100)
                    .HasColumnName("c15");

                entity.Property(e => e.C16)
                    .HasMaxLength(100)
                    .HasColumnName("c16");

                entity.Property(e => e.C17)
                    .HasMaxLength(100)
                    .HasColumnName("c17");

                entity.Property(e => e.C18)
                    .HasMaxLength(100)
                    .HasColumnName("c18");

                entity.Property(e => e.C19)
                    .HasMaxLength(100)
                    .HasColumnName("c19");

                entity.Property(e => e.C2)
                    .HasMaxLength(100)
                    .HasColumnName("c2");

                entity.Property(e => e.C20)
                    .HasMaxLength(100)
                    .HasColumnName("c20");

                entity.Property(e => e.C3)
                    .HasMaxLength(100)
                    .HasColumnName("c3");

                entity.Property(e => e.C4)
                    .HasMaxLength(100)
                    .HasColumnName("c4");

                entity.Property(e => e.C5)
                    .HasMaxLength(100)
                    .HasColumnName("c5");

                entity.Property(e => e.C6)
                    .HasMaxLength(100)
                    .HasColumnName("c6");

                entity.Property(e => e.C7)
                    .HasMaxLength(100)
                    .HasColumnName("c7");

                entity.Property(e => e.C8)
                    .HasMaxLength(100)
                    .HasColumnName("c8");

                entity.Property(e => e.C9)
                    .HasMaxLength(100)
                    .HasColumnName("c9");

                entity.Property(e => e.Capchinhxac).HasMaxLength(100);

                entity.Property(e => e.Chedokd).HasMaxLength(100);

                entity.Property(e => e.Chuantb).HasMaxLength(100);

                entity.Property(e => e.D1)
                    .HasMaxLength(100)
                    .HasColumnName("d1");

                entity.Property(e => e.D2)
                    .HasMaxLength(100)
                    .HasColumnName("d2");

                entity.Property(e => e.D3)
                    .HasMaxLength(100)
                    .HasColumnName("d3");

                entity.Property(e => e.D4)
                    .HasMaxLength(100)
                    .HasColumnName("d4");

                entity.Property(e => e.Delta1lt)
                    .HasMaxLength(100)
                    .HasColumnName("delta1lt");

                entity.Property(e => e.Delta1maxll)
                    .HasMaxLength(100)
                    .HasColumnName("delta1maxll");

                entity.Property(e => e.Delta1nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("delta1nuamax");

                entity.Property(e => e.Delta2lt)
                    .HasMaxLength(100)
                    .HasColumnName("delta2lt");

                entity.Property(e => e.Delta2maxll)
                    .HasMaxLength(100)
                    .HasColumnName("delta2maxll");

                entity.Property(e => e.Delta2nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("delta2nuamax");

                entity.Property(e => e.Delta3lt)
                    .HasMaxLength(100)
                    .HasColumnName("delta3lt");

                entity.Property(e => e.Delta3maxll)
                    .HasMaxLength(100)
                    .HasColumnName("delta3maxll");

                entity.Property(e => e.Delta3nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("delta3nuamax");

                entity.Property(e => e.Delta4lt)
                    .HasMaxLength(100)
                    .HasColumnName("delta4lt");

                entity.Property(e => e.Delta4maxll)
                    .HasMaxLength(100)
                    .HasColumnName("delta4maxll");

                entity.Property(e => e.Delta4nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("delta4nuamax");

                entity.Property(e => e.Delta5maxll)
                    .HasMaxLength(100)
                    .HasColumnName("delta5maxll");

                entity.Property(e => e.Delta5nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("delta5nuamax");

                entity.Property(e => e.Delta6maxll)
                    .HasMaxLength(100)
                    .HasColumnName("delta6maxll");

                entity.Property(e => e.Delta6nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("delta6nuamax");

                entity.Property(e => e.Deltaglt)
                    .HasMaxLength(100)
                    .HasColumnName("deltaglt");

                entity.Property(e => e.Diachisd).HasMaxLength(100);

                entity.Property(e => e.Dkmt).HasMaxLength(100);

                entity.Property(e => e.Donvisd).HasMaxLength(100);

                entity.Property(e => e.E1)
                    .HasMaxLength(100)
                    .HasColumnName("e1");

                entity.Property(e => e.E2)
                    .HasMaxLength(100)
                    .HasColumnName("e2");

                entity.Property(e => e.E3)
                    .HasMaxLength(100)
                    .HasColumnName("e3");

                entity.Property(e => e.E4)
                    .HasMaxLength(100)
                    .HasColumnName("e4");

                entity.Property(e => e.Ec1lt)
                    .HasMaxLength(100)
                    .HasColumnName("ec1lt");

                entity.Property(e => e.Ec2lt)
                    .HasMaxLength(100)
                    .HasColumnName("ec2lt");

                entity.Property(e => e.Ec3lt)
                    .HasMaxLength(100)
                    .HasColumnName("ec3lt");

                entity.Property(e => e.Ec4lt)
                    .HasMaxLength(100)
                    .HasColumnName("ec4lt");

                entity.Property(e => e.Ecglt)
                    .HasMaxLength(100)
                    .HasColumnName("ecglt");

                entity.Property(e => e.G1)
                    .HasMaxLength(100)
                    .HasColumnName("g1");

                entity.Property(e => e.G10)
                    .HasMaxLength(100)
                    .HasColumnName("g10");

                entity.Property(e => e.G11)
                    .HasMaxLength(100)
                    .HasColumnName("g11");

                entity.Property(e => e.G12)
                    .HasMaxLength(100)
                    .HasColumnName("g12");

                entity.Property(e => e.G13)
                    .HasMaxLength(100)
                    .HasColumnName("g13");

                entity.Property(e => e.G14)
                    .HasMaxLength(100)
                    .HasColumnName("g14");

                entity.Property(e => e.G15)
                    .HasMaxLength(100)
                    .HasColumnName("g15");

                entity.Property(e => e.G16)
                    .HasMaxLength(100)
                    .HasColumnName("g16");

                entity.Property(e => e.G17)
                    .HasMaxLength(100)
                    .HasColumnName("g17");

                entity.Property(e => e.G18)
                    .HasMaxLength(100)
                    .HasColumnName("g18");

                entity.Property(e => e.G19)
                    .HasMaxLength(100)
                    .HasColumnName("g19");

                entity.Property(e => e.G2)
                    .HasMaxLength(100)
                    .HasColumnName("g2");

                entity.Property(e => e.G20)
                    .HasMaxLength(100)
                    .HasColumnName("g20");

                entity.Property(e => e.G3)
                    .HasMaxLength(100)
                    .HasColumnName("g3");

                entity.Property(e => e.G4)
                    .HasMaxLength(100)
                    .HasColumnName("g4");

                entity.Property(e => e.G5)
                    .HasMaxLength(100)
                    .HasColumnName("g5");

                entity.Property(e => e.G6)
                    .HasMaxLength(100)
                    .HasColumnName("g6");

                entity.Property(e => e.G7)
                    .HasMaxLength(100)
                    .HasColumnName("g7");

                entity.Property(e => e.G8)
                    .HasMaxLength(100)
                    .HasColumnName("g8");

                entity.Property(e => e.G9)
                    .HasMaxLength(100)
                    .HasColumnName("g9");

                entity.Property(e => e.Glt)
                    .HasMaxLength(100)
                    .HasColumnName("glt");

                entity.Property(e => e.Gmucmin)
                    .HasMaxLength(100)
                    .HasColumnName("gmucmin");

                entity.Property(e => e.H1)
                    .HasMaxLength(100)
                    .HasColumnName("h1");

                entity.Property(e => e.H10)
                    .HasMaxLength(100)
                    .HasColumnName("h10");

                entity.Property(e => e.H11)
                    .HasMaxLength(100)
                    .HasColumnName("h11");

                entity.Property(e => e.H12)
                    .HasMaxLength(100)
                    .HasColumnName("h12");

                entity.Property(e => e.H13)
                    .HasMaxLength(100)
                    .HasColumnName("h13");

                entity.Property(e => e.H14)
                    .HasMaxLength(100)
                    .HasColumnName("h14");

                entity.Property(e => e.H15)
                    .HasMaxLength(100)
                    .HasColumnName("h15");

                entity.Property(e => e.H16)
                    .HasMaxLength(100)
                    .HasColumnName("h16");

                entity.Property(e => e.H17)
                    .HasMaxLength(100)
                    .HasColumnName("h17");

                entity.Property(e => e.H18)
                    .HasMaxLength(100)
                    .HasColumnName("h18");

                entity.Property(e => e.H19)
                    .HasMaxLength(100)
                    .HasColumnName("h19");

                entity.Property(e => e.H2)
                    .HasMaxLength(100)
                    .HasColumnName("h2");

                entity.Property(e => e.H20)
                    .HasMaxLength(100)
                    .HasColumnName("h20");

                entity.Property(e => e.H3)
                    .HasMaxLength(100)
                    .HasColumnName("h3");

                entity.Property(e => e.H4)
                    .HasMaxLength(100)
                    .HasColumnName("h4");

                entity.Property(e => e.H5)
                    .HasMaxLength(100)
                    .HasColumnName("h5");

                entity.Property(e => e.H6)
                    .HasMaxLength(100)
                    .HasColumnName("h6");

                entity.Property(e => e.H7)
                    .HasMaxLength(100)
                    .HasColumnName("h7");

                entity.Property(e => e.H8)
                    .HasMaxLength(100)
                    .HasColumnName("h8");

                entity.Property(e => e.H9)
                    .HasMaxLength(100)
                    .HasColumnName("h9");

                entity.Property(e => e.I1)
                    .HasMaxLength(100)
                    .HasColumnName("i1");

                entity.Property(e => e.I10)
                    .HasMaxLength(100)
                    .HasColumnName("i10");

                entity.Property(e => e.I11)
                    .HasMaxLength(100)
                    .HasColumnName("i11");

                entity.Property(e => e.I12)
                    .HasMaxLength(100)
                    .HasColumnName("i12");

                entity.Property(e => e.I13)
                    .HasMaxLength(100)
                    .HasColumnName("i13");

                entity.Property(e => e.I14)
                    .HasMaxLength(100)
                    .HasColumnName("i14");

                entity.Property(e => e.I15)
                    .HasMaxLength(100)
                    .HasColumnName("i15");

                entity.Property(e => e.I16)
                    .HasMaxLength(100)
                    .HasColumnName("i16");

                entity.Property(e => e.I17)
                    .HasMaxLength(100)
                    .HasColumnName("i17");

                entity.Property(e => e.I18)
                    .HasMaxLength(100)
                    .HasColumnName("i18");

                entity.Property(e => e.I19)
                    .HasMaxLength(100)
                    .HasColumnName("i19");

                entity.Property(e => e.I1maxll)
                    .HasMaxLength(100)
                    .HasColumnName("i1maxll");

                entity.Property(e => e.I1nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("i1nuamaxll");

                entity.Property(e => e.I2)
                    .HasMaxLength(100)
                    .HasColumnName("i2");

                entity.Property(e => e.I20)
                    .HasMaxLength(100)
                    .HasColumnName("i20");

                entity.Property(e => e.I2max)
                    .HasMaxLength(100)
                    .HasColumnName("i2max");

                entity.Property(e => e.I2maxll)
                    .HasMaxLength(100)
                    .HasColumnName("i2maxll");

                entity.Property(e => e.I2min)
                    .HasMaxLength(100)
                    .HasColumnName("i2min");

                entity.Property(e => e.I2nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("i2nuamax");

                entity.Property(e => e.I2nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("i2nuamaxll");

                entity.Property(e => e.I2ti1)
                    .HasMaxLength(100)
                    .HasColumnName("i2ti1");

                entity.Property(e => e.I2ti1max)
                    .HasMaxLength(100)
                    .HasColumnName("i2ti1max");

                entity.Property(e => e.I2ti1nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("i2ti1nuamax");

                entity.Property(e => e.I3)
                    .HasMaxLength(100)
                    .HasColumnName("i3");

                entity.Property(e => e.I3maxll)
                    .HasMaxLength(100)
                    .HasColumnName("i3maxll");

                entity.Property(e => e.I3nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("i3nuamaxll");

                entity.Property(e => e.I4)
                    .HasMaxLength(100)
                    .HasColumnName("i4");

                entity.Property(e => e.I4maxll)
                    .HasMaxLength(100)
                    .HasColumnName("i4maxll");

                entity.Property(e => e.I4nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("i4nuamaxll");

                entity.Property(e => e.I5)
                    .HasMaxLength(100)
                    .HasColumnName("i5");

                entity.Property(e => e.I5maxll)
                    .HasMaxLength(100)
                    .HasColumnName("i5maxll");

                entity.Property(e => e.I5nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("i5nuamaxll");

                entity.Property(e => e.I6)
                    .HasMaxLength(100)
                    .HasColumnName("i6");

                entity.Property(e => e.I6maxll)
                    .HasMaxLength(100)
                    .HasColumnName("i6maxll");

                entity.Property(e => e.I6nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("i6nuamaxll");

                entity.Property(e => e.I7)
                    .HasMaxLength(100)
                    .HasColumnName("i7");

                entity.Property(e => e.I8)
                    .HasMaxLength(100)
                    .HasColumnName("i8");

                entity.Property(e => e.I9)
                    .HasMaxLength(100)
                    .HasColumnName("i9");

                entity.Property(e => e.Imucmin)
                    .HasMaxLength(100)
                    .HasColumnName("imucmin");

                entity.Property(e => e.K1)
                    .HasMaxLength(100)
                    .HasColumnName("k1");

                entity.Property(e => e.K10)
                    .HasMaxLength(100)
                    .HasColumnName("k10");

                entity.Property(e => e.K11)
                    .HasMaxLength(100)
                    .HasColumnName("k11");

                entity.Property(e => e.K12)
                    .HasMaxLength(100)
                    .HasColumnName("k12");

                entity.Property(e => e.K13)
                    .HasMaxLength(100)
                    .HasColumnName("k13");

                entity.Property(e => e.K14)
                    .HasMaxLength(100)
                    .HasColumnName("k14");

                entity.Property(e => e.K15)
                    .HasMaxLength(100)
                    .HasColumnName("k15");

                entity.Property(e => e.K16)
                    .HasMaxLength(100)
                    .HasColumnName("k16");

                entity.Property(e => e.K17)
                    .HasMaxLength(100)
                    .HasColumnName("k17");

                entity.Property(e => e.K18)
                    .HasMaxLength(100)
                    .HasColumnName("k18");

                entity.Property(e => e.K19)
                    .HasMaxLength(100)
                    .HasColumnName("k19");

                entity.Property(e => e.K2)
                    .HasMaxLength(100)
                    .HasColumnName("k2");

                entity.Property(e => e.K20)
                    .HasMaxLength(100)
                    .HasColumnName("k20");

                entity.Property(e => e.K3)
                    .HasMaxLength(100)
                    .HasColumnName("k3");

                entity.Property(e => e.K4)
                    .HasMaxLength(100)
                    .HasColumnName("k4");

                entity.Property(e => e.K5)
                    .HasMaxLength(100)
                    .HasColumnName("k5");

                entity.Property(e => e.K6)
                    .HasMaxLength(100)
                    .HasColumnName("k6");

                entity.Property(e => e.K7)
                    .HasMaxLength(100)
                    .HasColumnName("k7");

                entity.Property(e => e.K8)
                    .HasMaxLength(100)
                    .HasColumnName("k8");

                entity.Property(e => e.K9)
                    .HasMaxLength(100)
                    .HasColumnName("k9");

                entity.Property(e => e.Kiemdinhvien).HasMaxLength(100);

                entity.Property(e => e.Kieu).HasMaxLength(100);

                entity.Property(e => e.L1)
                    .HasMaxLength(100)
                    .HasColumnName("l1");

                entity.Property(e => e.L10)
                    .HasMaxLength(100)
                    .HasColumnName("l10");

                entity.Property(e => e.L11)
                    .HasMaxLength(100)
                    .HasColumnName("l11");

                entity.Property(e => e.L12)
                    .HasMaxLength(100)
                    .HasColumnName("l12");

                entity.Property(e => e.L13)
                    .HasMaxLength(100)
                    .HasColumnName("l13");

                entity.Property(e => e.L14)
                    .HasMaxLength(100)
                    .HasColumnName("l14");

                entity.Property(e => e.L15)
                    .HasMaxLength(100)
                    .HasColumnName("l15");

                entity.Property(e => e.L16)
                    .HasMaxLength(100)
                    .HasColumnName("l16");

                entity.Property(e => e.L17)
                    .HasMaxLength(100)
                    .HasColumnName("l17");

                entity.Property(e => e.L18)
                    .HasMaxLength(100)
                    .HasColumnName("l18");

                entity.Property(e => e.L19)
                    .HasMaxLength(100)
                    .HasColumnName("l19");

                entity.Property(e => e.L1lt)
                    .HasMaxLength(100)
                    .HasColumnName("l1lt");

                entity.Property(e => e.L2)
                    .HasMaxLength(100)
                    .HasColumnName("l2");

                entity.Property(e => e.L20)
                    .HasMaxLength(100)
                    .HasColumnName("l20");

                entity.Property(e => e.L2lt)
                    .HasMaxLength(100)
                    .HasColumnName("l2lt");

                entity.Property(e => e.L3)
                    .HasMaxLength(100)
                    .HasColumnName("l3");

                entity.Property(e => e.L3lt)
                    .HasMaxLength(100)
                    .HasColumnName("l3lt");

                entity.Property(e => e.L4)
                    .HasMaxLength(100)
                    .HasColumnName("l4");

                entity.Property(e => e.L4lt)
                    .HasMaxLength(100)
                    .HasColumnName("l4lt");

                entity.Property(e => e.L5)
                    .HasMaxLength(100)
                    .HasColumnName("l5");

                entity.Property(e => e.L6)
                    .HasMaxLength(100)
                    .HasColumnName("l6");

                entity.Property(e => e.L7)
                    .HasMaxLength(100)
                    .HasColumnName("l7");

                entity.Property(e => e.L8)
                    .HasMaxLength(100)
                    .HasColumnName("l8");

                entity.Property(e => e.L9)
                    .HasMaxLength(100)
                    .HasColumnName("l9");

                entity.Property(e => e.Layrannmax)
                    .HasMaxLength(100)
                    .HasColumnName("layrannmax");

                entity.Property(e => e.Layrannmin)
                    .HasMaxLength(100)
                    .HasColumnName("layrannmin");

                entity.Property(e => e.Layrannnuamax)
                    .HasMaxLength(100)
                    .HasColumnName("layrannnuamax");

                entity.Property(e => e.M1)
                    .HasMaxLength(100)
                    .HasColumnName("m1");

                entity.Property(e => e.M10)
                    .HasMaxLength(100)
                    .HasColumnName("m10");

                entity.Property(e => e.M11)
                    .HasMaxLength(100)
                    .HasColumnName("m11");

                entity.Property(e => e.M12)
                    .HasMaxLength(100)
                    .HasColumnName("m12");

                entity.Property(e => e.M13)
                    .HasMaxLength(100)
                    .HasColumnName("m13");

                entity.Property(e => e.M14)
                    .HasMaxLength(100)
                    .HasColumnName("m14");

                entity.Property(e => e.M15)
                    .HasMaxLength(100)
                    .HasColumnName("m15");

                entity.Property(e => e.M16)
                    .HasMaxLength(100)
                    .HasColumnName("m16");

                entity.Property(e => e.M17)
                    .HasMaxLength(100)
                    .HasColumnName("m17");

                entity.Property(e => e.M18)
                    .HasMaxLength(100)
                    .HasColumnName("m18");

                entity.Property(e => e.M19)
                    .HasMaxLength(100)
                    .HasColumnName("m19");

                entity.Property(e => e.M2)
                    .HasMaxLength(100)
                    .HasColumnName("m2");

                entity.Property(e => e.M20)
                    .HasMaxLength(100)
                    .HasColumnName("m20");

                entity.Property(e => e.M3)
                    .HasMaxLength(100)
                    .HasColumnName("m3");

                entity.Property(e => e.M4)
                    .HasMaxLength(100)
                    .HasColumnName("m4");

                entity.Property(e => e.M5)
                    .HasMaxLength(100)
                    .HasColumnName("m5");

                entity.Property(e => e.M6)
                    .HasMaxLength(100)
                    .HasColumnName("m6");

                entity.Property(e => e.M7)
                    .HasMaxLength(100)
                    .HasColumnName("m7");

                entity.Property(e => e.M8)
                    .HasMaxLength(100)
                    .HasColumnName("m8");

                entity.Property(e => e.M9)
                    .HasMaxLength(100)
                    .HasColumnName("m9");

                entity.Property(e => e.Maqd).HasMaxLength(100);

                entity.Property(e => e.Max1)
                    .HasMaxLength(100)
                    .HasColumnName("max1");

                entity.Property(e => e.Max2)
                    .HasMaxLength(100)
                    .HasColumnName("max2");

                entity.Property(e => e.Max3)
                    .HasMaxLength(100)
                    .HasColumnName("max3");

                entity.Property(e => e.Max4)
                    .HasMaxLength(100)
                    .HasColumnName("max4");

                entity.Property(e => e.Mil1dd)
                    .HasMaxLength(100)
                    .HasColumnName("mil1dd");

                entity.Property(e => e.Mtmucmin)
                    .HasMaxLength(100)
                    .HasColumnName("mtmucmin");

                entity.Property(e => e.Muccan).HasMaxLength(100);

                entity.Property(e => e.Mucmax).HasMaxLength(100);

                entity.Property(e => e.Mucmin).HasMaxLength(100);

                entity.Property(e => e.Muctailt)
                    .HasMaxLength(100)
                    .HasColumnName("muctailt");

                entity.Property(e => e.Mxl1dd)
                    .HasMaxLength(100)
                    .HasColumnName("mxl1dd");

                entity.Property(e => e.N1)
                    .HasMaxLength(100)
                    .HasColumnName("n1");

                entity.Property(e => e.N10)
                    .HasMaxLength(100)
                    .HasColumnName("n10");

                entity.Property(e => e.N11)
                    .HasMaxLength(100)
                    .HasColumnName("n11");

                entity.Property(e => e.N12)
                    .HasMaxLength(100)
                    .HasColumnName("n12");

                entity.Property(e => e.N13)
                    .HasMaxLength(100)
                    .HasColumnName("n13");

                entity.Property(e => e.N14)
                    .HasMaxLength(100)
                    .HasColumnName("n14");

                entity.Property(e => e.N15)
                    .HasMaxLength(100)
                    .HasColumnName("n15");

                entity.Property(e => e.N16)
                    .HasMaxLength(100)
                    .HasColumnName("n16");

                entity.Property(e => e.N17)
                    .HasMaxLength(100)
                    .HasColumnName("n17");

                entity.Property(e => e.N18)
                    .HasMaxLength(100)
                    .HasColumnName("n18");

                entity.Property(e => e.N19)
                    .HasMaxLength(100)
                    .HasColumnName("n19");

                entity.Property(e => e.N2)
                    .HasMaxLength(100)
                    .HasColumnName("n2");

                entity.Property(e => e.N20)
                    .HasMaxLength(100)
                    .HasColumnName("n20");

                entity.Property(e => e.N3)
                    .HasMaxLength(100)
                    .HasColumnName("n3");

                entity.Property(e => e.N4)
                    .HasMaxLength(100)
                    .HasColumnName("n4");

                entity.Property(e => e.N5)
                    .HasMaxLength(100)
                    .HasColumnName("n5");

                entity.Property(e => e.N6)
                    .HasMaxLength(100)
                    .HasColumnName("n6");

                entity.Property(e => e.N7)
                    .HasMaxLength(100)
                    .HasColumnName("n7");

                entity.Property(e => e.N8)
                    .HasMaxLength(100)
                    .HasColumnName("n8");

                entity.Property(e => e.N9)
                    .HasMaxLength(100)
                    .HasColumnName("n9");

                entity.Property(e => e.NamSx)
                    .HasMaxLength(100)
                    .HasColumnName("NamSX");

                entity.Property(e => e.Ngay).HasMaxLength(100);

                entity.Property(e => e.Nmxl1dd)
                    .HasMaxLength(100)
                    .HasColumnName("nmxl1dd");

                entity.Property(e => e.NuocSx)
                    .HasMaxLength(100)
                    .HasColumnName("NuocSX");

                entity.Property(e => e.P1maxll)
                    .HasMaxLength(100)
                    .HasColumnName("p1maxll");

                entity.Property(e => e.P1nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("p1nuamaxll");

                entity.Property(e => e.P2maxll)
                    .HasMaxLength(100)
                    .HasColumnName("p2maxll");

                entity.Property(e => e.P2nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("p2nuamaxll");

                entity.Property(e => e.P3maxll)
                    .HasMaxLength(100)
                    .HasColumnName("p3maxll");

                entity.Property(e => e.P3nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("p3nuamaxll");

                entity.Property(e => e.P4maxll)
                    .HasMaxLength(100)
                    .HasColumnName("p4maxll");

                entity.Property(e => e.P4nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("p4nuamaxll");

                entity.Property(e => e.P5maxll)
                    .HasMaxLength(100)
                    .HasColumnName("p5maxll");

                entity.Property(e => e.P5nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("p5nuamaxll");

                entity.Property(e => e.P6maxll)
                    .HasMaxLength(100)
                    .HasColumnName("p6maxll");

                entity.Property(e => e.P6nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("p6nuamaxll");

                entity.Property(e => e.Pimaxmin)
                    .HasMaxLength(100)
                    .HasColumnName("pimaxmin");

                entity.Property(e => e.Pjmaxmin)
                    .HasMaxLength(100)
                    .HasColumnName("pjmaxmin");

                entity.Property(e => e.Ppthuchien)
                    .HasMaxLength(100)
                    .HasColumnName("PPthuchien");

                entity.Property(e => e.Saisoe0mucmin)
                    .HasMaxLength(100)
                    .HasColumnName("saisoe0mucmin");

                entity.Property(e => e.So).HasMaxLength(100);

                entity.Property(e => e.Ss1lt)
                    .HasMaxLength(100)
                    .HasColumnName("ss1lt");

                entity.Property(e => e.Ss2lt)
                    .HasMaxLength(100)
                    .HasColumnName("ss2lt");

                entity.Property(e => e.Ss3lt)
                    .HasMaxLength(100)
                    .HasColumnName("ss3lt");

                entity.Property(e => e.Ss4lt)
                    .HasMaxLength(100)
                    .HasColumnName("ss4lt");

                entity.Property(e => e.Sscp1)
                    .HasMaxLength(100)
                    .HasColumnName("sscp1");

                entity.Property(e => e.Sscp2)
                    .HasMaxLength(100)
                    .HasColumnName("sscp2");

                entity.Property(e => e.Sscp3)
                    .HasMaxLength(100)
                    .HasColumnName("sscp3");

                entity.Property(e => e.Sscp4)
                    .HasMaxLength(100)
                    .HasColumnName("sscp4");

                entity.Property(e => e.Sscpg)
                    .HasMaxLength(100)
                    .HasColumnName("sscpg");

                entity.Property(e => e.Sscpmax)
                    .HasMaxLength(100)
                    .HasColumnName("sscpmax");

                entity.Property(e => e.Sscpmucmin)
                    .HasMaxLength(100)
                    .HasColumnName("sscpmucmin");

                entity.Property(e => e.Sscpnuamax)
                    .HasMaxLength(100)
                    .HasColumnName("sscpnuamax");

                entity.Property(e => e.Ssglt)
                    .HasMaxLength(100)
                    .HasColumnName("ssglt");

                entity.Property(e => e.Tenphuongtien).HasMaxLength(100);

                entity.Property(e => e.Themvao1p10dmax)
                    .HasMaxLength(100)
                    .HasColumnName("themvao1p10dmax");

                entity.Property(e => e.Themvao1p10dmin)
                    .HasMaxLength(100)
                    .HasColumnName("themvao1p10dmin");

                entity.Property(e => e.Themvao1p10dnuamax)
                    .HasMaxLength(100)
                    .HasColumnName("themvao1p10dnuamax");

                entity.Property(e => e.Themvao1p4dmax)
                    .HasMaxLength(100)
                    .HasColumnName("themvao1p4dmax");

                entity.Property(e => e.Themvao1p4dmin)
                    .HasMaxLength(100)
                    .HasColumnName("themvao1p4dmin");

                entity.Property(e => e.Themvao1p4dnuamax)
                    .HasMaxLength(100)
                    .HasColumnName("themvao1p4dnuamax");
            });

            modelBuilder.Entity<Tbcankythuat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbcankythuat");

                entity.Property(e => e.A1)
                    .HasMaxLength(100)
                    .HasColumnName("a1");

                entity.Property(e => e.A10)
                    .HasMaxLength(100)
                    .HasColumnName("a10");

                entity.Property(e => e.A11)
                    .HasMaxLength(100)
                    .HasColumnName("a11");

                entity.Property(e => e.A12)
                    .HasMaxLength(100)
                    .HasColumnName("a12");

                entity.Property(e => e.A13)
                    .HasMaxLength(100)
                    .HasColumnName("a13");

                entity.Property(e => e.A14)
                    .HasMaxLength(100)
                    .HasColumnName("a14");

                entity.Property(e => e.A15)
                    .HasMaxLength(100)
                    .HasColumnName("a15");

                entity.Property(e => e.A16)
                    .HasMaxLength(100)
                    .HasColumnName("a16");

                entity.Property(e => e.A17)
                    .HasMaxLength(100)
                    .HasColumnName("a17");

                entity.Property(e => e.A18)
                    .HasMaxLength(100)
                    .HasColumnName("a18");

                entity.Property(e => e.A19)
                    .HasMaxLength(100)
                    .HasColumnName("a19");

                entity.Property(e => e.A2)
                    .HasMaxLength(100)
                    .HasColumnName("a2");

                entity.Property(e => e.A20)
                    .HasMaxLength(100)
                    .HasColumnName("a20");

                entity.Property(e => e.A3)
                    .HasMaxLength(100)
                    .HasColumnName("a3");

                entity.Property(e => e.A4)
                    .HasMaxLength(100)
                    .HasColumnName("a4");

                entity.Property(e => e.A5)
                    .HasMaxLength(100)
                    .HasColumnName("a5");

                entity.Property(e => e.A6)
                    .HasMaxLength(100)
                    .HasColumnName("a6");

                entity.Property(e => e.A7)
                    .HasMaxLength(100)
                    .HasColumnName("a7");

                entity.Property(e => e.A8)
                    .HasMaxLength(100)
                    .HasColumnName("a8");

                entity.Property(e => e.A9)
                    .HasMaxLength(100)
                    .HasColumnName("a9");

                entity.Property(e => e.B1)
                    .HasMaxLength(100)
                    .HasColumnName("b1");

                entity.Property(e => e.B10)
                    .HasMaxLength(100)
                    .HasColumnName("b10");

                entity.Property(e => e.B11)
                    .HasMaxLength(100)
                    .HasColumnName("b11");

                entity.Property(e => e.B12)
                    .HasMaxLength(100)
                    .HasColumnName("b12");

                entity.Property(e => e.B13)
                    .HasMaxLength(100)
                    .HasColumnName("b13");

                entity.Property(e => e.B14)
                    .HasMaxLength(100)
                    .HasColumnName("b14");

                entity.Property(e => e.B15)
                    .HasMaxLength(100)
                    .HasColumnName("b15");

                entity.Property(e => e.B16)
                    .HasMaxLength(100)
                    .HasColumnName("b16");

                entity.Property(e => e.B17)
                    .HasMaxLength(100)
                    .HasColumnName("b17");

                entity.Property(e => e.B18)
                    .HasMaxLength(100)
                    .HasColumnName("b18");

                entity.Property(e => e.B19)
                    .HasMaxLength(100)
                    .HasColumnName("b19");

                entity.Property(e => e.B2)
                    .HasMaxLength(100)
                    .HasColumnName("b2");

                entity.Property(e => e.B20)
                    .HasMaxLength(100)
                    .HasColumnName("b20");

                entity.Property(e => e.B3)
                    .HasMaxLength(100)
                    .HasColumnName("b3");

                entity.Property(e => e.B4)
                    .HasMaxLength(100)
                    .HasColumnName("b4");

                entity.Property(e => e.B5)
                    .HasMaxLength(100)
                    .HasColumnName("b5");

                entity.Property(e => e.B6)
                    .HasMaxLength(100)
                    .HasColumnName("b6");

                entity.Property(e => e.B7)
                    .HasMaxLength(100)
                    .HasColumnName("b7");

                entity.Property(e => e.B8)
                    .HasMaxLength(100)
                    .HasColumnName("b8");

                entity.Property(e => e.B9)
                    .HasMaxLength(100)
                    .HasColumnName("b9");

                entity.Property(e => e.C1)
                    .HasMaxLength(100)
                    .HasColumnName("c1");

                entity.Property(e => e.C10)
                    .HasMaxLength(100)
                    .HasColumnName("c10");

                entity.Property(e => e.C11)
                    .HasMaxLength(100)
                    .HasColumnName("c11");

                entity.Property(e => e.C12)
                    .HasMaxLength(100)
                    .HasColumnName("c12");

                entity.Property(e => e.C13)
                    .HasMaxLength(100)
                    .HasColumnName("c13");

                entity.Property(e => e.C14)
                    .HasMaxLength(100)
                    .HasColumnName("c14");

                entity.Property(e => e.C15)
                    .HasMaxLength(100)
                    .HasColumnName("c15");

                entity.Property(e => e.C16)
                    .HasMaxLength(100)
                    .HasColumnName("c16");

                entity.Property(e => e.C17)
                    .HasMaxLength(100)
                    .HasColumnName("c17");

                entity.Property(e => e.C18)
                    .HasMaxLength(100)
                    .HasColumnName("c18");

                entity.Property(e => e.C19)
                    .HasMaxLength(100)
                    .HasColumnName("c19");

                entity.Property(e => e.C2)
                    .HasMaxLength(100)
                    .HasColumnName("c2");

                entity.Property(e => e.C20)
                    .HasMaxLength(100)
                    .HasColumnName("c20");

                entity.Property(e => e.C3)
                    .HasMaxLength(100)
                    .HasColumnName("c3");

                entity.Property(e => e.C4)
                    .HasMaxLength(100)
                    .HasColumnName("c4");

                entity.Property(e => e.C5)
                    .HasMaxLength(100)
                    .HasColumnName("c5");

                entity.Property(e => e.C6)
                    .HasMaxLength(100)
                    .HasColumnName("c6");

                entity.Property(e => e.C7)
                    .HasMaxLength(100)
                    .HasColumnName("c7");

                entity.Property(e => e.C8)
                    .HasMaxLength(100)
                    .HasColumnName("c8");

                entity.Property(e => e.C9)
                    .HasMaxLength(100)
                    .HasColumnName("c9");

                entity.Property(e => e.Capchinhxac).HasMaxLength(100);

                entity.Property(e => e.Chedokd).HasMaxLength(100);

                entity.Property(e => e.Chuantb).HasMaxLength(100);

                entity.Property(e => e.D1)
                    .HasMaxLength(100)
                    .HasColumnName("d1");

                entity.Property(e => e.D2)
                    .HasMaxLength(100)
                    .HasColumnName("d2");

                entity.Property(e => e.D3)
                    .HasMaxLength(100)
                    .HasColumnName("d3");

                entity.Property(e => e.D4)
                    .HasMaxLength(100)
                    .HasColumnName("d4");

                entity.Property(e => e.Delta1lt)
                    .HasMaxLength(100)
                    .HasColumnName("delta1lt");

                entity.Property(e => e.Delta1maxll)
                    .HasMaxLength(100)
                    .HasColumnName("delta1maxll");

                entity.Property(e => e.Delta1nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("delta1nuamax");

                entity.Property(e => e.Delta2lt)
                    .HasMaxLength(100)
                    .HasColumnName("delta2lt");

                entity.Property(e => e.Delta2maxll)
                    .HasMaxLength(100)
                    .HasColumnName("delta2maxll");

                entity.Property(e => e.Delta2nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("delta2nuamax");

                entity.Property(e => e.Delta3lt)
                    .HasMaxLength(100)
                    .HasColumnName("delta3lt");

                entity.Property(e => e.Delta3maxll)
                    .HasMaxLength(100)
                    .HasColumnName("delta3maxll");

                entity.Property(e => e.Delta3nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("delta3nuamax");

                entity.Property(e => e.Delta4lt)
                    .HasMaxLength(100)
                    .HasColumnName("delta4lt");

                entity.Property(e => e.Delta4maxll)
                    .HasMaxLength(100)
                    .HasColumnName("delta4maxll");

                entity.Property(e => e.Delta4nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("delta4nuamax");

                entity.Property(e => e.Delta5maxll)
                    .HasMaxLength(100)
                    .HasColumnName("delta5maxll");

                entity.Property(e => e.Delta5nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("delta5nuamax");

                entity.Property(e => e.Delta6maxll)
                    .HasMaxLength(100)
                    .HasColumnName("delta6maxll");

                entity.Property(e => e.Delta6nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("delta6nuamax");

                entity.Property(e => e.Deltaglt)
                    .HasMaxLength(100)
                    .HasColumnName("deltaglt");

                entity.Property(e => e.Diachisd).HasMaxLength(100);

                entity.Property(e => e.Dkmt).HasMaxLength(100);

                entity.Property(e => e.Donvisd).HasMaxLength(100);

                entity.Property(e => e.E1)
                    .HasMaxLength(100)
                    .HasColumnName("e1");

                entity.Property(e => e.E2)
                    .HasMaxLength(100)
                    .HasColumnName("e2");

                entity.Property(e => e.E3)
                    .HasMaxLength(100)
                    .HasColumnName("e3");

                entity.Property(e => e.E4)
                    .HasMaxLength(100)
                    .HasColumnName("e4");

                entity.Property(e => e.Ec1lt)
                    .HasMaxLength(100)
                    .HasColumnName("ec1lt");

                entity.Property(e => e.Ec2lt)
                    .HasMaxLength(100)
                    .HasColumnName("ec2lt");

                entity.Property(e => e.Ec3lt)
                    .HasMaxLength(100)
                    .HasColumnName("ec3lt");

                entity.Property(e => e.Ec4lt)
                    .HasMaxLength(100)
                    .HasColumnName("ec4lt");

                entity.Property(e => e.Ecglt)
                    .HasMaxLength(100)
                    .HasColumnName("ecglt");

                entity.Property(e => e.G1)
                    .HasMaxLength(100)
                    .HasColumnName("g1");

                entity.Property(e => e.G10)
                    .HasMaxLength(100)
                    .HasColumnName("g10");

                entity.Property(e => e.G11)
                    .HasMaxLength(100)
                    .HasColumnName("g11");

                entity.Property(e => e.G12)
                    .HasMaxLength(100)
                    .HasColumnName("g12");

                entity.Property(e => e.G13)
                    .HasMaxLength(100)
                    .HasColumnName("g13");

                entity.Property(e => e.G14)
                    .HasMaxLength(100)
                    .HasColumnName("g14");

                entity.Property(e => e.G15)
                    .HasMaxLength(100)
                    .HasColumnName("g15");

                entity.Property(e => e.G16)
                    .HasMaxLength(100)
                    .HasColumnName("g16");

                entity.Property(e => e.G17)
                    .HasMaxLength(100)
                    .HasColumnName("g17");

                entity.Property(e => e.G18)
                    .HasMaxLength(100)
                    .HasColumnName("g18");

                entity.Property(e => e.G19)
                    .HasMaxLength(100)
                    .HasColumnName("g19");

                entity.Property(e => e.G2)
                    .HasMaxLength(100)
                    .HasColumnName("g2");

                entity.Property(e => e.G20)
                    .HasMaxLength(100)
                    .HasColumnName("g20");

                entity.Property(e => e.G3)
                    .HasMaxLength(100)
                    .HasColumnName("g3");

                entity.Property(e => e.G4)
                    .HasMaxLength(100)
                    .HasColumnName("g4");

                entity.Property(e => e.G5)
                    .HasMaxLength(100)
                    .HasColumnName("g5");

                entity.Property(e => e.G6)
                    .HasMaxLength(100)
                    .HasColumnName("g6");

                entity.Property(e => e.G7)
                    .HasMaxLength(100)
                    .HasColumnName("g7");

                entity.Property(e => e.G8)
                    .HasMaxLength(100)
                    .HasColumnName("g8");

                entity.Property(e => e.G9)
                    .HasMaxLength(100)
                    .HasColumnName("g9");

                entity.Property(e => e.Glt)
                    .HasMaxLength(100)
                    .HasColumnName("glt");

                entity.Property(e => e.Gmucmin)
                    .HasMaxLength(100)
                    .HasColumnName("gmucmin");

                entity.Property(e => e.H1)
                    .HasMaxLength(100)
                    .HasColumnName("h1");

                entity.Property(e => e.H10)
                    .HasMaxLength(100)
                    .HasColumnName("h10");

                entity.Property(e => e.H11)
                    .HasMaxLength(100)
                    .HasColumnName("h11");

                entity.Property(e => e.H12)
                    .HasMaxLength(100)
                    .HasColumnName("h12");

                entity.Property(e => e.H13)
                    .HasMaxLength(100)
                    .HasColumnName("h13");

                entity.Property(e => e.H14)
                    .HasMaxLength(100)
                    .HasColumnName("h14");

                entity.Property(e => e.H15)
                    .HasMaxLength(100)
                    .HasColumnName("h15");

                entity.Property(e => e.H16)
                    .HasMaxLength(100)
                    .HasColumnName("h16");

                entity.Property(e => e.H17)
                    .HasMaxLength(100)
                    .HasColumnName("h17");

                entity.Property(e => e.H18)
                    .HasMaxLength(100)
                    .HasColumnName("h18");

                entity.Property(e => e.H19)
                    .HasMaxLength(100)
                    .HasColumnName("h19");

                entity.Property(e => e.H2)
                    .HasMaxLength(100)
                    .HasColumnName("h2");

                entity.Property(e => e.H20)
                    .HasMaxLength(100)
                    .HasColumnName("h20");

                entity.Property(e => e.H3)
                    .HasMaxLength(100)
                    .HasColumnName("h3");

                entity.Property(e => e.H4)
                    .HasMaxLength(100)
                    .HasColumnName("h4");

                entity.Property(e => e.H5)
                    .HasMaxLength(100)
                    .HasColumnName("h5");

                entity.Property(e => e.H6)
                    .HasMaxLength(100)
                    .HasColumnName("h6");

                entity.Property(e => e.H7)
                    .HasMaxLength(100)
                    .HasColumnName("h7");

                entity.Property(e => e.H8)
                    .HasMaxLength(100)
                    .HasColumnName("h8");

                entity.Property(e => e.H9)
                    .HasMaxLength(100)
                    .HasColumnName("h9");

                entity.Property(e => e.I1)
                    .HasMaxLength(100)
                    .HasColumnName("i1");

                entity.Property(e => e.I10)
                    .HasMaxLength(100)
                    .HasColumnName("i10");

                entity.Property(e => e.I11)
                    .HasMaxLength(100)
                    .HasColumnName("i11");

                entity.Property(e => e.I12)
                    .HasMaxLength(100)
                    .HasColumnName("i12");

                entity.Property(e => e.I13)
                    .HasMaxLength(100)
                    .HasColumnName("i13");

                entity.Property(e => e.I14)
                    .HasMaxLength(100)
                    .HasColumnName("i14");

                entity.Property(e => e.I15)
                    .HasMaxLength(100)
                    .HasColumnName("i15");

                entity.Property(e => e.I16)
                    .HasMaxLength(100)
                    .HasColumnName("i16");

                entity.Property(e => e.I17)
                    .HasMaxLength(100)
                    .HasColumnName("i17");

                entity.Property(e => e.I18)
                    .HasMaxLength(100)
                    .HasColumnName("i18");

                entity.Property(e => e.I19)
                    .HasMaxLength(100)
                    .HasColumnName("i19");

                entity.Property(e => e.I1maxll)
                    .HasMaxLength(100)
                    .HasColumnName("i1maxll");

                entity.Property(e => e.I1nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("i1nuamaxll");

                entity.Property(e => e.I2)
                    .HasMaxLength(100)
                    .HasColumnName("i2");

                entity.Property(e => e.I20)
                    .HasMaxLength(100)
                    .HasColumnName("i20");

                entity.Property(e => e.I2max)
                    .HasMaxLength(100)
                    .HasColumnName("i2max");

                entity.Property(e => e.I2maxll)
                    .HasMaxLength(100)
                    .HasColumnName("i2maxll");

                entity.Property(e => e.I2min)
                    .HasMaxLength(100)
                    .HasColumnName("i2min");

                entity.Property(e => e.I2nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("i2nuamax");

                entity.Property(e => e.I2nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("i2nuamaxll");

                entity.Property(e => e.I2ti1)
                    .HasMaxLength(100)
                    .HasColumnName("i2ti1");

                entity.Property(e => e.I2ti1max)
                    .HasMaxLength(100)
                    .HasColumnName("i2ti1max");

                entity.Property(e => e.I2ti1nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("i2ti1nuamax");

                entity.Property(e => e.I3)
                    .HasMaxLength(100)
                    .HasColumnName("i3");

                entity.Property(e => e.I3maxll)
                    .HasMaxLength(100)
                    .HasColumnName("i3maxll");

                entity.Property(e => e.I3nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("i3nuamaxll");

                entity.Property(e => e.I4)
                    .HasMaxLength(100)
                    .HasColumnName("i4");

                entity.Property(e => e.I4maxll)
                    .HasMaxLength(100)
                    .HasColumnName("i4maxll");

                entity.Property(e => e.I4nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("i4nuamaxll");

                entity.Property(e => e.I5)
                    .HasMaxLength(100)
                    .HasColumnName("i5");

                entity.Property(e => e.I5maxll)
                    .HasMaxLength(100)
                    .HasColumnName("i5maxll");

                entity.Property(e => e.I5nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("i5nuamaxll");

                entity.Property(e => e.I6)
                    .HasMaxLength(100)
                    .HasColumnName("i6");

                entity.Property(e => e.I6maxll)
                    .HasMaxLength(100)
                    .HasColumnName("i6maxll");

                entity.Property(e => e.I6nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("i6nuamaxll");

                entity.Property(e => e.I7)
                    .HasMaxLength(100)
                    .HasColumnName("i7");

                entity.Property(e => e.I8)
                    .HasMaxLength(100)
                    .HasColumnName("i8");

                entity.Property(e => e.I9)
                    .HasMaxLength(100)
                    .HasColumnName("i9");

                entity.Property(e => e.Imucmin)
                    .HasMaxLength(100)
                    .HasColumnName("imucmin");

                entity.Property(e => e.K1)
                    .HasMaxLength(100)
                    .HasColumnName("k1");

                entity.Property(e => e.K10)
                    .HasMaxLength(100)
                    .HasColumnName("k10");

                entity.Property(e => e.K11)
                    .HasMaxLength(100)
                    .HasColumnName("k11");

                entity.Property(e => e.K12)
                    .HasMaxLength(100)
                    .HasColumnName("k12");

                entity.Property(e => e.K13)
                    .HasMaxLength(100)
                    .HasColumnName("k13");

                entity.Property(e => e.K14)
                    .HasMaxLength(100)
                    .HasColumnName("k14");

                entity.Property(e => e.K15)
                    .HasMaxLength(100)
                    .HasColumnName("k15");

                entity.Property(e => e.K16)
                    .HasMaxLength(100)
                    .HasColumnName("k16");

                entity.Property(e => e.K17)
                    .HasMaxLength(100)
                    .HasColumnName("k17");

                entity.Property(e => e.K18)
                    .HasMaxLength(100)
                    .HasColumnName("k18");

                entity.Property(e => e.K19)
                    .HasMaxLength(100)
                    .HasColumnName("k19");

                entity.Property(e => e.K2)
                    .HasMaxLength(100)
                    .HasColumnName("k2");

                entity.Property(e => e.K20)
                    .HasMaxLength(100)
                    .HasColumnName("k20");

                entity.Property(e => e.K3)
                    .HasMaxLength(100)
                    .HasColumnName("k3");

                entity.Property(e => e.K4)
                    .HasMaxLength(100)
                    .HasColumnName("k4");

                entity.Property(e => e.K5)
                    .HasMaxLength(100)
                    .HasColumnName("k5");

                entity.Property(e => e.K6)
                    .HasMaxLength(100)
                    .HasColumnName("k6");

                entity.Property(e => e.K7)
                    .HasMaxLength(100)
                    .HasColumnName("k7");

                entity.Property(e => e.K8)
                    .HasMaxLength(100)
                    .HasColumnName("k8");

                entity.Property(e => e.K9)
                    .HasMaxLength(100)
                    .HasColumnName("k9");

                entity.Property(e => e.Kiemdinhvien).HasMaxLength(100);

                entity.Property(e => e.Kieu).HasMaxLength(100);

                entity.Property(e => e.L1)
                    .HasMaxLength(100)
                    .HasColumnName("l1");

                entity.Property(e => e.L10)
                    .HasMaxLength(100)
                    .HasColumnName("l10");

                entity.Property(e => e.L11)
                    .HasMaxLength(100)
                    .HasColumnName("l11");

                entity.Property(e => e.L12)
                    .HasMaxLength(100)
                    .HasColumnName("l12");

                entity.Property(e => e.L13)
                    .HasMaxLength(100)
                    .HasColumnName("l13");

                entity.Property(e => e.L14)
                    .HasMaxLength(100)
                    .HasColumnName("l14");

                entity.Property(e => e.L15)
                    .HasMaxLength(100)
                    .HasColumnName("l15");

                entity.Property(e => e.L16)
                    .HasMaxLength(100)
                    .HasColumnName("l16");

                entity.Property(e => e.L17)
                    .HasMaxLength(100)
                    .HasColumnName("l17");

                entity.Property(e => e.L18)
                    .HasMaxLength(100)
                    .HasColumnName("l18");

                entity.Property(e => e.L19)
                    .HasMaxLength(100)
                    .HasColumnName("l19");

                entity.Property(e => e.L1lt)
                    .HasMaxLength(100)
                    .HasColumnName("l1lt");

                entity.Property(e => e.L2)
                    .HasMaxLength(100)
                    .HasColumnName("l2");

                entity.Property(e => e.L20)
                    .HasMaxLength(100)
                    .HasColumnName("l20");

                entity.Property(e => e.L2lt)
                    .HasMaxLength(100)
                    .HasColumnName("l2lt");

                entity.Property(e => e.L3)
                    .HasMaxLength(100)
                    .HasColumnName("l3");

                entity.Property(e => e.L3lt)
                    .HasMaxLength(100)
                    .HasColumnName("l3lt");

                entity.Property(e => e.L4)
                    .HasMaxLength(100)
                    .HasColumnName("l4");

                entity.Property(e => e.L4lt)
                    .HasMaxLength(100)
                    .HasColumnName("l4lt");

                entity.Property(e => e.L5)
                    .HasMaxLength(100)
                    .HasColumnName("l5");

                entity.Property(e => e.L6)
                    .HasMaxLength(100)
                    .HasColumnName("l6");

                entity.Property(e => e.L7)
                    .HasMaxLength(100)
                    .HasColumnName("l7");

                entity.Property(e => e.L8)
                    .HasMaxLength(100)
                    .HasColumnName("l8");

                entity.Property(e => e.L9)
                    .HasMaxLength(100)
                    .HasColumnName("l9");

                entity.Property(e => e.Layrannmax)
                    .HasMaxLength(100)
                    .HasColumnName("layrannmax");

                entity.Property(e => e.Layrannmin)
                    .HasMaxLength(100)
                    .HasColumnName("layrannmin");

                entity.Property(e => e.Layrannnuamax)
                    .HasMaxLength(100)
                    .HasColumnName("layrannnuamax");

                entity.Property(e => e.M1)
                    .HasMaxLength(100)
                    .HasColumnName("m1");

                entity.Property(e => e.M10)
                    .HasMaxLength(100)
                    .HasColumnName("m10");

                entity.Property(e => e.M11)
                    .HasMaxLength(100)
                    .HasColumnName("m11");

                entity.Property(e => e.M12)
                    .HasMaxLength(100)
                    .HasColumnName("m12");

                entity.Property(e => e.M13)
                    .HasMaxLength(100)
                    .HasColumnName("m13");

                entity.Property(e => e.M14)
                    .HasMaxLength(100)
                    .HasColumnName("m14");

                entity.Property(e => e.M15)
                    .HasMaxLength(100)
                    .HasColumnName("m15");

                entity.Property(e => e.M16)
                    .HasMaxLength(100)
                    .HasColumnName("m16");

                entity.Property(e => e.M17)
                    .HasMaxLength(100)
                    .HasColumnName("m17");

                entity.Property(e => e.M18)
                    .HasMaxLength(100)
                    .HasColumnName("m18");

                entity.Property(e => e.M19)
                    .HasMaxLength(100)
                    .HasColumnName("m19");

                entity.Property(e => e.M2)
                    .HasMaxLength(100)
                    .HasColumnName("m2");

                entity.Property(e => e.M20)
                    .HasMaxLength(100)
                    .HasColumnName("m20");

                entity.Property(e => e.M3)
                    .HasMaxLength(100)
                    .HasColumnName("m3");

                entity.Property(e => e.M4)
                    .HasMaxLength(100)
                    .HasColumnName("m4");

                entity.Property(e => e.M5)
                    .HasMaxLength(100)
                    .HasColumnName("m5");

                entity.Property(e => e.M6)
                    .HasMaxLength(100)
                    .HasColumnName("m6");

                entity.Property(e => e.M7)
                    .HasMaxLength(100)
                    .HasColumnName("m7");

                entity.Property(e => e.M8)
                    .HasMaxLength(100)
                    .HasColumnName("m8");

                entity.Property(e => e.M9)
                    .HasMaxLength(100)
                    .HasColumnName("m9");

                entity.Property(e => e.Maqd).HasMaxLength(100);

                entity.Property(e => e.Max1)
                    .HasMaxLength(100)
                    .HasColumnName("max1");

                entity.Property(e => e.Max2)
                    .HasMaxLength(100)
                    .HasColumnName("max2");

                entity.Property(e => e.Max3)
                    .HasMaxLength(100)
                    .HasColumnName("max3");

                entity.Property(e => e.Max4)
                    .HasMaxLength(100)
                    .HasColumnName("max4");

                entity.Property(e => e.Mil1dd)
                    .HasMaxLength(100)
                    .HasColumnName("mil1dd");

                entity.Property(e => e.Mtmucmin)
                    .HasMaxLength(100)
                    .HasColumnName("mtmucmin");

                entity.Property(e => e.Muccan).HasMaxLength(100);

                entity.Property(e => e.Mucmax).HasMaxLength(100);

                entity.Property(e => e.Mucmin).HasMaxLength(100);

                entity.Property(e => e.Muctailt)
                    .HasMaxLength(100)
                    .HasColumnName("muctailt");

                entity.Property(e => e.Mxl1dd)
                    .HasMaxLength(100)
                    .HasColumnName("mxl1dd");

                entity.Property(e => e.N1)
                    .HasMaxLength(100)
                    .HasColumnName("n1");

                entity.Property(e => e.N10)
                    .HasMaxLength(100)
                    .HasColumnName("n10");

                entity.Property(e => e.N11)
                    .HasMaxLength(100)
                    .HasColumnName("n11");

                entity.Property(e => e.N12)
                    .HasMaxLength(100)
                    .HasColumnName("n12");

                entity.Property(e => e.N13)
                    .HasMaxLength(100)
                    .HasColumnName("n13");

                entity.Property(e => e.N14)
                    .HasMaxLength(100)
                    .HasColumnName("n14");

                entity.Property(e => e.N15)
                    .HasMaxLength(100)
                    .HasColumnName("n15");

                entity.Property(e => e.N16)
                    .HasMaxLength(100)
                    .HasColumnName("n16");

                entity.Property(e => e.N17)
                    .HasMaxLength(100)
                    .HasColumnName("n17");

                entity.Property(e => e.N18)
                    .HasMaxLength(100)
                    .HasColumnName("n18");

                entity.Property(e => e.N19)
                    .HasMaxLength(100)
                    .HasColumnName("n19");

                entity.Property(e => e.N2)
                    .HasMaxLength(100)
                    .HasColumnName("n2");

                entity.Property(e => e.N20)
                    .HasMaxLength(100)
                    .HasColumnName("n20");

                entity.Property(e => e.N3)
                    .HasMaxLength(100)
                    .HasColumnName("n3");

                entity.Property(e => e.N4)
                    .HasMaxLength(100)
                    .HasColumnName("n4");

                entity.Property(e => e.N5)
                    .HasMaxLength(100)
                    .HasColumnName("n5");

                entity.Property(e => e.N6)
                    .HasMaxLength(100)
                    .HasColumnName("n6");

                entity.Property(e => e.N7)
                    .HasMaxLength(100)
                    .HasColumnName("n7");

                entity.Property(e => e.N8)
                    .HasMaxLength(100)
                    .HasColumnName("n8");

                entity.Property(e => e.N9)
                    .HasMaxLength(100)
                    .HasColumnName("n9");

                entity.Property(e => e.NamSx)
                    .HasMaxLength(100)
                    .HasColumnName("NamSX");

                entity.Property(e => e.Ngay).HasMaxLength(100);

                entity.Property(e => e.Nmxl1dd)
                    .HasMaxLength(100)
                    .HasColumnName("nmxl1dd");

                entity.Property(e => e.NuocSx)
                    .HasMaxLength(100)
                    .HasColumnName("NuocSX");

                entity.Property(e => e.P1maxll)
                    .HasMaxLength(100)
                    .HasColumnName("p1maxll");

                entity.Property(e => e.P1nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("p1nuamaxll");

                entity.Property(e => e.P2maxll)
                    .HasMaxLength(100)
                    .HasColumnName("p2maxll");

                entity.Property(e => e.P2nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("p2nuamaxll");

                entity.Property(e => e.P3maxll)
                    .HasMaxLength(100)
                    .HasColumnName("p3maxll");

                entity.Property(e => e.P3nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("p3nuamaxll");

                entity.Property(e => e.P4maxll)
                    .HasMaxLength(100)
                    .HasColumnName("p4maxll");

                entity.Property(e => e.P4nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("p4nuamaxll");

                entity.Property(e => e.P5maxll)
                    .HasMaxLength(100)
                    .HasColumnName("p5maxll");

                entity.Property(e => e.P5nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("p5nuamaxll");

                entity.Property(e => e.P6maxll)
                    .HasMaxLength(100)
                    .HasColumnName("p6maxll");

                entity.Property(e => e.P6nuamaxll)
                    .HasMaxLength(100)
                    .HasColumnName("p6nuamaxll");

                entity.Property(e => e.Pimaxmin)
                    .HasMaxLength(100)
                    .HasColumnName("pimaxmin");

                entity.Property(e => e.Pjmaxmin)
                    .HasMaxLength(100)
                    .HasColumnName("pjmaxmin");

                entity.Property(e => e.Ppthuchien)
                    .HasMaxLength(100)
                    .HasColumnName("PPthuchien");

                entity.Property(e => e.Saisoe0mucmin)
                    .HasMaxLength(100)
                    .HasColumnName("saisoe0mucmin");

                entity.Property(e => e.So).HasMaxLength(100);

                entity.Property(e => e.Ss1lt)
                    .HasMaxLength(100)
                    .HasColumnName("ss1lt");

                entity.Property(e => e.Ss2lt)
                    .HasMaxLength(100)
                    .HasColumnName("ss2lt");

                entity.Property(e => e.Ss3lt)
                    .HasMaxLength(100)
                    .HasColumnName("ss3lt");

                entity.Property(e => e.Ss4lt)
                    .HasMaxLength(100)
                    .HasColumnName("ss4lt");

                entity.Property(e => e.Sscp1)
                    .HasMaxLength(100)
                    .HasColumnName("sscp1");

                entity.Property(e => e.Sscp2)
                    .HasMaxLength(100)
                    .HasColumnName("sscp2");

                entity.Property(e => e.Sscp3)
                    .HasMaxLength(100)
                    .HasColumnName("sscp3");

                entity.Property(e => e.Sscp4)
                    .HasMaxLength(100)
                    .HasColumnName("sscp4");

                entity.Property(e => e.Sscpg)
                    .HasMaxLength(100)
                    .HasColumnName("sscpg");

                entity.Property(e => e.Sscpmax)
                    .HasMaxLength(100)
                    .HasColumnName("sscpmax");

                entity.Property(e => e.Sscpmucmin)
                    .HasMaxLength(100)
                    .HasColumnName("sscpmucmin");

                entity.Property(e => e.Sscpnuamax)
                    .HasMaxLength(100)
                    .HasColumnName("sscpnuamax");

                entity.Property(e => e.Ssglt)
                    .HasMaxLength(100)
                    .HasColumnName("ssglt");

                entity.Property(e => e.Tenphuongtien).HasMaxLength(100);

                entity.Property(e => e.Themvao1p10dmax)
                    .HasMaxLength(100)
                    .HasColumnName("themvao1p10dmax");

                entity.Property(e => e.Themvao1p10dmin)
                    .HasMaxLength(100)
                    .HasColumnName("themvao1p10dmin");

                entity.Property(e => e.Themvao1p10dnuamax)
                    .HasMaxLength(100)
                    .HasColumnName("themvao1p10dnuamax");

                entity.Property(e => e.Themvao1p4dmax)
                    .HasMaxLength(100)
                    .HasColumnName("themvao1p4dmax");

                entity.Property(e => e.Themvao1p4dmin)
                    .HasMaxLength(100)
                    .HasColumnName("themvao1p4dmin");

                entity.Property(e => e.Themvao1p4dnuamax)
                    .HasMaxLength(100)
                    .HasColumnName("themvao1p4dnuamax");
            });

            modelBuilder.Entity<Tbcankythuat1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbcankythuat1");

                entity.Property(e => e.Capchinhxac).HasMaxLength(100);

                entity.Property(e => e.Chedokd).HasMaxLength(100);

                entity.Property(e => e.Chuantb).HasMaxLength(100);

                entity.Property(e => e.D1)
                    .HasMaxLength(100)
                    .HasColumnName("d1");

                entity.Property(e => e.D2)
                    .HasMaxLength(100)
                    .HasColumnName("d2");

                entity.Property(e => e.D3)
                    .HasMaxLength(100)
                    .HasColumnName("d3");

                entity.Property(e => e.D4)
                    .HasMaxLength(100)
                    .HasColumnName("d4");

                entity.Property(e => e.Diachisd).HasMaxLength(100);

                entity.Property(e => e.Dkmt).HasMaxLength(100);

                entity.Property(e => e.Donvisd).HasMaxLength(100);

                entity.Property(e => e.E1)
                    .HasMaxLength(100)
                    .HasColumnName("e1");

                entity.Property(e => e.E2)
                    .HasMaxLength(100)
                    .HasColumnName("e2");

                entity.Property(e => e.E3)
                    .HasMaxLength(100)
                    .HasColumnName("e3");

                entity.Property(e => e.E4)
                    .HasMaxLength(100)
                    .HasColumnName("e4");

                entity.Property(e => e.Kiemdinhvien).HasMaxLength(100);

                entity.Property(e => e.Kieu).HasMaxLength(100);

                entity.Property(e => e.Maqd).HasMaxLength(100);

                entity.Property(e => e.Max1)
                    .HasMaxLength(100)
                    .HasColumnName("max1");

                entity.Property(e => e.Max2)
                    .HasMaxLength(100)
                    .HasColumnName("max2");

                entity.Property(e => e.Max3)
                    .HasMaxLength(100)
                    .HasColumnName("max3");

                entity.Property(e => e.Max4)
                    .HasMaxLength(100)
                    .HasColumnName("max4");

                entity.Property(e => e.Muccan).HasMaxLength(100);

                entity.Property(e => e.Mucmax).HasMaxLength(100);

                entity.Property(e => e.Mucmin).HasMaxLength(100);

                entity.Property(e => e.NamSx)
                    .HasMaxLength(100)
                    .HasColumnName("NamSX");

                entity.Property(e => e.Ngay).HasMaxLength(100);

                entity.Property(e => e.NuocSx)
                    .HasMaxLength(100)
                    .HasColumnName("NuocSX");

                entity.Property(e => e.Ppthuchien)
                    .HasMaxLength(100)
                    .HasColumnName("PPthuchien");

                entity.Property(e => e.So).HasMaxLength(100);

                entity.Property(e => e.Tenphuongtien).HasMaxLength(100);
            });

            modelBuilder.Entity<Tbcanphantich>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbcanphantich");

                entity.Property(e => e.Capchinhxac).HasMaxLength(100);

                entity.Property(e => e.Chedokd).HasMaxLength(100);

                entity.Property(e => e.Diachisd).HasMaxLength(100);

                entity.Property(e => e.Dkmoitruong).HasMaxLength(100);

                entity.Property(e => e.Dochia).HasMaxLength(100);

                entity.Property(e => e.Dochiadiem).HasMaxLength(100);

                entity.Property(e => e.Donvisd).HasMaxLength(100);

                entity.Property(e => e.Giami1)
                    .HasMaxLength(100)
                    .HasColumnName("giami1");

                entity.Property(e => e.Giami2)
                    .HasMaxLength(100)
                    .HasColumnName("giami2");

                entity.Property(e => e.Giami3)
                    .HasMaxLength(100)
                    .HasColumnName("giami3");

                entity.Property(e => e.Giami4)
                    .HasMaxLength(100)
                    .HasColumnName("giami4");

                entity.Property(e => e.I1ll1)
                    .HasMaxLength(100)
                    .HasColumnName("i1ll1");

                entity.Property(e => e.I1ll2)
                    .HasMaxLength(100)
                    .HasColumnName("i1ll2");

                entity.Property(e => e.I1ll3)
                    .HasMaxLength(100)
                    .HasColumnName("i1ll3");

                entity.Property(e => e.I1ll4)
                    .HasMaxLength(100)
                    .HasColumnName("i1ll4");

                entity.Property(e => e.I1ll5)
                    .HasMaxLength(100)
                    .HasColumnName("i1ll5");

                entity.Property(e => e.I1ll6)
                    .HasMaxLength(100)
                    .HasColumnName("i1ll6");

                entity.Property(e => e.I1lt)
                    .HasMaxLength(100)
                    .HasColumnName("i1lt");

                entity.Property(e => e.I1max)
                    .HasMaxLength(100)
                    .HasColumnName("i1max");

                entity.Property(e => e.I1min)
                    .HasMaxLength(100)
                    .HasColumnName("i1min");

                entity.Property(e => e.I1nuamax)
                    .HasMaxLength(100)
                    .HasColumnName("i1nuamax");

                entity.Property(e => e.I2ll1)
                    .HasMaxLength(100)
                    .HasColumnName("i2ll1");

                entity.Property(e => e.I2ll2)
                    .HasMaxLength(100)
                    .HasColumnName("i2ll2");

                entity.Property(e => e.I2ll3)
                    .HasMaxLength(100)
                    .HasColumnName("i2ll3");

                entity.Property(e => e.I2ll4)
                    .HasMaxLength(100)
                    .HasColumnName("i2ll4");

                entity.Property(e => e.I2ll5)
                    .HasMaxLength(100)
                    .HasColumnName("i2ll5");

                entity.Property(e => e.I2ll6)
                    .HasMaxLength(100)
                    .HasColumnName("i2ll6");

                entity.Property(e => e.I2lt)
                    .HasMaxLength(100)
                    .HasColumnName("i2lt");

                entity.Property(e => e.I3lt)
                    .HasMaxLength(100)
                    .HasColumnName("i3lt");

                entity.Property(e => e.I4lt)
                    .HasMaxLength(100)
                    .HasColumnName("i4lt");

                entity.Property(e => e.Iglt)
                    .HasMaxLength(100)
                    .HasColumnName("iglt");

                entity.Property(e => e.Kiemdinhvien).HasMaxLength(100);

                entity.Property(e => e.Kieu).HasMaxLength(100);

                entity.Property(e => e.Ktchitiet).HasColumnName("KTchitiet");

                entity.Property(e => e.Ktdaydu).HasColumnName("KTdaydu");

                entity.Property(e => e.Ktdongho).HasColumnName("KTdongho");

                entity.Property(e => e.Ktnhan).HasColumnName("KTnhan");

                entity.Property(e => e.Maqd).HasMaxLength(100);

                entity.Property(e => e.Mtlt)
                    .HasMaxLength(100)
                    .HasColumnName("mtlt");

                entity.Property(e => e.Mucmax).HasMaxLength(100);

                entity.Property(e => e.Mucmin).HasMaxLength(100);

                entity.Property(e => e.NamSx)
                    .HasMaxLength(100)
                    .HasColumnName("NamSX");

                entity.Property(e => e.Ngay).HasMaxLength(100);

                entity.Property(e => e.NuocSx)
                    .HasMaxLength(100)
                    .HasColumnName("NuocSX");

                entity.Property(e => e.P1ll1)
                    .HasMaxLength(100)
                    .HasColumnName("p1ll1");

                entity.Property(e => e.P1ll2)
                    .HasMaxLength(100)
                    .HasColumnName("p1ll2");

                entity.Property(e => e.P1ll3)
                    .HasMaxLength(100)
                    .HasColumnName("p1ll3");

                entity.Property(e => e.P1ll4)
                    .HasMaxLength(100)
                    .HasColumnName("p1ll4");

                entity.Property(e => e.P1ll5)
                    .HasMaxLength(100)
                    .HasColumnName("p1ll5");

                entity.Property(e => e.P1ll6)
                    .HasMaxLength(100)
                    .HasColumnName("p1ll6");

                entity.Property(e => e.P1maxtmin)
                    .HasMaxLength(100)
                    .HasColumnName("p1maxtmin");

                entity.Property(e => e.P2ll1)
                    .HasMaxLength(100)
                    .HasColumnName("p2ll1");

                entity.Property(e => e.P2ll2)
                    .HasMaxLength(100)
                    .HasColumnName("p2ll2");

                entity.Property(e => e.P2ll3)
                    .HasMaxLength(100)
                    .HasColumnName("p2ll3");

                entity.Property(e => e.P2ll4)
                    .HasMaxLength(100)
                    .HasColumnName("p2ll4");

                entity.Property(e => e.P2ll5)
                    .HasMaxLength(100)
                    .HasColumnName("p2ll5");

                entity.Property(e => e.P2ll6)
                    .HasMaxLength(100)
                    .HasColumnName("p2ll6");

                entity.Property(e => e.P2maxtmin)
                    .HasMaxLength(100)
                    .HasColumnName("p2maxtmin");

                entity.Property(e => e.Ppthuchien)
                    .HasMaxLength(100)
                    .HasColumnName("PPthuchien");

                entity.Property(e => e.So).HasMaxLength(100);

                entity.Property(e => e.Sscp1)
                    .HasMaxLength(100)
                    .HasColumnName("sscp1");

                entity.Property(e => e.Sscp1lt)
                    .HasMaxLength(100)
                    .HasColumnName("sscp1lt");

                entity.Property(e => e.Sscp2)
                    .HasMaxLength(100)
                    .HasColumnName("sscp2");

                entity.Property(e => e.Sscp2lt)
                    .HasMaxLength(100)
                    .HasColumnName("sscp2lt");

                entity.Property(e => e.Sscp3lt)
                    .HasMaxLength(100)
                    .HasColumnName("sscp3lt");

                entity.Property(e => e.Sscp4lt)
                    .HasMaxLength(100)
                    .HasColumnName("sscp4lt");

                entity.Property(e => e.Sscpglt)
                    .HasMaxLength(100)
                    .HasColumnName("sscpglt");

                entity.Property(e => e.Sscpmt1)
                    .HasMaxLength(100)
                    .HasColumnName("sscpmt1");

                entity.Property(e => e.Sscpmt2)
                    .HasMaxLength(100)
                    .HasColumnName("sscpmt2");

                entity.Property(e => e.Sscpmt3)
                    .HasMaxLength(100)
                    .HasColumnName("sscpmt3");

                entity.Property(e => e.Sscpmt4)
                    .HasMaxLength(100)
                    .HasColumnName("sscpmt4");

                entity.Property(e => e.Sscpmt5)
                    .HasMaxLength(100)
                    .HasColumnName("sscpmt5");

                entity.Property(e => e.Tail1)
                    .HasMaxLength(100)
                    .HasColumnName("tail1");

                entity.Property(e => e.Tail2)
                    .HasMaxLength(100)
                    .HasColumnName("tail2");

                entity.Property(e => e.Tail3)
                    .HasMaxLength(100)
                    .HasColumnName("tail3");

                entity.Property(e => e.Tail4)
                    .HasMaxLength(100)
                    .HasColumnName("tail4");

                entity.Property(e => e.Tail5)
                    .HasMaxLength(100)
                    .HasColumnName("tail5");

                entity.Property(e => e.Tangi1)
                    .HasMaxLength(100)
                    .HasColumnName("tangi1");

                entity.Property(e => e.Tangi2)
                    .HasMaxLength(100)
                    .HasColumnName("tangi2");

                entity.Property(e => e.Tangi3)
                    .HasMaxLength(100)
                    .HasColumnName("tangi3");

                entity.Property(e => e.Tangi4)
                    .HasMaxLength(100)
                    .HasColumnName("tangi4");

                entity.Property(e => e.Tangi5)
                    .HasMaxLength(100)
                    .HasColumnName("tangi5");

                entity.Property(e => e.Tenphuongtien).HasMaxLength(100);
            });

            modelBuilder.Entity<Tbdienapke>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbdienapke");

                entity.Property(e => e.Apsuatc1).HasMaxLength(100);

                entity.Property(e => e.Apsuatc2).HasMaxLength(100);

                entity.Property(e => e.Apsuatc3).HasMaxLength(100);

                entity.Property(e => e.Apsuatc4).HasMaxLength(100);

                entity.Property(e => e.Apsuatc5).HasMaxLength(100);

                entity.Property(e => e.Apsuatc6).HasMaxLength(100);

                entity.Property(e => e.Apsuatc7).HasMaxLength(100);

                entity.Property(e => e.Apsuatg1).HasMaxLength(100);

                entity.Property(e => e.Apsuatg2).HasMaxLength(100);

                entity.Property(e => e.Apsuatg3).HasMaxLength(100);

                entity.Property(e => e.Apsuatg4).HasMaxLength(100);

                entity.Property(e => e.Apsuatg5).HasMaxLength(100);

                entity.Property(e => e.Apsuatg6).HasMaxLength(100);

                entity.Property(e => e.Apsuatg7).HasMaxLength(100);

                entity.Property(e => e.Apsuatt1).HasMaxLength(100);

                entity.Property(e => e.Apsuatt2).HasMaxLength(100);

                entity.Property(e => e.Apsuatt3).HasMaxLength(100);

                entity.Property(e => e.Apsuatt4).HasMaxLength(100);

                entity.Property(e => e.Apsuatt5).HasMaxLength(100);

                entity.Property(e => e.Apsuatt6).HasMaxLength(100);

                entity.Property(e => e.Apsuatt7).HasMaxLength(100);

                entity.Property(e => e.Capchinhxac).HasMaxLength(100);

                entity.Property(e => e.Chedokiemdinh).HasMaxLength(100);

                entity.Property(e => e.Clcc)
                    .HasMaxLength(100)
                    .HasColumnName("CLCC");

                entity.Property(e => e.Cososd).HasMaxLength(100);

                entity.Property(e => e.Diachisd).HasMaxLength(100);

                entity.Property(e => e.Diadiemth).HasMaxLength(100);

                entity.Property(e => e.Doam).HasMaxLength(100);

                entity.Property(e => e.Kieu).HasMaxLength(100);

                entity.Property(e => e.Kl1).HasColumnName("KL1");

                entity.Property(e => e.Kl2).HasColumnName("KL2");

                entity.Property(e => e.Kl3).HasColumnName("KL3");

                entity.Property(e => e.Kl4).HasColumnName("KL4");

                entity.Property(e => e.Kl5).HasColumnName("KL5");

                entity.Property(e => e.Kl6).HasColumnName("KL6");

                entity.Property(e => e.Kl7).HasColumnName("KL7");

                entity.Property(e => e.Ktkythuat).HasColumnName("KTkythuat");

                entity.Property(e => e.Ktngoai).HasColumnName("KTngoai");

                entity.Property(e => e.Maqd).HasMaxLength(100);

                entity.Property(e => e.Namsx).HasMaxLength(100);

                entity.Property(e => e.Ngay).HasMaxLength(100);

                entity.Property(e => e.Nguoithuchien).HasMaxLength(100);

                entity.Property(e => e.Nhietdo).HasMaxLength(100);

                entity.Property(e => e.Nuocsx).HasMaxLength(100);

                entity.Property(e => e.Phamvido).HasMaxLength(100);

                entity.Property(e => e.Ppthuchien)
                    .HasMaxLength(100)
                    .HasColumnName("PPthuchien");

                entity.Property(e => e.So).HasMaxLength(100);

                entity.Property(e => e.Tenpt).HasMaxLength(100);
            });

            modelBuilder.Entity<Tbdientim>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbdientim");

                entity.Property(e => e.Chedokiemdinh).HasMaxLength(100);

                entity.Property(e => e.Ddthuchien)
                    .HasMaxLength(100)
                    .HasColumnName("DDthuchien");

                entity.Property(e => e.Diachisd).HasMaxLength(100);

                entity.Property(e => e.Dongdien1).HasMaxLength(100);

                entity.Property(e => e.Dongdien2).HasMaxLength(100);

                entity.Property(e => e.Dongdien3).HasMaxLength(100);

                entity.Property(e => e.Dongdienctkt).HasMaxLength(100);

                entity.Property(e => e.Doontrong1).HasMaxLength(100);

                entity.Property(e => e.Doontrong2).HasMaxLength(100);

                entity.Property(e => e.Doontrong3).HasMaxLength(100);

                entity.Property(e => e.Doontrongctkt).HasMaxLength(100);

                entity.Property(e => e.Dorongdn1).HasMaxLength(100);

                entity.Property(e => e.Dorongdn2).HasMaxLength(100);

                entity.Property(e => e.Dorongdn3).HasMaxLength(100);

                entity.Property(e => e.Dorongdnctkt).HasMaxLength(100);

                entity.Property(e => e.Dotre1).HasMaxLength(100);

                entity.Property(e => e.Dotre2).HasMaxLength(100);

                entity.Property(e => e.Dotre3).HasMaxLength(100);

                entity.Property(e => e.Dotrectkt).HasMaxLength(100);

                entity.Property(e => e.Dotroidn1).HasMaxLength(100);

                entity.Property(e => e.Dotroidn2).HasMaxLength(100);

                entity.Property(e => e.Dotroidn3).HasMaxLength(100);

                entity.Property(e => e.Dotroidnctkt).HasMaxLength(100);

                entity.Property(e => e.Dtkythuat).HasMaxLength(100);

                entity.Property(e => e.Ghiquamuc1).HasMaxLength(100);

                entity.Property(e => e.Ghiquamuc2).HasMaxLength(100);

                entity.Property(e => e.Ghiquamuc3).HasMaxLength(100);

                entity.Property(e => e.Ghiquamucctkt).HasMaxLength(100);

                entity.Property(e => e.Hangsotg1).HasMaxLength(100);

                entity.Property(e => e.Hangsotg2).HasMaxLength(100);

                entity.Property(e => e.Hangsotg3).HasMaxLength(100);

                entity.Property(e => e.Hangsotgctkt).HasMaxLength(100);

                entity.Property(e => e.Hesonen1).HasMaxLength(100);

                entity.Property(e => e.Hesonen2).HasMaxLength(100);

                entity.Property(e => e.Hesonen3).HasMaxLength(100);

                entity.Property(e => e.Hesonenctkt).HasMaxLength(100);

                entity.Property(e => e.Hesoxa1).HasMaxLength(100);

                entity.Property(e => e.Hesoxa2).HasMaxLength(100);

                entity.Property(e => e.Hesoxa3).HasMaxLength(100);

                entity.Property(e => e.Hesoxactkt).HasMaxLength(100);

                entity.Property(e => e.Kiemdinhvien).HasMaxLength(100);

                entity.Property(e => e.Kieu).HasMaxLength(100);

                entity.Property(e => e.Maqd).HasMaxLength(100);

                entity.Property(e => e.Namsd).HasMaxLength(100);

                entity.Property(e => e.Namsx).HasMaxLength(100);

                entity.Property(e => e.Ngaykd).HasMaxLength(100);

                entity.Property(e => e.Noisd).HasMaxLength(100);

                entity.Property(e => e.Noisx).HasMaxLength(100);

                entity.Property(e => e.Qtkiemdinh).HasMaxLength(100);

                entity.Property(e => e.So).HasMaxLength(100);

                entity.Property(e => e.Ssdienap1).HasMaxLength(100);

                entity.Property(e => e.Ssdienap2).HasMaxLength(100);

                entity.Property(e => e.Ssdienap3).HasMaxLength(100);

                entity.Property(e => e.Ssdienapctkt).HasMaxLength(100);

                entity.Property(e => e.Ssdienapghi1).HasMaxLength(100);

                entity.Property(e => e.Ssdienapghi2).HasMaxLength(100);

                entity.Property(e => e.Ssdienapghi3).HasMaxLength(100);

                entity.Property(e => e.Ssdienapghictkt).HasMaxLength(100);

                entity.Property(e => e.Ssdonhay1).HasMaxLength(100);

                entity.Property(e => e.Ssdonhay2).HasMaxLength(100);

                entity.Property(e => e.Ssdonhay3).HasMaxLength(100);

                entity.Property(e => e.Ssdonhayctkt).HasMaxLength(100);

                entity.Property(e => e.Ssthoigian1).HasMaxLength(100);

                entity.Property(e => e.Ssthoigian2).HasMaxLength(100);

                entity.Property(e => e.Ssthoigian3).HasMaxLength(100);

                entity.Property(e => e.Ssthoigianctkt).HasMaxLength(100);

                entity.Property(e => e.Sstinhieuchuan1).HasMaxLength(100);

                entity.Property(e => e.Sstinhieuchuan2).HasMaxLength(100);

                entity.Property(e => e.Sstinhieuchuan3).HasMaxLength(100);

                entity.Property(e => e.Sstinhieuchuanctkt).HasMaxLength(100);

                entity.Property(e => e.Sstocdoghi1).HasMaxLength(100);

                entity.Property(e => e.Sstocdoghi2).HasMaxLength(100);

                entity.Property(e => e.Sstocdoghi3).HasMaxLength(100);

                entity.Property(e => e.Sstocdoghictkt).HasMaxLength(100);

                entity.Property(e => e.Tansobiendo1).HasMaxLength(100);

                entity.Property(e => e.Tansobiendo2).HasMaxLength(100);

                entity.Property(e => e.Tansobiendo3).HasMaxLength(100);

                entity.Property(e => e.Tansobiendoctkt).HasMaxLength(100);

                entity.Property(e => e.Tenpt).HasMaxLength(100);

                entity.Property(e => e.Trokhangvao1).HasMaxLength(100);

                entity.Property(e => e.Trokhangvao2).HasMaxLength(100);

                entity.Property(e => e.Trokhangvao3).HasMaxLength(100);

                entity.Property(e => e.Trokhangvaoctkt).HasMaxLength(100);
            });

            modelBuilder.Entity<Tbkiemdinh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbkiemdinh");

                entity.Property(e => e.Diachi).HasMaxLength(100);

                entity.Property(e => e.Nhan).HasMaxLength(100);

                entity.Property(e => e.Phuongtiendo).HasMaxLength(100);

                entity.Property(e => e.Sohieu).HasMaxLength(100);

                entity.Property(e => e.TenCs)
                    .HasMaxLength(100)
                    .HasColumnName("TenCS");
            });

            modelBuilder.Entity<Tbsscan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbsscan");

                entity.Property(e => e.A1)
                    .HasMaxLength(100)
                    .HasColumnName("a1");

                entity.Property(e => e.A10)
                    .HasMaxLength(100)
                    .HasColumnName("a10");

                entity.Property(e => e.A11)
                    .HasMaxLength(100)
                    .HasColumnName("a11");

                entity.Property(e => e.A12)
                    .HasMaxLength(100)
                    .HasColumnName("a12");

                entity.Property(e => e.A13)
                    .HasMaxLength(100)
                    .HasColumnName("a13");

                entity.Property(e => e.A14)
                    .HasMaxLength(100)
                    .HasColumnName("a14");

                entity.Property(e => e.A15)
                    .HasMaxLength(100)
                    .HasColumnName("a15");

                entity.Property(e => e.A16)
                    .HasMaxLength(100)
                    .HasColumnName("a16");

                entity.Property(e => e.A17)
                    .HasMaxLength(100)
                    .HasColumnName("a17");

                entity.Property(e => e.A18)
                    .HasMaxLength(100)
                    .HasColumnName("a18");

                entity.Property(e => e.A19)
                    .HasMaxLength(100)
                    .HasColumnName("a19");

                entity.Property(e => e.A2)
                    .HasMaxLength(100)
                    .HasColumnName("a2");

                entity.Property(e => e.A20)
                    .HasMaxLength(100)
                    .HasColumnName("a20");

                entity.Property(e => e.A3)
                    .HasMaxLength(100)
                    .HasColumnName("a3");

                entity.Property(e => e.A4)
                    .HasMaxLength(100)
                    .HasColumnName("a4");

                entity.Property(e => e.A5)
                    .HasMaxLength(100)
                    .HasColumnName("a5");

                entity.Property(e => e.A6)
                    .HasMaxLength(100)
                    .HasColumnName("a6");

                entity.Property(e => e.A7)
                    .HasMaxLength(100)
                    .HasColumnName("a7");

                entity.Property(e => e.A8)
                    .HasMaxLength(100)
                    .HasColumnName("a8");

                entity.Property(e => e.A9)
                    .HasMaxLength(100)
                    .HasColumnName("a9");

                entity.Property(e => e.B1)
                    .HasMaxLength(100)
                    .HasColumnName("b1");

                entity.Property(e => e.B10)
                    .HasMaxLength(100)
                    .HasColumnName("b10");

                entity.Property(e => e.B11)
                    .HasMaxLength(100)
                    .HasColumnName("b11");

                entity.Property(e => e.B12)
                    .HasMaxLength(100)
                    .HasColumnName("b12");

                entity.Property(e => e.B13)
                    .HasMaxLength(100)
                    .HasColumnName("b13");

                entity.Property(e => e.B14)
                    .HasMaxLength(100)
                    .HasColumnName("b14");

                entity.Property(e => e.B15)
                    .HasMaxLength(100)
                    .HasColumnName("b15");

                entity.Property(e => e.B16)
                    .HasMaxLength(100)
                    .HasColumnName("b16");

                entity.Property(e => e.B17)
                    .HasMaxLength(100)
                    .HasColumnName("b17");

                entity.Property(e => e.B18)
                    .HasMaxLength(100)
                    .HasColumnName("b18");

                entity.Property(e => e.B19)
                    .HasMaxLength(100)
                    .HasColumnName("b19");

                entity.Property(e => e.B2)
                    .HasMaxLength(100)
                    .HasColumnName("b2");

                entity.Property(e => e.B20)
                    .HasMaxLength(100)
                    .HasColumnName("b20");

                entity.Property(e => e.B3)
                    .HasMaxLength(100)
                    .HasColumnName("b3");

                entity.Property(e => e.B4)
                    .HasMaxLength(100)
                    .HasColumnName("b4");

                entity.Property(e => e.B5)
                    .HasMaxLength(100)
                    .HasColumnName("b5");

                entity.Property(e => e.B6)
                    .HasMaxLength(100)
                    .HasColumnName("b6");

                entity.Property(e => e.B7)
                    .HasMaxLength(100)
                    .HasColumnName("b7");

                entity.Property(e => e.B8)
                    .HasMaxLength(100)
                    .HasColumnName("b8");

                entity.Property(e => e.B9)
                    .HasMaxLength(100)
                    .HasColumnName("b9");

                entity.Property(e => e.C1)
                    .HasMaxLength(100)
                    .HasColumnName("c1");

                entity.Property(e => e.C10)
                    .HasMaxLength(100)
                    .HasColumnName("c10");

                entity.Property(e => e.C11)
                    .HasMaxLength(100)
                    .HasColumnName("c11");

                entity.Property(e => e.C12)
                    .HasMaxLength(100)
                    .HasColumnName("c12");

                entity.Property(e => e.C13)
                    .HasMaxLength(100)
                    .HasColumnName("c13");

                entity.Property(e => e.C14)
                    .HasMaxLength(100)
                    .HasColumnName("c14");

                entity.Property(e => e.C15)
                    .HasMaxLength(100)
                    .HasColumnName("c15");

                entity.Property(e => e.C16)
                    .HasMaxLength(100)
                    .HasColumnName("c16");

                entity.Property(e => e.C17)
                    .HasMaxLength(100)
                    .HasColumnName("c17");

                entity.Property(e => e.C18)
                    .HasMaxLength(100)
                    .HasColumnName("c18");

                entity.Property(e => e.C19)
                    .HasMaxLength(100)
                    .HasColumnName("c19");

                entity.Property(e => e.C2)
                    .HasMaxLength(100)
                    .HasColumnName("c2");

                entity.Property(e => e.C20)
                    .HasMaxLength(100)
                    .HasColumnName("c20");

                entity.Property(e => e.C3)
                    .HasMaxLength(100)
                    .HasColumnName("c3");

                entity.Property(e => e.C4)
                    .HasMaxLength(100)
                    .HasColumnName("c4");

                entity.Property(e => e.C5)
                    .HasMaxLength(100)
                    .HasColumnName("c5");

                entity.Property(e => e.C6)
                    .HasMaxLength(100)
                    .HasColumnName("c6");

                entity.Property(e => e.C7)
                    .HasMaxLength(100)
                    .HasColumnName("c7");

                entity.Property(e => e.C8)
                    .HasMaxLength(100)
                    .HasColumnName("c8");

                entity.Property(e => e.C9)
                    .HasMaxLength(100)
                    .HasColumnName("c9");

                entity.Property(e => e.G1)
                    .HasMaxLength(100)
                    .HasColumnName("g1");

                entity.Property(e => e.G10)
                    .HasMaxLength(100)
                    .HasColumnName("g10");

                entity.Property(e => e.G11)
                    .HasMaxLength(100)
                    .HasColumnName("g11");

                entity.Property(e => e.G12)
                    .HasMaxLength(100)
                    .HasColumnName("g12");

                entity.Property(e => e.G13)
                    .HasMaxLength(100)
                    .HasColumnName("g13");

                entity.Property(e => e.G14)
                    .HasMaxLength(100)
                    .HasColumnName("g14");

                entity.Property(e => e.G15)
                    .HasMaxLength(100)
                    .HasColumnName("g15");

                entity.Property(e => e.G16)
                    .HasMaxLength(100)
                    .HasColumnName("g16");

                entity.Property(e => e.G17)
                    .HasMaxLength(100)
                    .HasColumnName("g17");

                entity.Property(e => e.G18)
                    .HasMaxLength(100)
                    .HasColumnName("g18");

                entity.Property(e => e.G19)
                    .HasMaxLength(100)
                    .HasColumnName("g19");

                entity.Property(e => e.G2)
                    .HasMaxLength(100)
                    .HasColumnName("g2");

                entity.Property(e => e.G20)
                    .HasMaxLength(100)
                    .HasColumnName("g20");

                entity.Property(e => e.G3)
                    .HasMaxLength(100)
                    .HasColumnName("g3");

                entity.Property(e => e.G4)
                    .HasMaxLength(100)
                    .HasColumnName("g4");

                entity.Property(e => e.G5)
                    .HasMaxLength(100)
                    .HasColumnName("g5");

                entity.Property(e => e.G6)
                    .HasMaxLength(100)
                    .HasColumnName("g6");

                entity.Property(e => e.G7)
                    .HasMaxLength(100)
                    .HasColumnName("g7");

                entity.Property(e => e.G8)
                    .HasMaxLength(100)
                    .HasColumnName("g8");

                entity.Property(e => e.G9)
                    .HasMaxLength(100)
                    .HasColumnName("g9");

                entity.Property(e => e.H1)
                    .HasMaxLength(100)
                    .HasColumnName("h1");

                entity.Property(e => e.H10)
                    .HasMaxLength(100)
                    .HasColumnName("h10");

                entity.Property(e => e.H11)
                    .HasMaxLength(100)
                    .HasColumnName("h11");

                entity.Property(e => e.H12)
                    .HasMaxLength(100)
                    .HasColumnName("h12");

                entity.Property(e => e.H13)
                    .HasMaxLength(100)
                    .HasColumnName("h13");

                entity.Property(e => e.H14)
                    .HasMaxLength(100)
                    .HasColumnName("h14");

                entity.Property(e => e.H15)
                    .HasMaxLength(100)
                    .HasColumnName("h15");

                entity.Property(e => e.H16)
                    .HasMaxLength(100)
                    .HasColumnName("h16");

                entity.Property(e => e.H17)
                    .HasMaxLength(100)
                    .HasColumnName("h17");

                entity.Property(e => e.H18)
                    .HasMaxLength(100)
                    .HasColumnName("h18");

                entity.Property(e => e.H19)
                    .HasMaxLength(100)
                    .HasColumnName("h19");

                entity.Property(e => e.H2)
                    .HasMaxLength(100)
                    .HasColumnName("h2");

                entity.Property(e => e.H20)
                    .HasMaxLength(100)
                    .HasColumnName("h20");

                entity.Property(e => e.H3)
                    .HasMaxLength(100)
                    .HasColumnName("h3");

                entity.Property(e => e.H4)
                    .HasMaxLength(100)
                    .HasColumnName("h4");

                entity.Property(e => e.H5)
                    .HasMaxLength(100)
                    .HasColumnName("h5");

                entity.Property(e => e.H6)
                    .HasMaxLength(100)
                    .HasColumnName("h6");

                entity.Property(e => e.H7)
                    .HasMaxLength(100)
                    .HasColumnName("h7");

                entity.Property(e => e.H8)
                    .HasMaxLength(100)
                    .HasColumnName("h8");

                entity.Property(e => e.H9)
                    .HasMaxLength(100)
                    .HasColumnName("h9");

                entity.Property(e => e.I1)
                    .HasMaxLength(100)
                    .HasColumnName("i1");

                entity.Property(e => e.I10)
                    .HasMaxLength(100)
                    .HasColumnName("i10");

                entity.Property(e => e.I11)
                    .HasMaxLength(100)
                    .HasColumnName("i11");

                entity.Property(e => e.I12)
                    .HasMaxLength(100)
                    .HasColumnName("i12");

                entity.Property(e => e.I13)
                    .HasMaxLength(100)
                    .HasColumnName("i13");

                entity.Property(e => e.I14)
                    .HasMaxLength(100)
                    .HasColumnName("i14");

                entity.Property(e => e.I15)
                    .HasMaxLength(100)
                    .HasColumnName("i15");

                entity.Property(e => e.I16)
                    .HasMaxLength(100)
                    .HasColumnName("i16");

                entity.Property(e => e.I17)
                    .HasMaxLength(100)
                    .HasColumnName("i17");

                entity.Property(e => e.I18)
                    .HasMaxLength(100)
                    .HasColumnName("i18");

                entity.Property(e => e.I19)
                    .HasMaxLength(100)
                    .HasColumnName("i19");

                entity.Property(e => e.I2)
                    .HasMaxLength(100)
                    .HasColumnName("i2");

                entity.Property(e => e.I20)
                    .HasMaxLength(100)
                    .HasColumnName("i20");

                entity.Property(e => e.I3)
                    .HasMaxLength(100)
                    .HasColumnName("i3");

                entity.Property(e => e.I4)
                    .HasMaxLength(100)
                    .HasColumnName("i4");

                entity.Property(e => e.I5)
                    .HasMaxLength(100)
                    .HasColumnName("i5");

                entity.Property(e => e.I6)
                    .HasMaxLength(100)
                    .HasColumnName("i6");

                entity.Property(e => e.I7)
                    .HasMaxLength(100)
                    .HasColumnName("i7");

                entity.Property(e => e.I8)
                    .HasMaxLength(100)
                    .HasColumnName("i8");

                entity.Property(e => e.I9)
                    .HasMaxLength(100)
                    .HasColumnName("i9");

                entity.Property(e => e.K1)
                    .HasMaxLength(100)
                    .HasColumnName("k1");

                entity.Property(e => e.K10)
                    .HasMaxLength(100)
                    .HasColumnName("k10");

                entity.Property(e => e.K11)
                    .HasMaxLength(100)
                    .HasColumnName("k11");

                entity.Property(e => e.K12)
                    .HasMaxLength(100)
                    .HasColumnName("k12");

                entity.Property(e => e.K13)
                    .HasMaxLength(100)
                    .HasColumnName("k13");

                entity.Property(e => e.K14)
                    .HasMaxLength(100)
                    .HasColumnName("k14");

                entity.Property(e => e.K15)
                    .HasMaxLength(100)
                    .HasColumnName("k15");

                entity.Property(e => e.K16)
                    .HasMaxLength(100)
                    .HasColumnName("k16");

                entity.Property(e => e.K17)
                    .HasMaxLength(100)
                    .HasColumnName("k17");

                entity.Property(e => e.K18)
                    .HasMaxLength(100)
                    .HasColumnName("k18");

                entity.Property(e => e.K19)
                    .HasMaxLength(100)
                    .HasColumnName("k19");

                entity.Property(e => e.K2)
                    .HasMaxLength(100)
                    .HasColumnName("k2");

                entity.Property(e => e.K20)
                    .HasMaxLength(100)
                    .HasColumnName("k20");

                entity.Property(e => e.K3)
                    .HasMaxLength(100)
                    .HasColumnName("k3");

                entity.Property(e => e.K4)
                    .HasMaxLength(100)
                    .HasColumnName("k4");

                entity.Property(e => e.K5)
                    .HasMaxLength(100)
                    .HasColumnName("k5");

                entity.Property(e => e.K6)
                    .HasMaxLength(100)
                    .HasColumnName("k6");

                entity.Property(e => e.K7)
                    .HasMaxLength(100)
                    .HasColumnName("k7");

                entity.Property(e => e.K8)
                    .HasMaxLength(100)
                    .HasColumnName("k8");

                entity.Property(e => e.K9)
                    .HasMaxLength(100)
                    .HasColumnName("k9");

                entity.Property(e => e.L1)
                    .HasMaxLength(100)
                    .HasColumnName("l1");

                entity.Property(e => e.L10)
                    .HasMaxLength(100)
                    .HasColumnName("l10");

                entity.Property(e => e.L11)
                    .HasMaxLength(100)
                    .HasColumnName("l11");

                entity.Property(e => e.L12)
                    .HasMaxLength(100)
                    .HasColumnName("l12");

                entity.Property(e => e.L13)
                    .HasMaxLength(100)
                    .HasColumnName("l13");

                entity.Property(e => e.L14)
                    .HasMaxLength(100)
                    .HasColumnName("l14");

                entity.Property(e => e.L15)
                    .HasMaxLength(100)
                    .HasColumnName("l15");

                entity.Property(e => e.L16)
                    .HasMaxLength(100)
                    .HasColumnName("l16");

                entity.Property(e => e.L17)
                    .HasMaxLength(100)
                    .HasColumnName("l17");

                entity.Property(e => e.L18)
                    .HasMaxLength(100)
                    .HasColumnName("l18");

                entity.Property(e => e.L19)
                    .HasMaxLength(100)
                    .HasColumnName("l19");

                entity.Property(e => e.L2)
                    .HasMaxLength(100)
                    .HasColumnName("l2");

                entity.Property(e => e.L20)
                    .HasMaxLength(100)
                    .HasColumnName("l20");

                entity.Property(e => e.L3)
                    .HasMaxLength(100)
                    .HasColumnName("l3");

                entity.Property(e => e.L4)
                    .HasMaxLength(100)
                    .HasColumnName("l4");

                entity.Property(e => e.L5)
                    .HasMaxLength(100)
                    .HasColumnName("l5");

                entity.Property(e => e.L6)
                    .HasMaxLength(100)
                    .HasColumnName("l6");

                entity.Property(e => e.L7)
                    .HasMaxLength(100)
                    .HasColumnName("l7");

                entity.Property(e => e.L8)
                    .HasMaxLength(100)
                    .HasColumnName("l8");

                entity.Property(e => e.L9)
                    .HasMaxLength(100)
                    .HasColumnName("l9");

                entity.Property(e => e.M1)
                    .HasMaxLength(100)
                    .HasColumnName("m1");

                entity.Property(e => e.M10)
                    .HasMaxLength(100)
                    .HasColumnName("m10");

                entity.Property(e => e.M11)
                    .HasMaxLength(100)
                    .HasColumnName("m11");

                entity.Property(e => e.M12)
                    .HasMaxLength(100)
                    .HasColumnName("m12");

                entity.Property(e => e.M13)
                    .HasMaxLength(100)
                    .HasColumnName("m13");

                entity.Property(e => e.M14)
                    .HasMaxLength(100)
                    .HasColumnName("m14");

                entity.Property(e => e.M15)
                    .HasMaxLength(100)
                    .HasColumnName("m15");

                entity.Property(e => e.M16)
                    .HasMaxLength(100)
                    .HasColumnName("m16");

                entity.Property(e => e.M17)
                    .HasMaxLength(100)
                    .HasColumnName("m17");

                entity.Property(e => e.M18)
                    .HasMaxLength(100)
                    .HasColumnName("m18");

                entity.Property(e => e.M19)
                    .HasMaxLength(100)
                    .HasColumnName("m19");

                entity.Property(e => e.M2)
                    .HasMaxLength(100)
                    .HasColumnName("m2");

                entity.Property(e => e.M20)
                    .HasMaxLength(100)
                    .HasColumnName("m20");

                entity.Property(e => e.M3)
                    .HasMaxLength(100)
                    .HasColumnName("m3");

                entity.Property(e => e.M4)
                    .HasMaxLength(100)
                    .HasColumnName("m4");

                entity.Property(e => e.M5)
                    .HasMaxLength(100)
                    .HasColumnName("m5");

                entity.Property(e => e.M6)
                    .HasMaxLength(100)
                    .HasColumnName("m6");

                entity.Property(e => e.M7)
                    .HasMaxLength(100)
                    .HasColumnName("m7");

                entity.Property(e => e.M8)
                    .HasMaxLength(100)
                    .HasColumnName("m8");

                entity.Property(e => e.M9)
                    .HasMaxLength(100)
                    .HasColumnName("m9");

                entity.Property(e => e.Maqd).HasMaxLength(100);

                entity.Property(e => e.N1)
                    .HasMaxLength(100)
                    .HasColumnName("n1");

                entity.Property(e => e.N10)
                    .HasMaxLength(100)
                    .HasColumnName("n10");

                entity.Property(e => e.N11)
                    .HasMaxLength(100)
                    .HasColumnName("n11");

                entity.Property(e => e.N12)
                    .HasMaxLength(100)
                    .HasColumnName("n12");

                entity.Property(e => e.N13)
                    .HasMaxLength(100)
                    .HasColumnName("n13");

                entity.Property(e => e.N14)
                    .HasMaxLength(100)
                    .HasColumnName("n14");

                entity.Property(e => e.N15)
                    .HasMaxLength(100)
                    .HasColumnName("n15");

                entity.Property(e => e.N16)
                    .HasMaxLength(100)
                    .HasColumnName("n16");

                entity.Property(e => e.N17)
                    .HasMaxLength(100)
                    .HasColumnName("n17");

                entity.Property(e => e.N18)
                    .HasMaxLength(100)
                    .HasColumnName("n18");

                entity.Property(e => e.N19)
                    .HasMaxLength(100)
                    .HasColumnName("n19");

                entity.Property(e => e.N2)
                    .HasMaxLength(100)
                    .HasColumnName("n2");

                entity.Property(e => e.N20)
                    .HasMaxLength(100)
                    .HasColumnName("n20");

                entity.Property(e => e.N3)
                    .HasMaxLength(100)
                    .HasColumnName("n3");

                entity.Property(e => e.N4)
                    .HasMaxLength(100)
                    .HasColumnName("n4");

                entity.Property(e => e.N5)
                    .HasMaxLength(100)
                    .HasColumnName("n5");

                entity.Property(e => e.N6)
                    .HasMaxLength(100)
                    .HasColumnName("n6");

                entity.Property(e => e.N7)
                    .HasMaxLength(100)
                    .HasColumnName("n7");

                entity.Property(e => e.N8)
                    .HasMaxLength(100)
                    .HasColumnName("n8");

                entity.Property(e => e.N9)
                    .HasMaxLength(100)
                    .HasColumnName("n9");
            });

            modelBuilder.Entity<Tbthongtincan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbthongtincan");

                entity.Property(e => e.Capchinhxac).HasMaxLength(50);

                entity.Property(e => e.Chedokd).HasMaxLength(100);

                entity.Property(e => e.Diachisd).HasMaxLength(100);

                entity.Property(e => e.Donvisd).HasMaxLength(100);

                entity.Property(e => e.Kiemdinhvien).HasMaxLength(100);

                entity.Property(e => e.Kieu).HasMaxLength(100);

                entity.Property(e => e.Ktchitiet).HasColumnName("KTchitiet");

                entity.Property(e => e.Ktdaydu).HasColumnName("KTdaydu");

                entity.Property(e => e.Ktdodong).HasColumnName("KTdodong");

                entity.Property(e => e.Ktdolap).HasColumnName("KTdolap");

                entity.Property(e => e.Ktdolechtam).HasColumnName("KTdolechtam");

                entity.Property(e => e.Ktdongho).HasColumnName("KTdongho");

                entity.Property(e => e.Ktnhan).HasColumnName("KTnhan");

                entity.Property(e => e.Ktsaiso).HasColumnName("KTsaiso");

                entity.Property(e => e.Maqd).HasMaxLength(100);

                entity.Property(e => e.Maxdodong).HasMaxLength(100);

                entity.Property(e => e.Mindodong).HasMaxLength(100);

                entity.Property(e => e.NamSx)
                    .HasMaxLength(100)
                    .HasColumnName("NamSX");

                entity.Property(e => e.Ngay).HasMaxLength(100);

                entity.Property(e => e.Nuamaxdodong).HasMaxLength(100);

                entity.Property(e => e.NuocSx)
                    .HasMaxLength(100)
                    .HasColumnName("NuocSX");

                entity.Property(e => e.Ppthuchien)
                    .HasMaxLength(100)
                    .HasColumnName("PPthuchien");

                entity.Property(e => e.So).HasMaxLength(100);

                entity.Property(e => e.Tenphuongtien).HasMaxLength(100);
            });

            modelBuilder.Entity<Tbthongtinkiemdinh>(entity =>
            {
                entity.HasKey(e => e.Maqd)
                    .HasName("tbthongtinkiemdinh_PK");

                entity.ToTable("tbthongtinkiemdinh");

                entity.Property(e => e.Maqd).HasMaxLength(100);

                entity.Property(e => e.Capchinhxac).HasMaxLength(50);

                entity.Property(e => e.Chedokiemdinh).HasMaxLength(100);

                entity.Property(e => e.Chuanthietbi).HasMaxLength(100);

                entity.Property(e => e.Cssanxuat)
                    .HasMaxLength(100)
                    .HasColumnName("CSsanxuat");

                entity.Property(e => e.Cssudung)
                    .HasMaxLength(100)
                    .HasColumnName("CSsudung");

                entity.Property(e => e.Ddthuchien)
                    .HasMaxLength(100)
                    .HasColumnName("DDthuchien");

                entity.Property(e => e.Diachicssd).HasMaxLength(100);

                entity.Property(e => e.Ketluan).HasMaxLength(100);

                entity.Property(e => e.Kieu).HasMaxLength(100);

                entity.Property(e => e.Kqbenngoai).HasColumnName("KQbenngoai");

                entity.Property(e => e.Namsanxuat).HasMaxLength(50);

                entity.Property(e => e.Ngay)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Ngaythuchien).HasMaxLength(20);

                entity.Property(e => e.Nguoithuchien).HasMaxLength(100);

                entity.Property(e => e.Phuongtiendo).HasMaxLength(100);

                entity.Property(e => e.Ppthuchien)
                    .HasMaxLength(100)
                    .HasColumnName("PPthuchien");

                entity.Property(e => e.So).HasMaxLength(100);

                entity.Property(e => e.Sobienban).HasMaxLength(100);

                entity.Property(e => e.Sophieumau).HasMaxLength(100);
            });

            modelBuilder.Entity<Trubom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trubom");

                entity.Property(e => e.Capcx).HasMaxLength(100);

                entity.Property(e => e.Chatlongkd).HasMaxLength(100);

                entity.Property(e => e.Chedokd).HasMaxLength(100);

                entity.Property(e => e.Chuantb).HasMaxLength(100);

                entity.Property(e => e.Cososd).HasMaxLength(100);

                entity.Property(e => e.Cssx)
                    .HasMaxLength(100)
                    .HasColumnName("CSSX");

                entity.Property(e => e.Csthetich).HasMaxLength(100);

                entity.Property(e => e.Ddthuchien)
                    .HasMaxLength(100)
                    .HasColumnName("DDthuchien");

                entity.Property(e => e.Diachisd).HasMaxLength(100);

                entity.Property(e => e.EavQmaxs).HasMaxLength(100);

                entity.Property(e => e.EavQmaxt).HasMaxLength(100);

                entity.Property(e => e.EavQmins).HasMaxLength(100);

                entity.Property(e => e.EavQmint).HasMaxLength(100);

                entity.Property(e => e.Edtk).HasMaxLength(100);

                entity.Property(e => e.EfdQmaxs1).HasMaxLength(100);

                entity.Property(e => e.EfdQmaxs2).HasMaxLength(100);

                entity.Property(e => e.EfdQmaxt1).HasMaxLength(100);

                entity.Property(e => e.EfdQmaxt2).HasMaxLength(100);

                entity.Property(e => e.EfdQmins1).HasMaxLength(100);

                entity.Property(e => e.EfdQmins2).HasMaxLength(100);

                entity.Property(e => e.EfdQmint1).HasMaxLength(100);

                entity.Property(e => e.EfdQmint2).HasMaxLength(100);

                entity.Property(e => e.Efddt).HasMaxLength(100);

                entity.Property(e => e.Efdtk).HasMaxLength(100);

                entity.Property(e => e.Efptt).HasMaxLength(100);

                entity.Property(e => e.Ett).HasMaxLength(100);

                entity.Property(e => e.Kiemdinhvien).HasMaxLength(100);

                entity.Property(e => e.Kieu).HasMaxLength(100);

                entity.Property(e => e.Klchung).HasColumnName("KLChung");

                entity.Property(e => e.Klcptt).HasColumnName("KLcptt");

                entity.Property(e => e.Kldtgt)
                    .HasMaxLength(100)
                    .HasColumnName("KLdtgt");

                entity.Property(e => e.Kldttt)
                    .HasMaxLength(100)
                    .HasColumnName("KLdttt");

                entity.Property(e => e.Klin1)
                    .HasMaxLength(100)
                    .HasColumnName("KLin1");

                entity.Property(e => e.Klin2)
                    .HasMaxLength(100)
                    .HasColumnName("KLin2");

                entity.Property(e => e.Klllln).HasColumnName("KLllln");

                entity.Property(e => e.Klong).HasColumnName("KLong");

                entity.Property(e => e.Klqmaxs)
                    .HasMaxLength(100)
                    .HasColumnName("KLQmaxs");

                entity.Property(e => e.Klqmaxt)
                    .HasMaxLength(100)
                    .HasColumnName("KLQmaxt");

                entity.Property(e => e.Klqmins)
                    .HasMaxLength(100)
                    .HasColumnName("KLQmins");

                entity.Property(e => e.Klqmint)
                    .HasMaxLength(100)
                    .HasColumnName("KLQmint");

                entity.Property(e => e.Kltk).HasColumnName("KLtk");

                entity.Property(e => e.Kltt)
                    .HasMaxLength(100)
                    .HasColumnName("KLtt");

                entity.Property(e => e.Luongcptt).HasMaxLength(100);

                entity.Property(e => e.Luonggnin1).HasMaxLength(100);

                entity.Property(e => e.Luonggnin2).HasMaxLength(100);

                entity.Property(e => e.Luuluongln).HasMaxLength(100);

                entity.Property(e => e.Luuluongnn).HasMaxLength(100);

                entity.Property(e => e.Maqd).HasMaxLength(100);

                entity.Property(e => e.NamSx)
                    .HasMaxLength(100)
                    .HasColumnName("NamSX");

                entity.Property(e => e.Ngaykd).HasMaxLength(100);

                entity.Property(e => e.Pctt).HasMaxLength(100);

                entity.Property(e => e.Pfddt).HasMaxLength(100);

                entity.Property(e => e.Pfdin1).HasMaxLength(100);

                entity.Property(e => e.Pfdin2).HasMaxLength(100);

                entity.Property(e => e.Pfdtt).HasMaxLength(100);

                entity.Property(e => e.Pprdt).HasMaxLength(100);

                entity.Property(e => e.Ppthuchien)
                    .HasMaxLength(100)
                    .HasColumnName("PPthuchien");

                entity.Property(e => e.Putt).HasMaxLength(100);

                entity.Property(e => e.Qatachkhi).HasMaxLength(100);

                entity.Property(e => e.Qmax).HasMaxLength(100);

                entity.Property(e => e.So).HasMaxLength(100);

                entity.Property(e => e.Sochiong).HasMaxLength(100);

                entity.Property(e => e.Tenpt).HasMaxLength(100);

                entity.Property(e => e.Tgcapphat).HasMaxLength(100);

                entity.Property(e => e.Tienttin1).HasMaxLength(100);

                entity.Property(e => e.Tienttin2).HasMaxLength(100);

                entity.Property(e => e.VfdQmaxs1).HasMaxLength(100);

                entity.Property(e => e.VfdQmaxs2).HasMaxLength(100);

                entity.Property(e => e.VfdQmaxt1).HasMaxLength(100);

                entity.Property(e => e.VfdQmaxt2).HasMaxLength(100);

                entity.Property(e => e.VfdQmins1).HasMaxLength(100);

                entity.Property(e => e.VfdQmins2).HasMaxLength(100);

                entity.Property(e => e.VfdQmint1).HasMaxLength(100);

                entity.Property(e => e.VfdQmint2).HasMaxLength(100);

                entity.Property(e => e.Vfddt).HasMaxLength(100);

                entity.Property(e => e.Vfdin1).HasMaxLength(100);

                entity.Property(e => e.Vfdin2).HasMaxLength(100);

                entity.Property(e => e.Vfdtinhtien).HasMaxLength(100);

                entity.Property(e => e.Vfdtk).HasMaxLength(100);

                entity.Property(e => e.Vfdtt).HasMaxLength(100);

                entity.Property(e => e.Vprdt).HasMaxLength(100);

                entity.Property(e => e.VrefQmaxs1).HasMaxLength(100);

                entity.Property(e => e.VrefQmaxs2).HasMaxLength(100);

                entity.Property(e => e.VrefQmaxt1).HasMaxLength(100);

                entity.Property(e => e.VrefQmaxt2).HasMaxLength(100);

                entity.Property(e => e.VrefQmins1).HasMaxLength(100);

                entity.Property(e => e.VrefQmins2).HasMaxLength(100);

                entity.Property(e => e.VrefQmint1).HasMaxLength(100);

                entity.Property(e => e.VrefQmint2).HasMaxLength(100);

                entity.Property(e => e.Vrefdt).HasMaxLength(100);

                entity.Property(e => e.Vreftk).HasMaxLength(100);

                entity.Property(e => e.Vreftt).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
