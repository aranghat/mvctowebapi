using System;
using System.ComponentModel.DataAnnotations;

namespace MyLibraryCore
{
    public abstract class BaseObject
    {
        [Key]
        public uint Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
