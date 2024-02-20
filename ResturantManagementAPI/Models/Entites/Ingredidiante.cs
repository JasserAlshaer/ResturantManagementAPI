namespace ResturantManagementAPI.Models.Entites
{
    public class Ingredidiante
    {
        public int Id { get; set; }
        float PricePerUnit {  get; set; }   
        string IngredientName { get; set; }
        public virtual List<ItemIngredidiante> ItemIngredidiantes { get; set; }

    }
}
