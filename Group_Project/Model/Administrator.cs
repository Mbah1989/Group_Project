namespace Group_Project.Model
{
    public class Administrator
    {
        private int _id;

        public Administrator(int id)
        {
            _id = id;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}
