namespace Classroom
{
    public class Repository
    {
        private Person[] storage;
        private int count;
        private int index = 0;
        public int Index => index;

        public Repository(int count)
        {
            this.count = count;
            storage = new Person[count];
        }

        public void Append(params Person[] people)
        {
            foreach (var person in people)
            {
                if(this.index >= this.count) return;
                storage[index] = person;
                index++;
            }
        }

        public Person GetPersonById(int id)
        {
            if (id < 0 || id >= index) return new Person("empty", -1);
            return storage[id];
        }
        
    }
}