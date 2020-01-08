using System;

namespace Store
{
    class Informant 
    {
        public void Buy(User user, Product product)
        {
            double price = product.GetDiscountPrice(user);
            user.ReduceBalance(price);
            Console.WriteLine($"{user.Name} купил {product.Name} за {price}. Товар отправлен!");
        }
    }
}