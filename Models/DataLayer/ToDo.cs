using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToDoListAdolfson.Models.DataLayer;

[Index("CategoryId", Name = "IX_ToDos_CategoryId")]
[Index("StatusId", Name = "IX_ToDos_StatusId")]
public partial class ToDo
{
    [Key]
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public DateTime DueDate { get; set; }

    public string CategoryId { get; set; } = null!;

    public string StatusId { get; set; } = null!;

    [ForeignKey("CategoryId")]
    [InverseProperty("ToDos")]
    public virtual Category Category { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("ToDos")]
    public virtual Status Status { get; set; } = null!;
}
