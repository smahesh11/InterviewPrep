using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class Trie
    {
        TrieNode _root;

        public Trie(List<string> list)
        {
            _root = new TrieNode();
            foreach (string word in list)
            {
                _root.AddWord(word);
            }
        }

        public bool IsContains(string prefix, bool match)
        {
            TrieNode lastNode = _root;
            for (int i = 0; i < prefix.Length-1; i++)
            {
                lastNode = lastNode.GetChild(prefix[i]);
                if (lastNode == null)
                    return false;
            }

            return (!match || lastNode.IsEnd());            
        }

        public bool IsContains(string prefix)
        {
            return IsContains(prefix, false);
        }

        public TrieNode GetRoot
        {
           get { return _root; } 
        }
    }

    public class TrieNode
    {
        Dictionary<char, TrieNode>  children;
        bool end;
        char character;
        public TrieNode()
        {
            children = new Dictionary<char, TrieNode>();
        }

        public TrieNode(char ch)
        {
            this.character = ch;
        }

        public void AddWord(string word)
        {
            if (string.IsNullOrEmpty(word))
                return;

            char first = word[0];
            TrieNode child = GetChild(word[0]);
            if (child != null)
            {
                if (word.Length > 1)
                    AddWord(word.Substring(1));
                else child.SetEnd(true);
            }
            else
            {               
                children.Add(first, new TrieNode(first));
            }                    
        }

        public char GetChar()
        {
            return character;
        }

        public void SetEnd(bool val)
        {
            end = true;
        }

        public TrieNode GetChild(char c)
        {
            if(children.ContainsKey(c))
                return children[c];

            else return null;
        }
        public bool IsEnd()
        {
            return end;
        }
    }   
}
