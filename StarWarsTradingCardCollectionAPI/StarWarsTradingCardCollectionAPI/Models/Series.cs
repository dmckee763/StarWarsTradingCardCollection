﻿using System;
using System.Collections.Generic;

namespace StarWarsTradingCardCollectionAPI.Models
{
    public partial class Series
    {
        public Series()
        {
            Card = new HashSet<Card>();
        }

        public Guid SeriesId { get; set; }
        public string SeriesName { get; set; }
        public Guid? SetId { get; set; }

        public virtual Set Set { get; set; }
        public virtual ICollection<Card> Card { get; set; }
    }
}
