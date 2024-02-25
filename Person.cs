namespace LearnLINQ
{
    class Person(int id, string name, IEnumerable<Food> food)
    {
        public int Id { get; } = id;
        public string Name { get; } = name;
        public IEnumerable<Food> Food = food;
    }
}
