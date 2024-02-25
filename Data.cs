namespace LearnLINQ
{
    class Data
    {
        public static int[] Numbers = [3, 8, 1, 200, 100, 11, 6, 12];

        public static string[] Words = ["lion", "tiger", "giraffe"];

        public static IEnumerable<Food> Food =
        new[]
        {
                new Food(1, "Chicken", FoodType.Meat, 4.99m),
                new Food(2, "Beef", FoodType.Meat, 6.99m),
                new Food(3, "Grapefruit", FoodType.Fruit, 1.99m),
                new Food(4, "Pork", FoodType.Meat, 5.99m),
                new Food(5, "Carrots", FoodType.Vegetables,.99m),
                new Food(6, "Cabbage", FoodType.Vegetables,.89m ),
                new Food(7, "Oranges", FoodType.Fruit, 1.50m),
        };

        public static IEnumerable<Person> People =
           new[]
           {
               new Person(1, "John", new [] {
                   Food.ElementAt(0),
                   Food.ElementAt(1),
               }),
               new Person(2, "Jack", new [] {
                   Food.ElementAt(2),
                   Food.ElementAt(3),
               }),
               new Person(3, "Mary", new [] {
                   Food.ElementAt(4),
                   Food.ElementAt(5),
               }),
               new Person(4, "Bob", new [] {
                   Food.ElementAt(6)
               })
           };

        public static IEnumerable<Restaurant> Restaurants = new[]
        {
            new Restaurant(id: 1, name: "Meat Restaurant"),
            new Restaurant(id: 2, name: "Vegetables Restaurant"),
            new Restaurant(id: 3, name: "Fruit Restaurant"),
        };

        public static IEnumerable<Reservation> Reservations =
            new[]
            {
                new Reservation(restaurantId:2, personId:1, new DateTime(2024, 10, 1, 12, 0, 0)),
                new Reservation(restaurantId:3, personId:3, new DateTime(2024, 11, 1, 12, 0, 0)),
                new Reservation(restaurantId:1, personId:2, new DateTime(2024, 12, 1, 12, 0, 0)),
                new Reservation(restaurantId:2, personId:1, new DateTime(2024, 01, 1, 12, 0, 0)),
            };
    }
}
