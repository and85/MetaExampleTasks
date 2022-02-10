using System;
using System.Text;

public class RotationalCipher 
{
  static void Main(String[] args) 
  {
    Console.WriteLine("Test cases:");
  }

  

  // O(n) time, O(n) space
  public static string rotationalCipher(String input, int rotationFactor) 
  {
        if (string.IsNullOrWhiteSpace(input))
        {
            return input;
        }

        char[] rotated = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {            
            rotated[i] = GetRotatedSymbol(input[i], rotationFactor);                        
        }

        return new string(rotated);
    }

    private static char GetRotatedSymbol(char originalSymbol, int rotationFactor)
    {
        if (char.IsDigit(originalSymbol))
        {            
            int position = (originalSymbol - '0' + rotationFactor) % 10;
            return Convert.ToChar(position + '0');
        }
        else if (char.IsLetter(originalSymbol) && char.IsUpper(originalSymbol))
        {
            int position = (originalSymbol - 'A' + rotationFactor) % 26;
            return Convert.ToChar(position + 'A');
        }
        else if (char.IsLetter(originalSymbol) && char.IsLower(originalSymbol))
        {
            int position = (originalSymbol - 'a' + rotationFactor) % 26;
            return Convert.ToChar(position + 'a');
        }

        return originalSymbol;
    }
}