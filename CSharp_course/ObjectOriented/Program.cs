using ObjectOriented;

var person1 = new Person("Ваня К.", 23);
var person2 = new Person("Юля К.", 21);

var repository = new Repository(10);
for (var i = 0; i < 100; i++)
{
    repository.Append(person1);
}


repository.Print();