using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata.kata__5_
{
    public class WeightForWeight
    {
        public static string orderWeight(string strng)
        {
            {
                return string.Join(" ", strng.Split(' ')
                    .OrderBy(n => n.ToCharArray()
                    .Select(c => (int)char.GetNumericValue(c)).Sum())
                    .ThenBy(n => n));
            }
        }
    }
}
