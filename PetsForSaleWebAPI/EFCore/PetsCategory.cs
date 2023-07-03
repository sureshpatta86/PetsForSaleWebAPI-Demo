namespace PetsForSaleWebAPI.EFCore;

[Table("pets_category")]
public class PetsCategory
{
    [Key, Required, NotNull]
    public int pet_cat_id { get; set; }
    public string? pet_cat_name { get; set; }
}
