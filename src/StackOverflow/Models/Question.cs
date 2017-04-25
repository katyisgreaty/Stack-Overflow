using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace StackOverflow.Models
{
    [Table("Questions")]
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        [DefaultValue(0)]
        public int Vote { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
