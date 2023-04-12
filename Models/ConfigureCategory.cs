using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ToDoListAdolfson.Models
{
    public class ConfigureCategory : IEntityTypeConfiguration<Category>
    {

        public void Configure(EntityTypeBuilder<Category> entity)
        {
            entity.HasData(
                new Category { CategoryId = "work", Name = "Work" },
                new Category { CategoryId = "home", Name = "Home" },
                new Category { CategoryId = "ex", Name = "Exercise" },
                new Category { CategoryId = "shop", Name = "Shopping" },
                new Category { CategoryId = "call", Name = "Contact" }
                );
        }

    }
}
