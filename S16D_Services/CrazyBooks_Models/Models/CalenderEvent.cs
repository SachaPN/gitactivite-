using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.Models
{
    public class CalenderEvent
    {
        int Id { get; set; }

        DateTime Date { get; set; }

        CategoryEvent CategoryEvent { get; set; }

    }
}
