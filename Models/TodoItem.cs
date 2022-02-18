using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace TodoOnboardApi.Models
{
    public class TodoItem
    {
        [Key]
        public long Id { get; set; }
        public string? Title { get; set; }
        public bool Done { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        
        

        public virtual Board Boards {get; set;}

        
    }
}