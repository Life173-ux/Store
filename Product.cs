namespace Store
{
    class Product
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }

        public virtual double GetDiscountPrice(User user)
        {
            if (user.Spent < 300)
            {
                return Price;
            }

            if (user.Spent < 1000)
            {
                return Price * 0.9;
            }

            return Price * 0.8;
        } 
    }
}