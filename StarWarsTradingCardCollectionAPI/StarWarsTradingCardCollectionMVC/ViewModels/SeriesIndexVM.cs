using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsTradingCardCollectionMVC.ViewModels
{
    public class SeriesIndexVM
    {
        public Guid SeriesId { get; set; }
        public string SeriesName { get; set; }
        public Guid? SetId { get; set; }

        public virtual ICollection<CardIndexVM> Card { get; set; }
    }
}
