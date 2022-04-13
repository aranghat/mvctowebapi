using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibraryCore
{
    public enum BookCategory
    {
        Crime,
        Novel,
        Comics,
        Fiction

    }

    public class Book : BaseObject
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public string ISBN { get; set; }

        public string CoverImage { get; set; }

        public BookCategory Category { get; set; }
    }
}
