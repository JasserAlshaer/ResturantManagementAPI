using ResturantManagementAPI.Models.Shared;

namespace ResturantManagementAPI.Models.Entites
{
    public class Ingredidiante : ParentEntity
    {
        
        public float PricePerUnit {  get; set; }   
        public string IngredientName { get; set; }
        public virtual List<ItemIngredidiante> ItemIngredidiantes { get; set; }

    }
}
