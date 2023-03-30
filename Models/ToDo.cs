using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ToDoListAdolfson.Models
{
    public class ToDo
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        [StringLength(30)]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a due date.")]
        [Range(typeof(DateTime), "01/01/2023", "01/01/2099", ErrorMessage = "The date must be between 01/01/2023 and 01/01/2099")]
        public DateTime? DueDate { get; set; }

        [Required(ErrorMessage = "Please select a category.")]
        public string CategoryId { get; set; } = string.Empty;
        [ValidateNever]
        public Category Category { get; set; } = null!;

        [Required(ErrorMessage = "Please select a status.")]
        public string StatusId { get; set; } = string.Empty;
        [ValidateNever]
        public Status Status { get; set; } = null!;

        public bool Overdue =>
            StatusId == "open" && DueDate < DateTime.Today;

    }
}
