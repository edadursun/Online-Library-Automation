using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapProje.DataContext.Entities
{
    public class Turler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? genre_id { get; set; }
        [Required]
        public string genre_name { get; set; }

        private DataDBContext myDBContextOBJ;

        internal Turler()
        {
            //this.myDBContextOBJ = new DataDBContext();
            this.myDBContextOBJ = KitapProje.DataContext.SharedThings.getConnOBJ();
        }

        internal void Insert(Turler turler)
        {
            this.genre_id = turler.genre_id;
            this.genre_name = turler.genre_name;
            this.myDBContextOBJ.Turlers.Add(this);
            this.myDBContextOBJ.SaveChanges();
        }

        internal void Update(int pGenreId, string pGenreName)
        {
            Turler turData = this.myDBContextOBJ.Turlers.Find(pGenreId);
            turData.genre_name = pGenreName;
            this.myDBContextOBJ.SaveChanges();
        }

        internal void Delete(int pGenreId)
        {
            Turler turData = this.myDBContextOBJ.Turlers.FirstOrDefault(x => x.genre_id == pGenreId);
            this.myDBContextOBJ.Turlers.Remove(turData);
            this.myDBContextOBJ.SaveChanges();
        }
        internal List<Turler> Select() 
        {
            return this.myDBContextOBJ.Turlers.OrderBy(x => x.genre_name).ToList();
        }

    }
}
