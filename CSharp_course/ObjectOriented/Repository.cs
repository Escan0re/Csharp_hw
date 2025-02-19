namespace ObjectOriented
{
    class Repository
    {
        private Person[] people;
        private int count;
        private int index = 0;

        public Repository(int count)
        {
            this.count = count;
            people = new Person[count];
        }

        public void Append(Person person)
        {
            if(this.index >= this.count) return;
            people[index] = person;
            index++;
        }

        public void Print()
        {
            for (var i = 0; i < this.index; i++)
            {
                var temp = people[i];
                Console.WriteLine($"Имя: {temp.Name}, Возраст: {temp.Age}");
            }
        }
    }
}