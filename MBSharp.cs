using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBSharp
{
    /*
    MBSharp Source Code || Version 1.0
    Open Source Library for C# by Manuel Belli
    Features:
    - Write -> Types: String, Int, Char, Double, Float, Bool, Decimal
    - Read -> Types: String, Int, Char, Double, Float, Bool, Decimal
    - Read Array -> Types: String, Int, Char, Double, Float, Bool, Decimal
    - FilesReading -> Read a file
    - FilesWriting -> Write a file
    - Conevertion -> Types: String, Int, Char, Double, Float, Bool, Decimal
    - ExecuteScript (.mbs) -> Interpret (private)
    - Stop -> Exit the program

    P.S.: 
    - This is a simple library for C# that allows you to write and read data in a simple way.
    - The variables region is not used to store variables that the user can use, but to store the variables that the library uses.
    */

    class MBSharp
    {
        #region Variables
        private static Dictionary<string, object> variables = new Dictionary<string, object>();
        #endregion

        #region Write
        //String
        static public void Write(string message)
        {
            Console.WriteLine(message);
        }
        //Int
        static public void Write(int num)
        {
            Console.WriteLine(num);
        }
        //Char
        static public void Write(char character)
        {
            Console.WriteLine(character);
        }
        //Double
        static public void Write(double num_double)
        {
            Console.WriteLine(num_double);
        }
        //Float
        static public void Write(float num_float)
        {
            Console.WriteLine(num_float);
        }
        //Bool
        static public void Write(bool boolean)
        {
            Console.WriteLine(boolean);
        }
        //Decimal
        static public void Write(decimal num_decimal)
        {
            Console.WriteLine(num_decimal);
        }
        #endregion

        #region Read
        //String
        static public string Read()
        {
            return Console.ReadLine();
        }
        //Int
        static public int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        //Char
        static public char ReadChar()
        {
            return Convert.ToChar(Console.ReadLine());
        }
        //Double
        static public double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        //Float
        static public float ReadFloat()
        {
            return (float)Convert.ToDouble(Console.ReadLine());
        }
        //Bool
        static public bool ReadBool()
        {
            return Convert.ToBoolean(Console.ReadLine());
        }
        //Decimal
        static public decimal ReadDecimal()
        {
            return Convert.ToDecimal(Console.ReadLine());
        }
        #endregion

        #region ReadArray
        //String
        static public void ReadArray(string[] array)
        {
            foreach(string item in array)
            {
                Console.WriteLine(item);
            }
        }
        //Int
        static public void ReadArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
        //Char
        static public void ReadArray(char[] array)
        {
            foreach (char item in array)
            {
                Console.WriteLine(item);
            }
        }
        //Double
        static public void ReadArray(double[] array)
        {
            foreach (double item in array)
            {
                Console.WriteLine(item);
            }
        }
        //Float
        static public void ReadArray(float[] array)
        {
            foreach (float item in array)
            {
                Console.WriteLine(item);
            }
        }
        //Bool
        static public void ReadArray(bool[] array)
        {
            foreach (bool item in array)
            {
                Console.WriteLine(item);
            }
        }
        //Decimal
        static public void ReadArray(decimal[] array)
        {
            foreach (decimal item in array)
            {
                Console.WriteLine(item);
            }
        }

        #endregion

        #region FilesReading
        static public void FilesReading(string filePath)
        {
            
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                MBSharp.Write(line);
            }
            
        }
        #endregion

        #region FilesWriting
        static public void FilesWriting(string filePath, string text)
        {
            File.WriteAllText(filePath, text);
        }
        #endregion

        #region Convertion
        #region String
        static public int StringToInt(string str)
        {
            return Convert.ToInt32(str);
        }
        static public char StringToChar(string str)
        {
            return Convert.ToChar(str);
        }
        static public double StringToDouble(string str)
        {
            return Convert.ToDouble(str);
        }
        static public float StringToFloat(string str)
        {
            return (float)Convert.ToDouble(str);
        }
        static public bool StringToBool(string str)
        {
            return Convert.ToBoolean(str);
        }
        static public decimal StringToDecimal(string str)
        {
            return Convert.ToDecimal(str);
        }
        #endregion
        #region Int
        static public string IntToString(int num)
        {
            return Convert.ToString(num);
        }
        static public char IntToChar(int num)
        {
            return Convert.ToChar(num);
        }
        static public double IntToDouble(int num)
        {
            return Convert.ToDouble(num);
        }
        static public float IntToFloat(int num)
        {
            return (float)Convert.ToDouble(num);
        }
        static public bool IntToBool(int num)
        {
            return Convert.ToBoolean(num);
        }
        static public decimal IntToDecimal(int num)
        {
            return Convert.ToDecimal(num);
        }
        #endregion
        #region Char
        static public string CharToString(char character)
        {
            return Convert.ToString(character);
        }
        static public int CharToInt(char character)
        {
            return Convert.ToInt32(character);
        }
        static public double CharToDouble(char character)
        {
            return Convert.ToDouble(character);
        }
        static public float CharToFloat(char character)
        {
            return (float)Convert.ToDouble(character);
        }
        static public bool CharToBool(char character)
        {
            return Convert.ToBoolean(character);
        }
        static public decimal CharToDecimal(char character)
        {
            return Convert.ToDecimal(character);
        }
        #endregion
        #region Double
        static public string DoubleToString(double num_double)
        {
            return Convert.ToString(num_double);
        }
        static public int DoubleToInt(double num_double)
        {
            return Convert.ToInt32(num_double);
        }
        static public char DoubleToChar(double num_double)
        {
            return Convert.ToChar(num_double);
        }
        static public float DoubleToFloat(double num_double)
        {
            return (float)num_double;
        }
        static public bool DoubleToBool(double num_double)
        {
            return Convert.ToBoolean(num_double);
        }
        static public decimal DoubleToDecimal(double num_double)
        {
            return Convert.ToDecimal(num_double);
        }
        #endregion
        #region Float
        static public string FloatToString(float num_float)
        {
            return Convert.ToString(num_float);
        }
        static public int FloatToInt(float num_float)
        {
            return Convert.ToInt32(num_float);
        }
        static public char FloatToChar(float num_float)
        {
            return Convert.ToChar(num_float);
        }
        static public double FloatToDouble(float num_float)
        {
            return Convert.ToDouble(num_float);
        }
        static public bool FloatToBool(float num_float)
        {
            return Convert.ToBoolean(num_float);
        }
        static public decimal FloatToDecimal(float num_float)
        {
            return Convert.ToDecimal(num_float);
        }
        #endregion
        #region Bool
        static public string BoolToString(bool boolean)
        {
            return Convert.ToString(boolean);
        }
        static public int BoolToInt(bool boolean)
        {
            return Convert.ToInt32(boolean);
        }
        static public char BoolToChar(bool boolean)
        {
            return Convert.ToChar(boolean);
        }
        static public double BoolToDouble(bool boolean)
        {
            return Convert.ToDouble(boolean);
        }
        static public float BoolToFloat(bool boolean)
        {
            return Convert.ToSingle(boolean);
        }
        static public decimal BoolToDecimal(bool boolean)
        {
            return Convert.ToDecimal(boolean);
        }
        #endregion
        #region Decimal
        static public string DecimalToString(decimal num_decimal)
        {
            return Convert.ToString(num_decimal);
        }
        static public int DecimalToInt(decimal num_decimal)
        {
            return Convert.ToInt32(num_decimal);
        }
        static public char DecimalToChar(decimal num_decimal)
        {
            return Convert.ToChar(num_decimal);
        }
        static public double DecimalToDouble(decimal num_decimal)
        {
            return Convert.ToDouble(num_decimal);
        }
        static public float DecimalToFloat(decimal num_decimal)
        {
            return Convert.ToSingle(num_decimal);
        }
        static public bool DecimalToBool(decimal num_decimal)
        {
            return Convert.ToBoolean(num_decimal);
        }
        #endregion
        #endregion

        #region ExecuteScript
        public static void ExecuteScript(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File non trovato: " + filePath);
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                Interpret(line.Trim());
            }
        }

        #region Interpret
        private static void Interpret(string line)
        {
            if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                return; // Ignora righe vuote e commenti

            string[] parts = line.Split(' ');
            string command = parts[0].ToLower();

            switch (command)
            {
                case "write":
                    Console.WriteLine(string.Join(" ", parts, 1, parts.Length - 1));
                    break;

                case "read":
                    if (parts.Length > 1)
                        variables[parts[1]] = Console.ReadLine();
                    break;

                case "set":
                    if (parts.Length > 2)
                        variables[parts[1]] = string.Join(" ", parts, 2, parts.Length - 2);
                    break;

                case "if":
                    if (parts.Length > 3 && parts[2] == "==")
                    {
                        string varName = parts[1];
                        string value = parts[3];
                        if (variables.ContainsKey(varName) && variables[varName].ToString() == value)
                        {
                            Interpret(string.Join(" ", parts, 4, parts.Length - 4));
                        }
                    }
                    break;

                case "math":
                    if (parts.Length > 3)
                    {
                        try
                        {
                            string expression = string.Join(" ", parts, 2, parts.Length - 2);
                            variables[parts[1]] = Convert.ToDouble(new DataTable().Compute(expression, null));
                        }
                        catch
                        {
                            Console.WriteLine("Errore nel calcolo dell'espressione matematica");
                        }
                    }
                    break;

                case "while":
                    if (parts.Length > 3 && parts[2] == "==")
                    {
                        string varName = parts[1];
                        string value = parts[3];
                        while (variables.ContainsKey(varName) && variables[varName].ToString() == value)
                        {
                            Interpret(string.Join(" ", parts, 4, parts.Length - 4));
                        }
                    }
                    break;

                case "exit":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Comando sconosciuto: " + command);
                    break;
            }
        }
        #endregion
        #endregion

        #region Stop
        static public void Stop()
        {
            Console.ReadKey();
        }
        #endregion
    }
}
