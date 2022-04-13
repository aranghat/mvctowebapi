using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibraryCore
{
    public  class BookRental : BaseObject
    {
        public  Book Book { get; set; }
        public User User  { get; set; }

        public  DateTime RentedDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
    }
}
