using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.CW3.Friday
{
    public class CustomDate
    {
        private DateTime? _myDate;
        public string MyDate
        {
            get => (DateTime.Now - _myDate < TimeSpan.FromDays(7)) ?
                _myDate.ToString() :
                null;
            set
            {
                var tmpDate = DateTime.Parse(value);
                var dateDiff = DateTime.Now - tmpDate;
                if (dateDiff > TimeSpan.FromDays(2) && 
                    dateDiff < TimeSpan.FromDays(14))
                {
                    _myDate = tmpDate;
                }
                else
                {
                    _myDate = null;
                }
            }
        }
    }
}
