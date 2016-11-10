using CurrencyTrader.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyTrader.AdoNet
{
    class AsyncTradeStore : ITradeStorage
    {
        public void Persist(IEnumerable<TradeRecord> trades)
        {
            // Save the trades to the database
            throw new NotImplementedException();
        }
    }
}
