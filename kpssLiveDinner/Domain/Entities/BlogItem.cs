using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpssLiveDinner.Domain.Entities
{
    public class BlogItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Heading { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }
}
