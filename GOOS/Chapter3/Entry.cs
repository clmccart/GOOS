using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter3
{
    public class Entry
    {
        private readonly string _label;
        private readonly string _content;
        public Entry()
        {
            _label = "";
            _content = "";
        }
        public Entry(string var1, string var2)
        {
            _label = var1;
            _content = var2;
        }

        public string GetLabel()
        {
            return _label;
        }
    }
}
