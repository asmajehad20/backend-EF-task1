using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db_ef_task.Models
{
    internal class Category
    {
        [Key]
        public int CatId { get; set; }

        public string Name { get; set; }
    }
}
