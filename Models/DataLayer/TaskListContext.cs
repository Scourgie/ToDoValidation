using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoListAdolfson.Models.DataLayer;

public partial class TaskListContext : DbContext
{
    public TaskListContext()
    {
    }

    public TaskListContext(DbContextOptions<TaskListContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<ToDo> ToDos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=ToDoContext");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
