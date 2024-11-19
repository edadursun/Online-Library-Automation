using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapProje.DataContext.Entities
{
    public class Yayinevleri
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? publisher_id { get; set; }
        [Required]
        public string publisher_name { get; set; }
        public DateTime establishment_date { get; set; }

        private DataDBContext myDBContextObj;

        internal Yayinevleri()
        {
            //myDBContextObj = new DataDBContext();
            this.myDBContextObj = KitapProje.DataContext.SharedThings.getConnOBJ();
        }

        internal void Insert(Yayinevleri yayinevleri)
        {
            this.publisher_id = yayinevleri.publisher_id;
            this.publisher_name = yayinevleri.publisher_name;
            this.establishment_date = yayinevleri.establishment_date;
            this.myDBContextObj.Yayinevleris.Add(this);
            this.myDBContextObj.SaveChanges();
        }

        internal void Update(int publisherId, string publisherName, DateTime establismentDate)
        {
            Yayinevleri yayinevleri = this.myDBContextObj.Yayinevleris.Find(publisherId);
            yayinevleri.publisher_name = publisherName;
            yayinevleri.establishment_date = establismentDate;
            this.myDBContextObj.SaveChanges();
        }

        internal void Delete(int publisherId)
        {
            Yayinevleri yayinevleri = this.myDBContextObj.Yayinevleris.Find(publisherId);
            this.myDBContextObj.Yayinevleris.Remove(yayinevleri);
            this.myDBContextObj.SaveChanges();
        }

        internal List<Yayinevleri> Select()
        {
            return this.myDBContextObj.Yayinevleris.OrderBy(x => x.publisher_name).ToList();
        }
    }
}
