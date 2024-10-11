using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mscom
{
    public class HexString
    {
        public static byte[] ConvertHexStringToBytes(string hexString)
        {
            // Split the input string by spaces
            string[] hexValues = hexString.Split(' ');

            // Create a byte array to hold the converted values
            byte[] byteArray = new byte[hexValues.Length];

            // Loop through each hex value, convert to a byte, and add to the array
            for (int i = 0; i < hexValues.Length; i++)
            {
                try
                {
                    // Convert the hex string (e.g., "04") to a byte
                    byteArray[i] = Convert.ToByte(hexValues[i], 16);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Error converting hex string to byte: {ex.Message}");
                }
            }

            Console.WriteLine(byteArray);

            return byteArray;
        }

        public static string ConvertBytesToHexString(byte[] byteArray)
        {
            // Convert each character in the input string to its byte representation
            //byte[] byteArray = Encoding.ASCII.GetBytes(inputString);

            // Convert each byte to a two-character hexadecimal string and join them with a space
            string hexString = BitConverter.ToString(byteArray).Replace("-", " ").ToLower();

            return hexString;
        }

        public static string ConvertStringToHexString(string inputString)
        {
            // Convert each character in the input string to its byte representation
            byte[] byteArray = Encoding.ASCII.GetBytes(inputString);

            // Convert each byte to a two-character hexadecimal string and join them with a space
            string hexString = BitConverter.ToString(byteArray).Replace("-", " ").ToLower();

            return hexString;
        }
    }
}
