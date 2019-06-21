using System;
using DBFirstExample2.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.SqlServer;

namespace DBFirstExample2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        NorthwindEntities db = new NorthwindEntities();

        private void btnToList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Categories.ToList();


        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            //Contains ()=> T-SQL 
            dataGridView1.DataSource = db.Products.Where(x => x.ProductName.Contains("a")).ToList();
        }

        private void btnStarAndWith_Click(object sender, EventArgs e)
        {
            //StartWith ()- EndWith() => Like sorgusundaki başlayan "c" ile biten 
            dataGridView1.DataSource = db.Products.Where(x => x.ProductName.StartsWith("c")).ToList();

            dataGridView1.DataSource = db.Products.Where(x => x.ProductName.EndsWith("a")).ToList();
        }

        private void btnAny_Click(object sender, EventArgs e)
        {
            /* Any() => iki farklı kullanıma sahip olan Any methodu ilk kullanımı
             * 
             *
             * */

            // Kategoriler tablosunda Becearges isimli bir kategori var mı yok mu?
            bool sonuc = db.Categories.Any(x => x.CategoryName == "Becearges");
            MessageBox.Show(sonuc.ToString());
            // Kategoriler tablosunda adı B ile başlayan bir kategori var mı yok mu
            bool sonuc2 = db.Categories.Any(x => x.CategoryName.StartsWith("Be"));
            MessageBox.Show(sonuc2.ToString());


        }
        // AGGREGATE FUNCTION //
        private void btnCount_Click(object sender, EventArgs e)
        {
            /* Count ()=> T-SQL ' den hatırlayacağınız gibi Count () methodu sorgu sonucunda dçnen result'un satırlarını saymaktadır.
             */
            int IsciSayisi = db.Employees.Count();
            MessageBox.Show(IsciSayisi.ToString());

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            // SUM()=> T-SQL'de kullanılan SUÖ methodu ile aynı görevi üstlenir. Dönen result içerisinde belirlediğiniz kolonların değerlerinin toplanmasını sağlar.

            /* tüm ürünler dahil olmak üzere dahil olmak üzere stoğumda kaç adet ürün var ? (not: her ürünün stok değerlerini toplam istiyoruz
             * 
             * */
            int? StokSonuc = db.Products.Sum(x => x.UnitsInStock);
            MessageBox.Show(StokSonuc.ToString());
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            // en pahalı ürün
            decimal? SonucFiyat = db.Products.Max(x => x.UnitPrice);
            MessageBox.Show(SonucFiyat.ToString());
            // en ucuz ürün
            decimal? SonucFiyat2 = db.Products.Min(x => x.UnitPrice);
            MessageBox.Show(SonucFiyat2.ToString());
        }

        private void btnDistinct_Click(object sender, EventArgs e)
        {
            // T-SQL 'deki gibi tekrar eden değerleri egale etmek için kullanılır.
            // hangi ülkelerle iş yapıyoruz? 
            List<string> liste = db.Orders.Select(x => x.ShipCountry).Distinct().ToList();
            foreach (string item in liste)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Select() => Select metodu sorgularınızı çekerken istediğiniz kolonları almanıza


            // müşterilerin müşteri adı, yetkilisi, telefonu ve adresini farklı kolon isimleriyle getiren soruyu yazınız.

            dataGridView1.DataSource = db.Customers.Select(x => new
            {   MusteriSirketi = x.CompanyName,
                Yetkili = x.ContactName,
                Telefon = x.Phone,
                Adres = x.Address
            }).ToList();


        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            // GroupBy() => Sorgularımızdan dönen sonuçları

            // Hnagi kategoride kaç adet ürünüm var

            dataGridView1.DataSource = db.Products.GroupBy(x => x.Category.CategoryName).Select(y => new
            {
                KategoriAdi = y.Key,
                ToplamStok = y.Sum(x => x.UnitsInStock)

            }).ToList();

        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            // ürünlerin ürün adını, fiyatını, stok miktarını, kategori adını ve tedarikçi adını getiren sorguyu yazınız.

            dataGridView1.DataSource = db.Products.Select(x => new
            {
                UrunAdi = x.ProductName,
                Fiyat = x.UnitPrice,
                Stok = x.UnitsInStock,
                Kategori = x.Category.CategoryID,
                Tedarikci = x.Supplier.SupplierID,
            }).ToList();
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Employees.Select(x=> new
            {
                Adi = x.FirstName,
                Soyadi = x.LastName,
                DogumTarihi = x.BirthDate,
                Yasi = SqlFunctions.DateDiff("Year",x.BirthDate)

            })
        }
    }
    }
    

