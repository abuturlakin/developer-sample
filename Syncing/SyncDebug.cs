using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DeveloperSample.Syncing
{
    public class SyncDebug
    {
        public async Task<List<string>> InitializeList(IEnumerable<string> items)
        {
            var bag = new ConcurrentBag<string>();
            var options = new ParallelOptions { MaxDegreeOfParallelism = 2 };
            await Parallel.ForEachAsync(items, options, async (i, token) =>
            {
                var r = await Task.Run(() => i).ConfigureAwait(false);
                bag.Add(r);
            });
            var list = bag.ToList();
            return list;
        }

        public Dictionary<int, string> InitializeDictionary(Func<int, Lazy<string>> getItem)
        {
            var itemsToInitialize = Enumerable.Range(0, 100).ToList();
            var concurrentDictionary = new ConcurrentDictionary<int, Lazy<string>>();

            var threads = Enumerable.Range(0, 3)
                .Select(i => new Thread(() => {
                    foreach (var item in itemsToInitialize)
                    {
                        concurrentDictionary.AddOrUpdate(item, getItem, (_, s) => s);
                    }
                }))
                .ToList();

            foreach (var thread in threads)
                thread.Start();

            foreach (var thread in threads)
                thread.Join();

            return concurrentDictionary.ToDictionary(
                kv => kv.Key, 
                kv => kv.Value.Value
            );
        }
    }
}