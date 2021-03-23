using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using eRestoran.Models;

namespace eRestoran.Data
{
    public class ApplicationDbContext : IdentityDbContext<OnlineGost>
    {
        public DbSet<StavkaUlaza> StavkaUlaza { get; set; }
        public DbSet<PonudaStavka> PonudaStavka { get; set; }
        public DbSet<OnlineNarudzba> OnlineNarudzba { get; set; }
        public DbSet<NarudzbaStavka> NarudzbaStavka { get; set; }
        public DbSet<Meni> Meni { get; set; }
        public DbSet<Kategorija> Kategorija { get; set; }
        public DbSet<DostavaNalog> DostavaNalog { get; set; }
        public DbSet<DnevnaPonuda> DnevnaPonuda { get; set; }
        public DbSet<VoziloZaDostavu> VoziloZaDostavu { get; set; }
        public DbSet<Notifikacije> Notifikacije { get; set; }
        public DbSet<OnlineGost> OnlineGost { get; set; }
        public DbSet<RezervacijaStolova> RezervacijaStolova { get; set; }
        public DbSet<Uposlenik> Uposleniks { get; set; }
        public DbSet<UlazUSkladiste> UlazUSkladiste { get; set; }
        public DbSet<Restoran> Restoran { get; set; }
        public DbSet<Obavijesti> Obavijestis { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UposlenikObavijesti>()
            .HasKey(x => new { x.UposlenikId, x.ObavijestiId });

            modelBuilder.Entity<UposlenikObavijesti>()
                .HasOne(x => x.Obavijesti)
                .WithMany(y => y.Uposlenik)
                .HasForeignKey(y => y.UposlenikId);

            modelBuilder.Entity<UposlenikObavijesti>()
                .HasOne(x => x.Uposlenik)
                .WithMany(y => y.UposlenikObavijesti)
                .HasForeignKey(y => y.ObavijestiId); 
        }
        public DbSet<eRestoran.Models.UposlenikObavijesti> UposlenikObavijesti { get; set; }
    }
}
