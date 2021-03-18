using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Prodject_ПРІС.Data
{
    public class ClassRoom
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idCr { get; set; }

        [StringLength(255)]
        public string nameCr { get; set; }

        public DateTime DateCr { get; set; }
    }
}
