using System;

// не дышать | not breathe
namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(
                "Игорь",
                "ул. Пушкина, дом 228",
                10000,
                299);
            
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
               "Владхлеб",
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
            
            // Вывод
            Console.WriteLine("В какой отдел пойдёте? : ");
            Console.WriteLine("Хлебный отдел(1)");
            Console.WriteLine("Напитки(2)");
            Console.WriteLine("Молочная продукция(3)");
            Console.WriteLine("Мясо(4)");
            
            Console.WriteLine("----------------------");
            
            string userInput = Console.ReadLine();
            
            if (userInput == "1")
            {
                Console.WriteLine("Список товаров: ");
                Console.WriteLine("Хлеб: ");
                Console.WriteLine("Название: " + bread.Name);
                Console.WriteLine("Цена: " + bread.Price);
                Console.WriteLine("Производитель: " + bread.Company);
            }
        }
    }
}