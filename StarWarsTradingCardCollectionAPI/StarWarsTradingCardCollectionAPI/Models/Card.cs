using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StarWarsTradingCardCollectionAPI.Models
{
    public partial class Card
    {
        [Required]
        public Guid CardId { get; set; }

        [DisplayName("Card Number"), Required]
        public string CardNo { get; set; }

        [DisplayName("Card Name")]
        public string CardName { get; set; }

        public Guid? SeriesId { get; set; }

        public virtual Series Series { get; set; }
    }
}
