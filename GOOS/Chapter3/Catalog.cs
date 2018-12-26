using System;

namespace Chapter3
{
    public class Catalog
    {
        private Entry _entry = new Entry();
        public Catalog()
        {

        }

        public void Add(Entry entry)
        {
            if (!entry.GetLabel().Equals(_entry.GetLabel()))
            {
                _entry = entry;
            } else
            {
                throw new Exception("Cannot add two entries with the same name");
            }
            
        }
        public bool Contains(Entry entry)
        {
            return _entry.Equals(entry);
        }

        public object GetEntryFor(string v)
        {
            if (_entry.GetLabel().Equals(v))
            {
                return _entry;
            } else
            {
                return null;
            }
        }
    }
}
