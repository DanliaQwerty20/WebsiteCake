using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsiteCake.Storage.Entities
{
    public class Client
    {
        [Key] // Введение первичного ключа с помощью атрибута
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Phone { get; set; }
        
        [Required]
        public string Name { get; set; }

    }
}
