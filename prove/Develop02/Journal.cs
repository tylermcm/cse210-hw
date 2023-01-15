using System;
using System.IO;
using System.Text;


    class Journal
    {
        public string _filePath;
        Prompt prompts = new Prompt();
        public void writePrompt()
        {   
            prompts.Prompts();
            prompts.Write();
       
        }

        public void showPrompt()
        {
            foreach (string promptsList in prompts._prompt)
            {
                Console.WriteLine(promptsList);
            }
        }

        public void userPrompt()
        {
            Console.WriteLine("Please enter your own prompt to be added to the list of prompts.");
            string prompt = Console.ReadLine();
            prompts._prompt.Add(prompt);
        }        

        public void Display()
        {
            string output = string.Join("\n", prompts._entries.ToArray());
            Console.Write($"\n{output}\n");
        }
        
        public void Save()
        {
            Journal journal = new Journal();
            journal.writeToCSV();
            journal.readFromCSV();
        }

        public void writeToCSV()
        {
            Console.WriteLine("Please enter a filename and extension: ");
            _filePath = Console.ReadLine();


            string output = string.Join("\n", prompts._entries.ToArray());

            StringBuilder builder = new StringBuilder();

            DateTime date = DateTime.Now;

            string todaysDate = date.ToString("MM/dd/yyyy");

            builder.AppendLine(string.Format("{0}\n{1}", todaysDate, output));

            File.AppendAllText(_filePath, builder.ToString());
        }

        public void readFromCSV()
        {
            StreamReader streamReader = new StreamReader(_filePath);

            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine();
                if (line != "")
                {

                
                    var values = line.Split('|');

                    Console.WriteLine("{0}", values[0]);
                }
            }
            streamReader.Close();
        }
    }

