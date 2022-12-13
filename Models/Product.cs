using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManager.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(256)]
        public string Name { get; set; }

        [MaxLength(256)]
        public string Slug { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }

        // [ForeignKey("Category")]
        public int CategoryID { get; set; }

        // [ForeignKey("CategoryID")]
        public Category Category { get; set; }
    }
}