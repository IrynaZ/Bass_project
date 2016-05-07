using System;
using System.Collections.Generic;
using System.IO;

namespace BassPlayer.CS
{
    public class FileHandling
    {
        public List<string> inputContent { get; set; }
        public List<string> outputContent { get; set; }

        public FileHandling(string inputFilePath)
        {
            inputContent = outputContent = ReadFromFile(inputFilePath);
        }

        public List<string> ReadFromFile(string filePath)
        {
            List<string> fileContent = new List<string>();
            using (StreamReader fileReader = new StreamReader(filePath))
            {
                string fileLine = null;
                while ((fileLine = fileReader.ReadLine()) != null)
                {
                    fileContent.Add(fileLine);
                }
            }
            return fileContent;
        }

        public void WriteOutputToFile(string filePath)
        {
            using (StreamWriter fileWriter = new StreamWriter(filePath))
            {
                foreach (string fileLine in outputContent)
                {
                    fileWriter.WriteLine(fileLine);
                }
            }
        }
    }
}
