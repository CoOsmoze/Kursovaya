using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Deshifrator
{
  public static class Crypto
  {
    private const string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    public static string Decryption(string key, string input)
    {
      string result = "";
      input = input.ToUpper().Trim();
      key = key.ToUpper().Trim();

      int temp = 0;
      for (int i = 0; i < input.Length; i++)
      {
        int letterIndex = alphabet.IndexOf(input[i]);
        if (letterIndex < 0)
          result += input[i];
        else
        {
          int codeIndex = alphabet.IndexOf(key[temp++ % key.Length]);
          int index = (alphabet.Length + letterIndex - codeIndex) % alphabet.Length;
          result += alphabet[index];
        }
      }

      return result.ToLower();
    }

    public static string Encrypt(string key, string input)
    {
      string result = "";
      input = input.ToUpper().Trim();
      key = key.ToUpper().Trim();

      int temp = 0;
      for (int i = 0; i < input.Length; i++)
      {
        int letterIndex = alphabet.IndexOf(input[i]);
        if (letterIndex < 0)
          result += input[i];
        else
        {
          int codeIndex = alphabet.IndexOf(key[temp++ % key.Length]);
          int index = (alphabet.Length + letterIndex + codeIndex) % alphabet.Length;
          result += alphabet[index];
        }
      }

      return result.ToLower();
    }
  }
}
