using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsTradingCardCollectionMVC.ViewModels
{
    public class CardIndexVM
    {
        public Guid CardId { get; set; }

        public string CardNo { get; set; }

        public string CardName { get; set; }

        public Guid? SeriesId { get; set; }

    }
}
