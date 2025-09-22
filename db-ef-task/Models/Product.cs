using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_ef_task.Models
{
    internal class Product
    {
        public int Id { get; set; }
        [Column(TypeName ="varchar(50)")]
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int? rate { get; set; }
    }
}
