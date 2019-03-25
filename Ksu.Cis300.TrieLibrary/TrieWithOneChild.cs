using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    public class TrieWithOneChild : ITrie
    {
        private bool _isEmpty;
        private ITrie _child;
        private char _label;

        /// <summary>
        /// constructor for Trie with a single child
        /// </summary>
        /// <param name="s">string value</param>
        /// <param name="b">boolean</param>
        public TrieWithOneChild(string s, bool b)
        {
            if (s == "" || s[0] < 'a' || s[0] > 'z')
            {
                throw new ArgumentException();
            }
            else
            {
                _isEmpty = b;
                _label = s[0];
                _child = new TrieWithNoChildren().Add(s.Substring(1));
            }
        }

        /// <summary>
        /// Adds a string into a Trie
        /// </summary>
        /// <param name="s">string to be added</param>
        /// <returns>returns type ITrie</returns>
        public ITrie Add(string s)
        {
            if(s == "")
            {
                _isEmpty = true;
            }else if (s[0].Equals(_label))
            {
                _child = _child.Add(s.Substring(1));
                return this;
            }
            else
            {
                return new TrieWithManyChildren(s, _isEmpty, _label, _child);
            }
            return this;
        }

        /// <summary>
        /// Determines if contained
        /// </summary>
        /// <param name="s">String to be compared</param>
        /// <returns>bool based on items within variable</returns>
        public bool Contains(string s)
        {
            if(s == "")
            {
                return _isEmpty;
            }
            else if (s[0].Equals(_label))
            {
                return _child.Contains(s.Substring(1));
                
            }
            else
            {
                return false;
            }
            
        }

        
    }

    
}
