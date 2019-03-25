using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TrieLibrary
{
    public class TrieWithNoChildren : ITrie
    {
        private bool _hasEmptyString = false;
        /// <summary>
        /// Adds string and constructs a child
        /// </summary>
        /// <param name="s">string to be added</param>
        /// <returns>TrieWithOneChild</returns>
        public ITrie Add(string s)
        {
            if (s == "")
            {
                _hasEmptyString = true;
                return this;
            }
            else
            {
                return new TrieWithOneChild(s, _hasEmptyString);
            }
            

        }

        /// <summary>
        /// returns the boolean
        /// </summary>
        /// <param name="s">string to look up</param>
        /// <returns>boolean</returns>
        public bool Contains(string s)
        {
            if (s == "")
            {
                return _hasEmptyString;
            }
            
            else
            {
                return false;
            }
        }
    }
}
