using SQLite;
using System;

namespace TRABAJO_DEL_CURSO.Models
{
    public class Item
    {
        [PrimaryKey, Autoincrement]
        public string Id { get; set; }
        [MaxLength(50)]
        public string Text { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        [MaxLength(10)] //dd-mm-aaaa
        public string Date { get; set; }
        [MaxLength(5)] //HH:mm
        public string Start { get; set; }
        [MaxLength(5)] //HH:mm
        public string End { get; set; }

    }
}


