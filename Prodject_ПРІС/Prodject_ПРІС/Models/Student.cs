using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Prodject_ПРІС.Data
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idst { get; set; }

        [StringLength(255)]
        public string nameSt { get; set; }

        public DateTime birthadateSt { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public DateTime DateSt { get; set; }
        
        [ForeignKey("ClassRoom")]
        public int IdCr { get; set; }

    }
}
