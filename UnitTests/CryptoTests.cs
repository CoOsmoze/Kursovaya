using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Deshifrator.UnitTests
{
  [TestClass]
  public class CryptoTests
  {
    [TestMethod]
    public void TestKeyLenghtEncryption()
    {
      string key = "столичная";
      string text = "стол";
      string expected = "геэч";

      string actual = Crypto.Encrypt(key, text);

      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestKeyLenghtDecryption()
    {
      string key = "столичная";
      string text = "стол";
      string expected = "аааа";

      string actual = Crypto.Decryption(key, text);

      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestAnotherSymbolDecryption()
    {
      string key = "рак";
      string text = "0123456789,.!-+-=/*$&#?()";
      string expected = text;

      string actual = Crypto.Decryption(key, text);

      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void TestAnotherSymbolEncryption()
    {
      string key = "овен";
      string text = "0123456789,.!-+-=/*$&#?()";
      string expected = text;

      string actual = Crypto.Encrypt(key, text);

      Assert.AreEqual(expected, actual);
    }

  }
}
