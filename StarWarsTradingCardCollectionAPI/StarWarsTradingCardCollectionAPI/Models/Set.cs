using System;
using System.Collections.Generic;

namespace StarWarsTradingCardCollectionAPI.Models
{
    public partial class Set
    {
        public Set()
        {
            Series = new HashSet<Series>();
        }

        public int SetId { get; set; }
        public string SetName { get; set; }
        public int? Year { get; set; }

        public virtual ICollection<Series> Series { get; set; }
    }
}
