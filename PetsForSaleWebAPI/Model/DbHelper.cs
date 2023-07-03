namespace PetsForSaleWebAPI.Model;

public class DbHelper
{
    private readonly EFDataContext _context;
    public DbHelper(EFDataContext context)
    {
        _context = context;
    }
    public HashSet<PetsCategoryModel> GetPetsCategory()
    {
        HashSet<PetsCategoryModel> response = new();
        var dataHashSet = _context.PetsCategories.ToHashSet();
        foreach (var item in dataHashSet)
        {
            response.Add(new PetsCategoryModel() { PetCatId = item.pet_cat_id, PetCatName = item.pet_cat_name });
        }
        return response;
    }
}