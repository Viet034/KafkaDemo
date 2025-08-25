using connectOracleDBTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace connectOracleDBTest.Data.EntityConfig;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public const string TableName = "CUSTOMER";
    public const string IdColumnName = "CUSTOMER_ID";
    public const string NameColumnName = "FULL_NAME";
    public const string PhoneColumnName = "PHONE_NUMBER";
    public const string GenderColumnName = "GENDER";
    public const string EmailColumnName = "EMAIL";
    public const string OffsetColumnName = "OFFSET";
    public const string PartitionColumnName = "PARTITION";

    public static Dictionary<string, string> DataTypes = new Dictionary<string, string>
    {
        {NameColumnName, "VARCHAR2(20 BYTE)" },
        {IdColumnName, "VARCHAR2(5 BYTE)" },
        {PhoneColumnName, "VARCHAR2(20 BYTE)" },
        {GenderColumnName, "NUMBER(1,0)" },
        {EmailColumnName, "VARCHAR2(25 BYTE)" },
        {OffsetColumnName, "NUMBER(19,0)" },
        {PartitionColumnName, "NUMBER(5,0)" },
    };
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable(TableName);
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id)
               .HasColumnType(DataTypes[IdColumnName])
               .HasColumnName(IdColumnName);
        builder.Property(c => c.Name)
                .HasColumnType(DataTypes[NameColumnName])
                .HasColumnName(NameColumnName);
        builder.Property(c => c.Phone)
                .HasColumnType(DataTypes[PhoneColumnName])
                .HasColumnName(PhoneColumnName);
        builder.Property(c => c.Gender)
                .HasColumnType(DataTypes[GenderColumnName]).HasConversion<int>()
                .HasColumnName(GenderColumnName);
        builder.Property(c => c.Email)
                .HasColumnType(DataTypes[EmailColumnName])
                .HasColumnName(EmailColumnName);
        builder.Property(c => c.Offset)
                .HasColumnType(DataTypes[OffsetColumnName])
                .HasColumnName(OffsetColumnName);
        builder.Property(c => c.Partition)
                .HasColumnType(DataTypes[PartitionColumnName])
                .HasColumnName(PartitionColumnName);
    }
}
