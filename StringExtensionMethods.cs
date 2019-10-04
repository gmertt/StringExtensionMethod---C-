using System;
using System.Text;
namespace ExapleProject.ExtensionMethods{
public static class StringExtensionMethods
    {
        //e.g. -> Merter GÜLBAHAR ,Ali Veli GEZGİN
        public static string ToCustomNameFormat(this string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default:
                    StringBuilder sp = new StringBuilder();
                    string[] strList = input.Trim().Split(' ');
                    for (int i = 0; i < strList.Length; i++)
                    {
                        if (i == 0)
                        {
                            sp.Append(strList[i][0].ToString().ToUpper() + strList[i].Substring(1));
                            //Substring(1) -> 1. index'ten itibaren string'i dondurur. 
                        }
                        else
                        {
                            sp.Append(" ");
                            sp.Append(strList[i].ToString().ToUpper());
                        }
                    }
                    return sp.ToString();
            }
        }
    }
}
