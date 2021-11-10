using BidvestData.Common.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Bidvest.Core
{
    public static class FileReader
    {
        public static async Task<Resultant<List<string>>> ReadFile(string path)
        {
            Resultant<List<string>> lines = new Resultant<List<string>>();
            try
            {   
                if (!File.Exists(path))
                {
                    lines.Messages.Add("File does not exist.");
                    return lines;
                }

                using (var reader = new StreamReader(path))
                {
                    string currentLine;
                    lines.Data = new List<string>();

                    while ((currentLine = await reader.ReadLineAsync()) != null)
                    {
                        lines.Data.Add(currentLine);
                    }
                }
            }
            catch (Exception ex)
            {
                lines.Messages.Add($"An error occurred while reading the file.");
                lines.Messages.Add($"See exception message: {ex.Message}");
            }

            return lines;
        }

        public static async Task WriteToFile(string path, string content)
        {
            try
            {
                using (var writer = new StreamWriter(path))
                {
                    await writer.WriteAsync(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing to the file.");
                Console.WriteLine($"See exception message: {ex.Message}");
            }
        }
    }
}
