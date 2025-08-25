using connectOracleDBTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static connectOracleDBTest.Ultilites.Status;

namespace connectOracleDBTest.Data.EntityConfig;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public const string ToTable = "ORDERS";
    public const string IdColumnName = "ORDER_ID";
    public const string TotalAmountColumnName = "TOTAL_AMOUNT";
    public const string CustomerIdColumnName = "CUSTOMER_ID";
    public const string ProductIdColumnName = "PRODUCT_ID";
    public const string StatusColumnName = "STATUS";
    public const string OffsetColumnName = "OFFSET";
    public const string PartitionColumnName = "PARTITION";

    public static Dictionary<string, string> DataTypes = new Dictionary<string, string>
    {
        {IdColumnName,"VARCHAR2(5 BYTE)" },
        {TotalAmountColumnName,"NUMBER(8,2)" },
        {CustomerIdColumnName,"VARCHAR2(5 BYTE)" },
        {ProductIdColumnName,"VARCHAR2(5 BYTE)" },
        {StatusColumnName,"NUMBER(1,0)" },
        {OffsetColumnName,"NUMBER(19,0)" },
        {PartitionColumnName,"NUMBER(5,0)" },
    };
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable(ToTable);
        builder.HasKey(o => o.Id);
        builder.Property(o => o.Id)
            .HasColumnType(DataTypes[IdColumnName])
            .HasColumnName(IdColumnName);

        builder.Property(o => o.TotalAmount)
            .HasColumnType(DataTypes[TotalAmountColumnName])
            .HasColumnName(TotalAmountColumnName);

        builder.Property(o => o.CustomerId)
            .HasColumnType(DataTypes[CustomerIdColumnName])
            .HasColumnName(CustomerIdColumnName);

        builder.Property(o => o.ProductId)
            .HasColumnType(DataTypes[ProductIdColumnName])
            .HasColumnName(ProductIdColumnName);

        builder.Property(o => o.Status)
            .HasConversion<int>()
            .HasColumnType(DataTypes[StatusColumnName])
            .HasColumnName(StatusColumnName);

        builder.Property(o => o.Offset)
            .HasColumnType(DataTypes[OffsetColumnName])
            .HasColumnName(OffsetColumnName);

        builder.Property(o => o.Partition)
            .HasColumnType(DataTypes[PartitionColumnName])
            .HasColumnName(PartitionColumnName);
    }
}
