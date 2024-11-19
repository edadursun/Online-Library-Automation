using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapProje.DataContext.Entities
{
    public class Yorumlar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? comment_id { get; set; }
        public string commenter_mail { get; set; }
        public int book_id { get; set; }
        public string comment { get; set; }

        private DataDBContext myDBContextOBJ;

        internal Yorumlar() 
        {
            this.myDBContextOBJ = KitapProje.DataContext.SharedThings.getConnOBJ();
        }

        internal List<Yorumlar> Select(int bookID)
        {
            return this.myDBContextOBJ.Yorumlars.Where(x => (x.book_id == bookID)).ToList();
        }

        internal void Insert(Yorumlar yorumlar)
        {
            this.comment_id = null;
            this.commenter_mail = yorumlar.commenter_mail;
            this.comment = yorumlar.comment;
            this.book_id = yorumlar.book_id;
            this.myDBContextOBJ.Yorumlars.Add(this);
            this.myDBContextOBJ.SaveChanges();
        }

        internal void Update(int commentId, int bookId, string commenterMail, string comment)
        {
            Yorumlar yorumlar = this.myDBContextOBJ.Yorumlars.Find(commentId);
            yorumlar.comment = comment;
            yorumlar.comment_id=commentId;
            yorumlar.book_id=bookId;
            yorumlar.commenter_mail=commenterMail;
            this.myDBContextOBJ.SaveChanges();
        }

        internal void Delete(int commentId)
        {
            Yorumlar yorumlar = this.myDBContextOBJ.Yorumlars.Find(commentId);
            this.myDBContextOBJ.Yorumlars.Remove(yorumlar);
            this.myDBContextOBJ.SaveChanges();
        }

    }
}
