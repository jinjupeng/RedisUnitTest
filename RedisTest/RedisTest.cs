using System;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RedisTest
{
    [TestClass]
    public class RedisTest
    {
        // https://www.cnblogs.com/itmu89/p/7118474.html
        [TestMethod]
        public void CacheTest()
        {
            Redis r = new Redis();
            r.Insert("k001", "value001");
            object oo = r.Get("k001");
            CacheHelper.Insert("key01", "test001");
            object obj = CacheHelper.Get("key01");
        }
        [TestMethod]
        public void RedisTest1()
        {
            RedisHelper rh = new RedisHelper();
            object j = rh.Get<string>("123");  //打断点调试。通过
            
        }
    }
}
