using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapProje.DataContext.Entities
{
    public class Kitaplar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? book_id { get; set; }
        public int author_id { get; set; }
        public string book_name { get; set; }
        public int publisher_id { get; set; }
        public int genre_id { get; set; }
        public DateTime? published_date { get; set; }

        private DataDBContext myDBContextOBJ;

        internal Kitaplar()
        {
            this.myDBContextOBJ = KitapProje.DataContext.SharedThings.getConnOBJ();
        }

        internal List<Kitaplar> Select(Kitaplar kitaplar)
        {
            return this.myDBContextOBJ.Kitaplars.Where(x => (x.genre_id == kitaplar.genre_id || kitaplar.genre_id == -1) &&
                                                     (x.author_id == kitaplar.author_id || kitaplar.author_id == -1) &&
                                                     (x.publisher_id == kitaplar.publisher_id || kitaplar.publisher_id == -1)
                                                ).ToList();
        }

        internal List<Kitaplar> SelectKitap()
        {
            return this.myDBContextOBJ.Kitaplars.OrderBy(x => x.book_name).ToList();
        }

        internal void Insert(Kitaplar kitaplar)
        {
            this.book_id = null;
            this.author_id = kitaplar.author_id;
            this.publisher_id = kitaplar.publisher_id;
            this.genre_id = kitaplar.genre_id;
            this.published_date = kitaplar.published_date;
            this.book_name = kitaplar.book_name;
            this.myDBContextOBJ.Kitaplars.Add(this);
            this.myDBContextOBJ.SaveChanges();
        }

        internal void Update(int bookId, string bookName, int authorId, int publisherId, int genreId, DateTime publishedDate)
        {
            Kitaplar kitaplar = this.myDBContextOBJ.Kitaplars.Find(bookId);
            kitaplar.book_name=bookName;
            kitaplar.author_id=authorId;
            kitaplar.publisher_id=publisherId;
            kitaplar.genre_id=genreId;
            kitaplar.published_date = publishedDate;
            this.myDBContextOBJ.SaveChanges();
        }

        internal void Delete(int bookId)
        {
            Kitaplar kitaplar = this.myDBContextOBJ.Kitaplars.Find(bookId);
            this.myDBContextOBJ.Kitaplars.Remove(kitaplar);
            this.myDBContextOBJ.SaveChanges();
        }
    }
}
