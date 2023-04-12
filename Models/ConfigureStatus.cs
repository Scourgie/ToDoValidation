using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ToDoListAdolfson.Models
{
    public class ConfigureStatus : IEntityTypeConfiguration<Status>
    {

        public void Configure(EntityTypeBuilder<Status> entity)
        {

            entity.HasData(
                new Status { StatusId = "open", Name = "Open" },
                new Status { StatusId = "closed", Name = "Completed" }
                );

        }

    }
}
