namespace Logic
{
    public class Animal
    {
        private int _id;
        private string _name;
        private DateTime _dob;
        private Category _category;

        public Animal(int id, string name, DateTime dob, Category category)
        {
            _id = id;
            _name = name;
            _dob = dob;
            _category = category;
        }
    }
}