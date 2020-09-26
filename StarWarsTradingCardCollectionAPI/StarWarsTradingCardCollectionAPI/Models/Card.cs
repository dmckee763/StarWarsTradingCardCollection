using System;
using System.Collections.Generic;

namespace StarWarsTradingCardCollectionAPI.Models
{
    public partial class Card
    {
        public Guid CardId { get; set; }
        public string CardNo { get; set; }
        public string CardName { get; set; }
        public Guid? SeriesId { get; set; }

        public virtual Series Series { get; set; }
    }
}
