using CurrencyTrader.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyTrader.AdoNet
{
    public class AsyncTradeStore : ITradeStorage
    {
        AdoNetTradeStorage SynchTradeStore;

        public AsyncTradeStore(ILogger logger)
        {
            SynchTradeStore = new AdoNetTradeStorage(logger);
        }

        public void Persist(IEnumerable<TradeRecord> trades)
        {
            // Save the trades to the database asynchronously
            Task.Run(() => SynchTradeStore.Persist(trades));
        }
    }
}
