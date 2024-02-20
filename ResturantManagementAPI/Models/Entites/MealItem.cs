namespace ResturantManagementAPI.Models.Entites
{
    public class MealItem
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Item Item { get; set; }
        public virtual Meal Meal { get; set; }
    }
}
