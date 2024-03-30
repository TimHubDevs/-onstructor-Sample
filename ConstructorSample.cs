public class ConstructorSample
{
    class City
    {
        private School _schoolOne;
        private School _schoolTwo;
        private School _schoolThree;

        private void CreateSchool()
        {
            _schoolOne = new School(80, 10.5f, "Garward", new Director("Ivan", 26));
            _schoolTwo = new School(50, 30.35f, "Tall", new Director("Maria", 89));
            _schoolThree = new School(50, 30.35f, "Tall", new Director());
        }
    }

    class School
    {
        private int _roomAmount;
        private float _height;
        private string _name;
        private Director _director;

        public School(int roomAmount, float height, string name, Director director)
        {
            _roomAmount = roomAmount;
            _height = height;
            _name = name;
            _director = director;
            Build();
        }

        void Build()
        {
            CreateRoom(_roomAmount);
        }

        void CreateRoom(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                //create room
            }
        }
    }

    class Director
    {
        public string _name = "Tim";
        public int _age = 45;

        public Director(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public Director()
        {
        }
    }
}