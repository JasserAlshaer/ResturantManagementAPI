namespace ResturantManagementAPI.Helper.Enums
{
    public static class ResturnantManagementLookups
    {

        public enum PaymentMethod
        {
            PayPal = 101,
            Visa = 102,
            Cash = 103,
            Wallet = 106
        }


        public enum UserType
        {
            Admin,
            Employee,
            Client
        }

        public enum Status
        {
            Removed,
            Perparing,
            Pending,
            Completed,
            Rejected
        }


        public enum RecivingMethod
        {
            Delivery,
            ImmediateReceipt,
            Take_Away
        }
    }
}
