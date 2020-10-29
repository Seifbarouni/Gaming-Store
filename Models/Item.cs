using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GetAGame.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string OwnerName { get; set; }
        [Required]
        public string ImgURL { get; set; }
        [Required]
        public string Title { get; set; }
        public string Details { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
