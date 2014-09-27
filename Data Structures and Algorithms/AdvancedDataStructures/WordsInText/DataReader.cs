namespace WordsInText
{
    using System.IO;

    public class DataReader
    {
        private static readonly int loopCount = 1;

        private readonly TrieNode root;

        private readonly string path;

        public DataReader(string path, ref TrieNode root)
        {
            this.root = root;
            this.path = path;
        }

        public void ThreadRun()
        {
            for (int i = 0; i < loopCount; i++)
            {
                using (FileStream fstream = new FileStream(this.path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sreader = new StreamReader(fstream))
                    {
                        string line;
                        while ((line = sreader.ReadLine()) != null)
                        {
                            string[] chunks = line.Split(null);
                            foreach (string chunk in chunks)
                            {
                                this.root.AddWord(chunk.Trim());
                            }
                        }
                    }
                }
            }
        }
    }
}