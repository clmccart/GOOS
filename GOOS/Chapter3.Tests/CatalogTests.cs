using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Chapter3.Tests
{
    public class CatalogTests
    {
        [Fact]
        public void ContainsAnAddedEntry()
        {
            var catalog = new Catalog();
            var entry = new Entry("fish", "chips");
            catalog.Add(entry);
            Assert.True(catalog.Contains(entry));
        }
        [Fact]
        public void IndexesEntriesByName()
        {
            var catalog = new Catalog();
            var entry = new Entry("fish", "chips");
            catalog.Add(entry);
            Assert.Equal(catalog.GetEntryFor("fish"), entry);
            Assert.Null(catalog.GetEntryFor("missing name"));
        }
    }
}
