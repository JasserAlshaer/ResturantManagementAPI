namespace ResturantManagementAPI.Models.Entites
{
    public class Ingredidiante
    {
        public int Id { get; set; }
        public float PricePerUnit {  get; set; }   
        public string IngredientName { get; set; }
        public int StockQuantity { get; set; }


        public virtual List<ItemIngredidiante> ItemIngredidiantes { get; set; }

    }
}
