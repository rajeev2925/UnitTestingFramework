using Bytescout.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAIPCsharp.Geniric
{
    public class Excellutility
    {

        public static string fPath = "C:\\Users\\admin\\source\\repos\\UnitTestingFramework\\UnitTestingFramework\\TestData\\dataex.xlsx";

        public string Read_Single_Data(string sheatname, int row, int cell)
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(fPath);
            string value = spreadsheet.Workbook.Worksheets.ByName(sheatname).Cell(row, cell).ToString();
            return value;
        }

        public IEnumerable<Object> Read_multiple_data(string sheatname)
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(fPath);
            Worksheet book = spreadsheet.Workbook.Worksheets.ByName(sheatname);
            int row = book.UsedRangeRowMax;
            int cel = book.UsedRangeColumnMax;
            for (int i = 0; i <= row; i++)
            {
                String key = book.Cell(i, 0).ToString();
                String value = book.Cell(i, 1).ToString();
                yield return new[] { key, value };
            }
        }

        public string Get_value_by_pasing_key(string sheatname, string key)
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile(fPath);
            Worksheet book = spreadsheet.Workbook.Worksheets.ByName(sheatname);
            int lrow = book.UsedRangeRowMax;
            string vl = null;
            for (int i = 0; i <= lrow; i++)
            {
                string k = book.Cell(i, 0).ToString();
                if (k.Equals(key))
                {

                    vl = book.Cell(i, 1).ToString();
                    break;
                }

            }

            return vl;
        }
    }
}

