using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; } //vi definerar att vi har en property
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int pieId);
    }
}

//data för pies och categorys