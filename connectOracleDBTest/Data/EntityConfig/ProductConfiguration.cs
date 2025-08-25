using connectOracleDBTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace connectOracleDBTest.Data.EntityConfig;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public const string ToTable = "PRODUCT";
    public const string IdColumnName = "PRODUCT_ID";
    public const string NameColumnName = "PRODUCT_NAME";
    public const string DescriptionColumnName = "DESCRIPTION";
    public const string PriceColumnName = "PRICE";
    public const string QuantityColumnName = "QUANTITY";
    public const string OffsetColumnName = "OFFSET";
    public const string PartitionColumnName = "PARTITION";

    public static Dictionary<string, string> DataTypes = new Dictionary<string, string>
    {
        {IdColumnName, "VARCHAR2(5 BYTE)" },
        {NameColumnName, "VARCHAR2(20 BYTE)" },
        {DescriptionColumnName, "VARCHAR(50 BYTE)" },
        {PriceColumnName, "NUMBER(8,2)" },
        {QuantityColumnName, "NUMBER(8,0)" },
        {OffsetColumnName, "NUMBER(19,0)" },
        {PartitionColumnName, "NUMBER(5,0)" },
    };

    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable(ToTable);
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id)
            .HasColumnType(DataTypes[IdColumnName])
            .HasColumnName(IdColumnName);
        builder.Property(p => p.Name)
            .HasColumnType(DataTypes[NameColumnName])
            .HasColumnName(NameColumnName);
        builder.Property(p => p.Description)
            .HasColumnType(DataTypes[DescriptionColumnName])
            .HasColumnName(DescriptionColumnName);
        builder.Property(p => p.Price)
            .HasColumnType(DataTypes[PriceColumnName])
            .HasColumnName(PriceColumnName);
        builder.Property(p => p.Quantity)
            .HasColumnType(DataTypes[QuantityColumnName])
            .HasColumnName(QuantityColumnName);
        builder.Property(p => p.Offset)
            .HasColumnType(DataTypes[OffsetColumnName])
            .HasColumnName(OffsetColumnName);
        builder.Property(p => p.Partition)
            .HasColumnType(DataTypes[PartitionColumnName])
            .HasColumnName(PartitionColumnName);
    }
}
