// See https://aka.ms/new-console-template for more information



//LINQ to Objects: применяется для работы с массивами и коллекциями;
//LINQ to Entities: применяется для работы с базой данных через Entity Framework;
//LINQ to SQL: используется как технология доступа к данным в MS SQL Server;
//LINQ to XML: применяется при работе с файлами XML;
//LINQ to DataSet: применяется при работе с объектом DataSet;
//Parallel LINQ(PLINQ): используется для выполнения параллельных запросов.

//Задача: выбрать имена на букву А и отсортировать в алфавитном порядке.
using LINQ_p1;
using System.Linq;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        try
        {
        string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };
        Console.WriteLine("Введите 12 для доступа к Заданию 14.3.3"); 
        byte Num = byte.Parse(Console.ReadLine());
            switch (Num)
            {
                /*
                case 1:

                    List<string> list = new List<string>();
                    foreach (var person in people)
                    {
                        if (person.ToUpper().StartsWith("А"))
                        {
                            list.Add(person);
                        }
                    }
                    list.Sort();
                    foreach (var person in list)
                    {
                        Console.WriteLine(person);
                    }
                    break;
                case 2:
                    var selectedPeople = from p in people // промежуточная переменная p 
                                         where p.StartsWith("А") // фильтрация по условию
                                         orderby p // сортировка по возрастанию (дефолтная)
                                         select p; // выбираем объект и сохраняем в выборку

                    foreach (string s in selectedPeople)
                        Console.WriteLine(s);
                    break;
                case 3:
                    SimpleExtLinq simpleExtLinq = new SimpleExtLinq();
                    break;
                case 4:
                    //Используйте выражения LINQ, чтобы достать оттуда все имена и вывести их в консоль в алфавитном порядке.
                    var objects = new List<object>()
                    {
                        1,
                         "Сергей ",
                         "Андрей ",
                          300,
                    };
                    var names = from a in objects
                                where a is string // проверка на совместимость с типом
                                orderby a // сортировка по имени
                                select a; // выборка

                    foreach (var name in names)
                        Console.WriteLine(name);



                    break;
                case 5:
                    // Словарь для хранения стран с городами
                    var Countries = new Dictionary<string, List<City>>();

                    // Добавим Россию с её городами
                    var russianCities = new List<City>();
                    russianCities.Add(new City("Москва", 11900000));
                    russianCities.Add(new City("Санкт-Петербург", 4991000));
                    russianCities.Add(new City("Волгоград", 1099000));
                    russianCities.Add(new City("Казань", 1169000));
                    russianCities.Add(new City("Севастополь", 449138));
                    Countries.Add("Россия", russianCities);

                    // Добавим Беларусь
                    var belarusCities = new List<City>();
                    belarusCities.Add(new City("Минск", 1200000));
                    belarusCities.Add(new City("Витебск", 362466));
                    belarusCities.Add(new City("Гродно", 368710));
                    Countries.Add("Беларусь", belarusCities);

                    // Добавим США
                    var americanCities = new List<City>();
                    americanCities.Add(new City("Нью-Йорк", 8399000));
                    americanCities.Add(new City("Вашингтон", 705749));
                    americanCities.Add(new City("Альбукерке", 560218));
                    Countries.Add("США", americanCities);
                    //А теперь попробуйте выбрать все города, название у которых не длиннее 10 букв, и отсортируйте их по длине названия.
                    var LenthCity = russianCities.Where(c => c.Name.Length <= 10).OrderBy(c => c.Name.Length);
                    Console.WriteLine($"Города по длине > 10  {LenthCity}");

                    break;
                case 6:
                    //Соедините все слова в одну последовательность (каждое слово — отдельный элемент последовательности).
                    string[] text = { "Раз два три",
                     "четыре пять шесть",
                     "семь восемь девять" };
                    var words = from str in text // пробегаемся по элементам массива
                                from word in str.Split(' ') // дробим каждый элемент по пробелам, сохраняя в новую последовательность
                                select word;
                    foreach (var word in words)
                    {
                        Console.WriteLine(word);
                    }
                    break;
                case 7:
                    var numsList = new List<int[]>()
                    {
                     new[] {2, 3, 7, 1},
                     new[] {45, 17, 88, 0},
                     new[] {23, 32, 44, -6},
                    };
                    //Сделайте выборку всех чисел в новую коллекцию, расположив их в ней по возрастанию.
                    var newCollect = from col in numsList
                                     from s in col
                                     orderby s
                                     select s;
                    foreach (var c in newCollect)
                    {
                        Console.WriteLine(c);
                    }

                    break;

                case 8:
                    //Сделайте выборку в анонимный тип с одновременной сортировкой слов по длине.
                    //Результат выведите в консоль.
                    string[] words1 = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };
                    var nam = words1.Select(u => new
                    {
                        Name = u,
                        Length = u.Length,

                    })
                      .OrderBy(c => c.Name.Length);   
                    foreach(var c in  nam)
                    {
                        Console.WriteLine(c);
                    }
                break;
                case 9:
                    List<Student> students = new List<Student>
                    {
                        new Student {StudentName="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                        new Student {StudentName="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                        new Student {StudentName="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
                        new Student {StudentName="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
                    };
                    var coarses = new List<Coarse>
                    {
                     new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
                     new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
                    };
                    // Выберите всех студентов моложе 27, сгенерируйте из них анкеты(модель класса расположена ниже).
                    var application1 = from u in students
                                       from course in coarses
                                       where u.Age < 29
                                       where u.Languages.Contains("английский")
                                       where course.Name.Contains("Язык программирования C#")
                    let year = DateTime.Now.Year - u.Age
                    
                    select new 
                    {
                        Name = u.StudentName,
                        YearOfBirth = year,
                        NameCourse = course.Name,
                    };
                    
                    foreach (var st in application1)
                    {
                        
                        Console.WriteLine(st);
                    }



                    break;
                case 10:
                    var contacts = new List<Contact>()
                    {
                         new Contact() { Name = "Андрей", Phone = 7999945005 },
                         new Contact() { Name = "Сергей", Phone = 799990455 },
                         new Contact() { Name = "Иван", Phone = 79999675 },
                         new Contact() { Name = "Игорь", Phone = 8884994 },
                         new Contact() { Name = "Анна", Phone = 665565656 },
                         new Contact() { Name = "Василий", Phone = 3434 }
                    
                    
                    };
                    Console.WriteLine("Введите значение страницы контактов");
                    while (true)
                    {
                       byte keyChar = byte.Parse(Console.ReadLine()); // получаем символ с консоли
                        IEnumerable<Contact> page = null;

                        switch (keyChar)
                        {
                            case 1:
                                 page = contacts.Take(2);
                                break; 
                                case 2:
                                page = contacts.Skip(2).Take(2);
                                break; 
                                case 3:
                                page = contacts.Skip(2).Take(2);
                                break; 
                                default:
                                Console.WriteLine($"Ошибка ввода, страницы {keyChar} не существует");
                                continue;
                                break;
                        }
                        foreach (var contact in page)
                            Console.WriteLine(contact.Name + " " + contact.Phone);
                        
                    }


                    break;
                case 11:
                    // Подготовка данных
                    var cars = new List<Car>()
                        {
                             new Car("Suzuki", "JP"),
                             new Car("Toyota", "JP"),
                             new Car("Opel", "DE"),
                             new Car("Kamaz", "RUS"),
                             new Car("Lada", "RUS"),
                             new Car("Lada", "RUS"),
                              new Car("Honda", "JP"),
                        };

                    cars.RemoveAll(x => x.CountryCode == "JP");
                    var notJapanCars = cars.SkipWhile(car => car.CountryCode == "JP");
                    foreach (var notJapanCar in notJapanCars)
                        Console.WriteLine(notJapanCar.Manufacturer);
                    Console.WriteLine("Пропустим японские машины в начале списка" + cars.RemoveAll(x => x.CountryCode == "JP"));
                    Console.WriteLine();
                    Console.WriteLine("Теперь выберем только японские машины из начала списка");
                    var japanCars = cars.TakeWhile(car => car.CountryCode == "JP");

                    foreach (var japanCar in japanCars)
                        Console.WriteLine(japanCar.Manufacturer);
                    break;
                */
                case 12:
                    Task1 task1 = new Task1();
                break;
                default:
                    Console.WriteLine("Введен неверный номер"); 
                break;


            }
        }
        catch (Exception ex) 
        {
        
            Console.WriteLine(ex.ToString());
        }

    }


  
}



public class City
{
    public City(string name, long population)
    {
        Name = name;
        Population = population;
    }

    public string Name { get; set; }
    public long Population { get; set; }
}
public class Application
{
    public string Name { get; set; }
    public int YearOfBirth { get; set; }
    public string NameCourse { get; set; }
}

public class Coarse
{
    public string Name { set; get; }
    public DateTime StartDate { get; set; }
}

public class Contact
{
    public string Name { get; set; }
    public decimal Phone {  get; set; } 
}
public class Car
{
    public string Manufacturer { get; set; }
    public string CountryCode { get; set; }

    public Car(string manufacturer, string countryCode)
    {
        Manufacturer = manufacturer;
        CountryCode = countryCode;
    }
}
