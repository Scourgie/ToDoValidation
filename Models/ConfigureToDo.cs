using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ToDoListAdolfson.Models
{
    public class ConfigureToDo : IEntityTypeConfiguration<ToDo>
    {

        public void Configure(EntityTypeBuilder<ToDo> entity)
        {

            entity.HasOne(t => t.Category).WithMany(c => c.ToDoes).OnDelete(DeleteBehavior.Restrict);
            entity.HasOne(t => t.Status).WithMany(s => s.ToDoes).OnDelete(DeleteBehavior.Restrict);

        }

    }
}
