using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreEnumToStringTest
{
    public class MyEntityConfiguration : IEntityTypeConfiguration<MyEntity>
    {
        public void Configure(EntityTypeBuilder<MyEntity> builder)
        {
            builder.ToTable("my_entities");

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .IsRequired();
            builder.HasKey(e => e.Id);

            builder.Property(t => t.Status)
                .HasColumnName("status")
                .IsRequired()
                .HasConversion(new EnumToStringConverter<MyEnum>());

            builder.Property(t => t.DueAtDate)
                .HasColumnName("due_at_date");
        }
    }
}
