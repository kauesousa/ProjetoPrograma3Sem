using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeDay.DAL
{
    public class DataContextFactory
    {
        private static SaudeDayDataContext dataContext;
        public static SaudeDayDataContext DataContext
        {
            get
            {
                if (dataContext == null)
                    dataContext = new SaudeDayDataContext();

                return dataContext;
            }
        }
    }
}
