﻿using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Server.Models
{
    public class AddTaskRequestModel
    {
        [Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? ToDoDate { get; set; }
        public bool IsStarred { get; set; }

        [Required(ErrorMessage ="Group is required for a task!")]
        public int TaskGroupId { get; set; }
    }
}
