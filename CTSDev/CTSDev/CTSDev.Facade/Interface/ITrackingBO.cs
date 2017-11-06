using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTSDev.Models;

namespace CTSDev.Facade
{
    public interface ITrackingBO
    {
        int InsertData(CorrCompInfo corrcompinfo);
    }
}
