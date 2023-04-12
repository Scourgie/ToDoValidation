using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ToDoListAdolfson.Models.DataLayer;

public partial class Category
{
    [Key]
    public string CategoryId { get; set; } = null!;

    public string Name { get; set; } = null!;

    [InverseProperty("Category")]
    public virtual ICollection<ToDo> ToDos { get; } = new List<ToDo>();
}
