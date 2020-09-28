using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsTradingCardCollectionMVC.ViewModels
{
    public class SetIndexVM
    {
        //public Guid SetId { get; set; }
        public string SetName { get; set; }
        public int? Year { get; set; }

        public virtual ICollection<SeriesIndexVM> Series { get; set; }
    }
}
