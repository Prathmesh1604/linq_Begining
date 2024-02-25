namespace LearnLINQ
{
    class Reservation(int restaurantId, int personId, DateTime date)
    {
        public int RestaurantId { get; set; } = restaurantId;
        public int PersonId { get; set; } = personId;
        public DateTime Date { get; set; } = date;
    }
}
