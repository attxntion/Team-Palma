using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table ("Tasks")]
    public class Task
    {
        [Key]
        public int Task_Id { get; set; }
        public string Text_Title { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Deadline { get; set; }
        public int Column_Id { get; set; }
        public int User_Id { get; set; }

    }
}
