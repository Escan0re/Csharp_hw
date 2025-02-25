using Classroom;

var person1 = new Person("Ваня К.", 23);
var person2 = new Person("Юля К.", 21);
var student1 = new Student("Вася", 20, "№2020");
var employee1 = new Empolyee("Марина О.", 45, 80000);
var teacher1 = new Teacher("Павел С.", 32, "Биология");
var teacher2 = new Teacher("Сергей М.", 51, "Физика");

var repository = new Repository(10);
var printer = new Printer();

repository.Append(person1, person2, student1, employee1, teacher1, teacher2);

printer.Print(repository);