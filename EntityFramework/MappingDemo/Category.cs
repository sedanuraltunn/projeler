using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MappingDemo;

//Okunulurluğu azaltığından data annotation tercih edilmez. Yerine fluent mapping tercih edilir.

[Table("Kategoriler", Schema ="dbo")]
public class Category
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int CategoryKey { get; set; }

    [Column("Ad")]
    public string Name { get; set; } = string.Empty;

    [Column("Aciklama")]
    [StringLength(250)]
    [Required]
    public string Description { get; set; }

    [NotMapped]
    public string UniqueData => $"{CategoryKey}_{Name[0]}";
    public ICollection<Product>? Products { get; set; } //bir kategoride birden fazla ürün olabileceği için ICollection kullanıldı. bire "ÇOK" ilişki
                                                        //List'i EF görmediğinden sağlıklı çalışmaz. ICollection kullanılmalı
}
