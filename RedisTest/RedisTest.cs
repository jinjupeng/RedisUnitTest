using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RedisTest
{
    [TestClass]
    public class RedisTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Redis r = new Redis();
            r.Insert("k001", "value001");
            object oo = r.Get("k001");
            Cache.Insert("key01", "test001");
            object obj = Cache.Get("key01");
        }
    }
}
