using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelDAL;
using HotelModel;

namespace HotelBLL
{
    public class ReportBusinessLayerManager
    {
        private ReportDataLayer rdl = new ReportDataLayer();

        public StatementOfAccount Soa(string idCard)
        {
            return rdl.statement(idCard);
        }
    }
}
