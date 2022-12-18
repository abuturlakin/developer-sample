using System;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace DeveloperSample.Syncing
{
    public class SyncTest
    {
        [Fact]
        public void CanInitializeCollection()
        {
            var debug = new SyncDebug();
            var items = new List<string> { "one", "two" };
            var result = debug.InitializeList(items);
            Assert.Equal(items.Count, result.Result.Count);
        }

        [Fact]
        public void ItemsOnlyInitializeOnce()
        {
            var debug = new SyncDebug();
            var addCount = 0;
            var dictionary = debug.InitializeDictionary(i =>
                new Lazy<string>(
                    () =>
                    {
                        Thread.Sleep(1);
                        Interlocked.Increment(ref addCount);
                        return i.ToString();
                    }));

            Assert.Equal(100, addCount);
            Assert.Equal(100, dictionary.Count);
        }
    }
}