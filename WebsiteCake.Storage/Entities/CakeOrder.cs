using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteCake.Storage.Entities
{
    public class CakeOrder
    {
        [Key] // Введение первичного ключа с помощью атрибута
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CakeId { get; set; }
        public int Id { get; set; }
        public int FillingId { get; set; }
        public int OrderId { get; set; }
        
        
        [ForeignKey(nameof(OrderId))]
        public Order Order{ get; set; }
        
        [ForeignKey(nameof(CakeId))]
        public Cake Cake { get; set; }

        [ForeignKey(nameof(FillingId))]
        public Filling Filling { get; set; }
        [Required]
        public int Price { get; set; }

        [Required]
        public int Weight { get; set; }

    }
}
