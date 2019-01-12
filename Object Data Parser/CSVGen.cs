using System.Collections.Generic;

namespace Object_Data_Parser
{
    public class CsvGen
    {
		public List<string> columnNames = new List<string>();
		public List<List<string>> rows = new List<List<string>>();

		public void AddRow(List<string> row)
		{
			rows.Add(row);
		}

		public void InsertRow(int column, List<string> row)
		{
			while (rows.Count < column)
			{
				rows.Add(new List<string>());
			}

			rows.Insert(column, row);
		}

		public void ReplaceRow(int column, List<string> row)
		{
			while (rows.Count <= column)
			{
				rows.Add(new List<string>());
			}

			rows.RemoveAt(column);
			rows.Insert(column, row);
		}

		public void WriteTable(string file)
		{
			List<string> lines = new List<string> {MakeLine(columnNames)};


			foreach (List<string> row in rows)
			{
				lines.Add(MakeLine(row));
			}

			System.IO.File.WriteAllLines(file, lines);
		}

		private string MakeLine(List<string> line)
		{
			return "\"" + string.Join("\",\"", line) + "\"";
		}
	}
}
