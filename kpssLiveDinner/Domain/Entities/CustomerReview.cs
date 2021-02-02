using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpssLiveDinner.Domain.Entities
{
    public class CustomerReview
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Message { get; set; }
    }
}
