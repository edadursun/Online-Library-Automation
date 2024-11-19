using KitapProje.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace KitapProje.DataContext.Entities
{
    public class Yazarlar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? author_id { get; set; }
        [Required]
        public string author_name { get; set; }
        public string author_surname { get; set; }

        private DataDBContext myDBContextObj;

        internal Yazarlar()
        {
            this.myDBContextObj = KitapProje.DataContext.SharedThings.getConnOBJ();
        }

        internal void Insert(Yazarlar yazarlar)
        {
            this.author_id = yazarlar.author_id;
            this.author_name = yazarlar.author_name;
            this.author_surname = yazarlar.author_surname;
            this.myDBContextObj.Yazarlars.Add(this);
            this.myDBContextObj.SaveChanges();
        }

        internal void Update(int authorId, string authorName, string authorSurname)
        {
            Yazarlar yazarlar = this.myDBContextObj.Yazarlars.Find(authorId);
            yazarlar.author_name = authorName;
            yazarlar.author_surname= authorSurname;
            this.myDBContextObj.SaveChanges();
        }

        internal void Delete(int authorId)
        {
            Yazarlar yazarlar = this.myDBContextObj.Yazarlars.Find(authorId);
            this.myDBContextObj.Yazarlars.Remove(yazarlar);
            this.myDBContextObj.SaveChanges();
        }

        internal List<Yazarlar> Select()
        {
            return this.myDBContextObj.Yazarlars.OrderBy(x => x.author_name).ToList();
        }

        internal List<YazarComboTYPE> getListForCombo()
        {
            return this.myDBContextObj.Database.SqlQuery<YazarComboTYPE>("select author_id,(author_name||' '||author_surname)::varchar as ad_soyad from public.yazarlar").ToList();

        }

    }

    internal class YazarComboTYPE
    {
        public int author_id { get; set; }
        public string ad_soyad { get; set; }

    }
}
