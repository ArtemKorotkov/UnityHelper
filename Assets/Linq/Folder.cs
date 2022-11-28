using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class Folder
    {

        public List<Word> Words = new List<Word>();
        
        public int progress = 0;
        public int repeat = 0;

        public void AddWord(Word word)
        {
            Words.Add(word);
        }
    }
}