using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBookExercise.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
