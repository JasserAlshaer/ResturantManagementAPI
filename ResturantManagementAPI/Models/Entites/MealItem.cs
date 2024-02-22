using ResturantManagementAPI.Models.Shared;

namespace ResturantManagementAPI.Models.Entites
{
    public class MealItem : ParentEntity
    {
        public int Qtn {  get; set; }
        public virtual Item Item { get; set; }
        public virtual Meal Meal { get; set; }
    }
}
