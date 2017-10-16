using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;
using System;
using System.Collections.Generic;

namespace PingPong.TestTools
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void GetResult_ListodFifteen_pingpong()
    {
      PingPong testPingPong = new PingPong();
      List<string>  expected = new List<string> {"1","2","Ping","4","Pong","Ping","7","8","Ping","Pong","11","Ping","13","14","PingPong"};
      List<string> result = testPingPong.GetResult(15);
      // foreach (string item in result)
      // {
      //   Console.WriteLine("Output: " + item);
      // }
      CollectionAssert.AreEqual(expected, result);

    }

    [TestMethod]
    public void GetResult_NumberMultipleOfFifteen_pingpong()
    {

      PingPong testPingPong = new PingPong();
      List<string> result = testPingPong.GetResult(15);
      // if (result[14]=="PingPong")
      // {
      //   return true;
      // }
      // else
      // {
      //   return false;
      // }
        // Console.WriteLine("Output: " + result[0]);

      Assert.AreEqual("PingPong", result[14]);

    }

    // [TestMethod]
    // public void GetResult_NumberMultipleOfFive_pong()
    // {
    //   PingPong testPingPong = new PingPong();
    //   Assert.AreEqual("pong", testPingPong.GetResult(10));
    // }
    // // [TestMethod]
    // public void GetResult_NumberMultipleOfThree_ping()
    // {
    //   PingPong testPingPong = new PingPong();
    //   Assert.AreEqual("ping", testPingPong.GetResult(6));
    // }
    // [TestMethod]
    // public void GetResult_NumberNotAMultipleOfAbove_2()
    // {
    //   PingPong testPingPong = new PingPong();
    //   Assert.AreEqual("2", testPingPong.GetResult(2));
    // }
  }
}
