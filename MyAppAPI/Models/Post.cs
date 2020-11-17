using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAppAPI.Models
{
    [Table("post")]
    public partial class Post
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("content")]
        [StringLength(8000)]
        public string Content { get; set; }
        [Column("title")]
        [StringLength(50)]
        public string Title { get; set; }
        [Column("date_posted", TypeName = "date")]
        public DateTime? DatePosted { get; set; }
    }
}
