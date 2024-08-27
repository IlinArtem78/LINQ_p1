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

class Program
{
    static void Main(string[] args)
    {
        try
        {
        string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };
        Console.WriteLine("Выберите тип программы 1 или 2, 3 - простые методы расширения, 4 - Задание 8, 5 - Задание 14.1.1, 6 - Задание 14.1.2, " +
            "8 - Задание 14.2.1, 9 - Задание 14.2.3"); 
        byte Num = byte.Parse(Console.ReadLine());
            switch (Num)
            {
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
                   // Выберите всех студентов моложе 27, сгенерируйте из них анкеты(модель класса расположена ниже).
                    var application1 = from u in students   
                                        where u.Age < 27
                    let year = DateTime.Now.Year - u.Age
                    
                    select new
                    {
                        Name = u.StudentName,
                        YearOfBirth = year
                    };
                    
                    foreach (var st in application1)
                    {
                        
                        Console.WriteLine(st);
                    }



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
}