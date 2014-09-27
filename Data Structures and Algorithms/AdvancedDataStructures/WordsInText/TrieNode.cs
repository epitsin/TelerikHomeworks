namespace WordsInText
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    public class TrieNode : IComparable<TrieNode>
    {
        private readonly char character;

        private readonly TrieNode parent = null;

        private readonly ConcurrentDictionary<char, TrieNode> children = null;

        public TrieNode(TrieNode parent, char c)
        {
            this.character = c;
            this.WordCount = 0;
            this.parent = parent;
            this.children = new ConcurrentDictionary<char, TrieNode>();
        }

        public int WordCount { get; set; }
        
        public void AddWord(string word, int index = 0)
        {
            if (index < word.Length)
            {
                char key = word[index];
                if (char.IsLetter(key))
                {
                    if (!this.children.ContainsKey(key))
                    {
                        this.children.TryAdd(key, new TrieNode(this, key));
                    }

                    this.children[key].AddWord(word, index + 1);
                }
                else
                {
                    this.AddWord(word, index + 1);
                }
            }
            else
            {
                if (this.parent != null)
                {
                    lock (this)
                    {
                        this.WordCount++;
                    }
                }
            }
        }

        public int GetCount(string word, int index = 0)
        {
            if (index < word.Length)
            {
                char key = word[index];
                if (!this.children.ContainsKey(key))
                {
                    return -1;
                }

                return this.children[key].GetCount(word, index + 1);
            }
            else
            {
                return this.WordCount;
            }
        }

        public void GetTopCounts(ref List<TrieNode> mostCounted, ref int distinctWordCount, ref int totalWordCount)
        {
            if (this.WordCount > 0)
            {
                distinctWordCount++;
                totalWordCount += this.WordCount;
            }

            if (this.WordCount > mostCounted[0].WordCount)
            {
                mostCounted[0] = this;
                mostCounted.Sort();
            }

            foreach (char key in this.children.Keys)
            {
                this.children[key].GetTopCounts(ref mostCounted, ref distinctWordCount, ref totalWordCount);
            }
        }

        public override string ToString()
        {
            if (this.parent == null)
            {
                return string.Empty;
            }
            else
            {
                return string.Format("{0}{1}", this.parent.ToString(), this.character);
            }
        }

        public int CompareTo(TrieNode other)
        {
            return this.WordCount.CompareTo(other.WordCount);
        }
    }
}