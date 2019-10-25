using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NingsMart.Models
{
    public class ProductViewModel
    {
        [Key]
        public int ProductId { get; set; }

        [Column("nvarchar(250)")]
        public string ProductName { get; set; }

        [Column("nvarchar(100)")]
        public int Qauntity { get; set; }

        [Column("nvarchar(max)")]
        public int Price { get; set; }


    }
}
