using System.Collections.Generic;

namespace BlackBookExercise.Models
{
    public class Debitor
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Exchange> Transactions { get; set; }
    }
}
