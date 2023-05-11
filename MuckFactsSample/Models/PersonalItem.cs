using System;
using SQLite;

namespace MuckFactsSample.Models
{
    public class PersonalItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Image { get; set; }
    }
}
