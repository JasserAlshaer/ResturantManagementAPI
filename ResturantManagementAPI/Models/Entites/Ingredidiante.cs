using ResturantManagementAPI.Models.Shared;

namespace ResturantManagementAPI.Models.Entites
{
    public class Ingredidiante : ParentEntity
    {
        
        public float PricePerUnit {  get; set; }   
        public string IngredientName { get; set; }
        public int Quantity {  get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public virtual List<ItemIngredidiante> ItemIngredidiantes { get; set; }

    }
}
