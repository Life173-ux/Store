using System;

// не дышать | not breathe
namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(после 300, а потом 1000 покупок действует скидка!)");
            Console.Write("Введите своё имя: ");
            string nameUser = Console.ReadLine();

            User user = new User(
                nameUser,
                "ул. Пушкина, дом 228",
                100000,
                0);
            
            // Молочные продукты
            Milk milk = new Milk(
                "Молоко",
                "Весёлый молочник",
                59);
            
            Cheese cheese = new Cheese(
                "Сыр",
                "Молочный Комбинат Воронежский",
                80);
            
            SourCream sourCream = new SourCream(
                "Сметана",
                "ООО «Курское молоко»",
                70);
            
            CottageCheese cottageCheese = new CottageCheese(
                "Творог",
                "Провинция",
                81);
            
            // Мясо
            Beef beef = new Beef(
                "Говядина",
                "Дом коров",
                150);
            
            Hen hen = new Hen(
                "Курица",
                "Куриный двор",
                120);
            
            Mutton mutton = new Mutton(
                "Баранина",
                "Нальчикский Мясокомбинат",
                145);
            
            Pork pork = new Pork(
                "Свинина",
                "Ростовский Мясокомбинат",
                130);
            
            // Хлеб
            Bread bread = new Bread(
                "Хлеб",
               "Хлебо Комбинат",
                25);
            Bun bun = new Bun(
                "Булочка",
                "Владхлеб",
                26);
            
            // Напитки
            Water water = new Water(
                "Вода",
                "Байкал",
                25);
            
            MineralWater mineralWater = new MineralWater(
                "Минеральная вода",
                "Кубай",
                35);
            
            Juice juice = new Juice(
                "Яблочный сок",
                "Моя семья",
                89);
            
            CocaCola cocaCola = new CocaCola(
                "Coca-Cola",
                "Coca-Cola Company",
                69);

            Product[] products = new Product[] {
                milk,
                cheese,
                sourCream,
                cottageCheese,
                cocaCola,
                juice,
                water,
                mineralWater,
                bread,
                bun,
                beef,
                hen,
                mutton,
                pork
            };

            Informant informer = new Informant();
            
            // Вывод
            
            Console.WriteLine();
            Console.WriteLine($"Здравствуйте {user.Name}");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Ваш баланс {user.Balance}");
                Console.WriteLine();
                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"Товар {i} {products[i].Name} по цене {products[i].Price}");
                }
                Console.WriteLine("Выберете номер товара и нажмите Enter:");

                string str = Console.ReadLine();
                int productNumber = Convert.ToInt32(str);

                if (productNumber >= 0 && productNumber < products.Length)
                {

                    if (products[productNumber].Price < user.Balance)
                    {
                        informer.Buy(user, products[productNumber]);
                    }
                    else
                    {
                        Console.WriteLine("У вас недостаточно средств");
                    }

                }
                else
                {
                    Console.WriteLine("Таких товаров нет");
                }
            }
        }
    }
}