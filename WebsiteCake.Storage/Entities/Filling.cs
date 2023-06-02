using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteCake.Storage.Entities
{
    public class Filling
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int FillingId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Type type { get; set; }


        public enum Type
        {
            Walnut,
            RedVelvet,
            Honey,
            Esterhazy,
            Yogurt,
            Kiev,
            EnglishCottageCheeseCheesecake,
            Chocolate,
            Mascarpone,
            Carrot
        }
        [Required]
        public string LinkPicture { get; set; }


    }
}
