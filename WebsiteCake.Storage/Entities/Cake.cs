using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteCake.Storage.Entities
{
    public class Cake
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get ; set;}
        [Required]
        public string Name { get; set;}
        [Required]
        public string Description { get; set;}

        const int MaxWeight = 100;

        const int MinWeight = 5;

        [Required]
        public int Tier { get; set;}// ярус торта

        const int MaxTier = 5;

        const int MinTier = 1;
        [Required]
        public int CategoryId { get; set;}

        [ForeignKey(nameof(CategoryId))]
        public virtual Сategory Category { get; set;}

        
    }
}
