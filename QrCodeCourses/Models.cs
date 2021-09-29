using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QrCodeCourses
{
    public class QRCodePanier : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=" +Environment.CurrentDirectory + @"\QrCodePanier.db");
        // @"Data Source=C:\Users\Clem\Documents\DEV\CSharp\QrCodeCourses\QrCodePanier.db"
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Panier> Paniers { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
    
    /*public class Article
    {
 
        private int quantite;
        private string nom;

        public int Quantite { get => quantite; set => quantite = value; }
        public string Nom { get => nom; set => nom = value; }
        public string QuantiteNom { get => quantite.ToString() + " : " + nom; }
        
        public Article(string sNom, int iQt)
        {
            this.nom = sNom.Trim();
            this.quantite = iQt;
        }
        
    }*/
    public class Panier
    {
        public int PanierId { get; set; }
        public string Telephone { get; set; }
        public string Nom { get; set; }
        public DateTime Date { get; set; }
    }
    public class Article
    {
        public int ArticleId { get; set; }
        public string Nom { get; set; }
        public int Quantite { get; set; }
        public string QuantiteNom { get => Quantite.ToString() + " : " + Nom; }
        public bool Saved { get; set; }
        public Panier Panier { get; set; }

    }



}
