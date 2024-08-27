using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_p1
{
    internal class SimpleExtLinq
    {
        public SimpleExtLinq() {
            try
            {


                Console.WriteLine("Выберите работу примера метода расширения LINQ: \n 1 - orderBy - Упорядочивает элементы по возрастанию.  \n 2 - OrderByDescending - Упорядочивает элементы по убыванию \n 3 - Where - Определяет фильтр выборки. \n 4 - All -  Определяет, все ли элементы коллекции удовлетворяют определенному условию" +
                    "\n 5 - Any - Определяет, удовлетворяет ли хотя бы один элемент коллекции определенному условию.  \n 6 - GroupBy - Группирует элементы по ключу. " +
                    "\n 7 - ThenBy - Задает дополнительные критерии для упорядочивания элементов возрастанию. \n 8 - ThenByDescending - Задает дополнительные критерии для упорядочивания элементов по убыванию. \n 9 - Reverse -  Располагает элементы в обратном порядке. \n 10 - Contains - Определяет, содержит ли коллекция определенный элемент." +
                    " \n 11 - Distinct - Удаляет дублирующиеся элементы из коллекции. \n 12 - Except - Возвращает разность двух коллекцию, то есть те элементы, которые создаются только в одной коллекции." +
                    "\n 13 - Union - Объединяет уникальные элементы двух однородных коллекций. \n 14 - Intersect  - Возвращает пересечение двух коллекций, то есть те элементы, которые встречаются в обоих коллекциях." +
                    "\n 15 - Count -  Подсчитывает количество элементов коллекции, которые удовлетворяют определенному условию.\n 16 - Sum -  Подсчитывает сумму числовых значений в коллекции.\n 17 - Average - Подсчитывает cреднее значение числовых значений в коллекции.  \n 18 -Min, Max - Находит минимальное и максимальное значение соответственно." +
                    "\n 19 - Take - Выбирает определенное количество элементов.  \n 20 - Skip - Выбирает определенное количество элементов. \n 21 - TakeWhile - Возвращает цепочку элементов последовательности до тех пор, пока условие истинно." +
                    "\n 22 - SkipWhile - Пропускает элементы в последовательности, пока они удовлетворяют заданному условию, и затем возвращает оставшиеся элементы.\n 23 - Concat - Объединяет две коллекции.\n 24 - Zip - Объединяет две коллекции в соответствии с определенным условием. \n 25 - First - Выбирает первый элемент коллекции, удовлетворяющий условию. \n 26 - FirstOrDefault - Выбирает первый элемент коллекции, удовлетворяющий условию, или возвращает значение по умолчанию. " +
                    "\n 27 - Single - Выбирает единственный элемент коллекции, если коллекция содержит больше или меньше одного элемента, удовлетворяющего условию, то генерируется исключение. \n 28 - SingleOrDefault - Выбирает первый элемент коллекции или возвращает значение по умолчанию. \n 29 - ElementAt - Выбирает элемент последовательности по определенному индексу." +
                    "\n 30 - Last - Выбирает последний элемент коллекции.  \n 31 - LastOrDefault - Выбирает последний элемент коллекции или возвращает значение по умолчанию.");
                var nums = new List<int>() { 2, 9, 7 };
                var list1 = new List<int>() { 7, 2, };
                var list2 = new List<int>() { 2, 8 };
                var studentList = new List<Student>() {
                             new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                             new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                             new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                             new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                             new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
                             new Student() { StudentID = 6, StudentName = "Ram" , Age = 18 }
                            };
                string[] students = { "Оля", "Иван", "Сергей",
                     "Бонифаций"};
                byte Num = byte.Parse(Console.ReadLine());
                switch (Num)
                {
                    case 1:
                        foreach (var n in nums)
                        {
                            Console.WriteLine(n);
                        }
                        Console.WriteLine("OrderBy\r\n Упорядочивает элементы по возрастанию.");
                        var orderedNums1 = nums.OrderBy(n => n);

                        // вернёт 2, 7, 9
                        foreach (var num in orderedNums1)
                        {
                            Console.WriteLine(num);

                        }
                        break;
                   case 2:
                        Console.WriteLine("OrderByDescending\r\nУпорядочивает элементы по убыванию.");
                        Console.WriteLine(nums);
                        var orderedNums2 = nums.OrderByDescending(n => n);

                        // вернeт 9, 7, 2
                        foreach (var num in orderedNums2)
                            Console.WriteLine(num);
                        break;
                        case 3:
                        Console.WriteLine("Where\r\nОпределяет фильтр выборки.");
                        Console.WriteLine(nums);
                        var lessThenFive = nums.Where(n => n < 5);

                        // вернёт 2
                        foreach (var num in lessThenFive)
                            Console.WriteLine(num);
                        break;
                        case 4:
                        Console.WriteLine("All\r\nОпределяет, все ли элементы коллекции удовлетворяют определенному условию.");
                        Console.WriteLine(nums);
                        if (nums.All(n => n < 5))
                        {
                            Console.WriteLine("Все меньше пяти");
                        }
                        break;
                        case 5:
                        Console.WriteLine("Any\r\nОпределяет, удовлетворяет ли хотя бы один элемент коллекции определенному условию.");
                        Console.WriteLine(nums);
                        if (nums.Any(n => n < 5))
                        {
                            Console.WriteLine("Хотя бы один < 5");
                        }
                        break;
                        case 6:
                        Console.WriteLine("GroupBy\r\nГруппирует элементы по ключу.");

                        var employees = new List<Employee>
                            {
                             new Employee {Name="Иван", DepartMent= "Продажи" },
                            new Employee {Name="Анна", DepartMent="Продажи" },
                            new Employee {Name="Кирилл", DepartMent="Разработка" },
                            new Employee {Name="Дмитрий", DepartMent="Разработка" },
                            new Employee {Name="Олег", DepartMent="Разработка" },
                            };
                        foreach(var s in employees)
                        {
                            Console.WriteLine(s);
                        }
                        // группируем сотрудников по департаменту
                        var groups = employees.GroupBy(e => e.DepartMent);

                        foreach (var group in groups)
                        {
                            Console.WriteLine(group.Key);

                            foreach (var e in group)
                                Console.WriteLine(e.Name);

                            Console.WriteLine();
                        }
                        break;
                        case 7:
                        Console.WriteLine("ThenBy\r\nЗадает дополнительные критерии для упорядочивания элементов возрастанию.");
                       
                        // сортируем сначала по имени
                        // потом по возрасту (по возрастанию)
                        var byNameAndAge = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);
                        

                        break;
                        case 8:
                        Console.WriteLine("ThenByDescending\r\nЗадает дополнительные критерии для упорядочивания элементов по убыванию.");
                        var byNameAndAge1 = studentList
                            // сортируем сначала по имени
                        .OrderBy(s => s.StudentName)
                         // потом по возрасту (по убыванию)
                            .ThenByDescending(s => s.Age);
                        break;
                        case 9:
                        Console.WriteLine("Reverse\r\nРасполагает элементы в обратном порядке.");
                        nums.Reverse();
                        break;
                        case 10:
                        Console.WriteLine("Contains\r\nОпределяет, содержит ли коллекция определенный элемент");
                        if (nums.Contains(2))
                        {
                            Console.WriteLine("Нашли двойку");
                        }
                        break;
                        case 11:
                        Console.WriteLine("Distinct\r\nУдаляет дублирующиеся элементы из коллекции.");
                        var uniqueNums = nums.Distinct();

                        foreach (var number in uniqueNums)
                            Console.WriteLine(number);
                        break;
                        case 12:
                        Console.WriteLine("Except\r\nВозвращает разность двух коллекцию, то есть те элементы, которые создаются только в одной коллекции.");
                        var listOne = new List<int>() { 7, 2, 4, 11 };
                        var listTwo = new List<int>() { 2, 9, 7, 8, 0 };

                        var result = listOne.Except(listTwo);

                        foreach (var number in result)
                            Console.WriteLine(number);
                        break;
                        case 13:
                        Console.WriteLine("Union\r\nОбъединяет уникальные элементы двух однородных коллекций.");
                        var listOne1 = new List<int>() { 7, 2 };
                        var listTwo1 = new List<int>() { 2, 9 };

                        var result1 = listOne1.Union(listTwo1);

                        foreach (var number in result1)
                            Console.WriteLine(number);

                        // выведет 7, 2, 9
                        break;

                        case 14:
                        Console.WriteLine("Intersect\r\nВозвращает пересечение двух коллекций, то есть те элементы, которые встречаются в обоих коллекциях.");
                        var listOne2 = new List<int>() { 7, 2 };
                        var listTwo2 = new List<int>() { 2, 9 };

                        var result2 = listOne2.Intersect(listTwo2);

                        foreach (var number in result2)
                            Console.WriteLine(number);

                        // выведет общий элемент для обеих коллекций - 2
                        break;
                        case 15:
                        Console.WriteLine("Count\r\nПодсчитывает количество элементов коллекции, которые удовлетворяют определенному условию.");
                        var listOne3 = new List<int>() { 7, 2, 57, 8 };

                        var result3 = listOne3.Count(e => e < 10);

                        Console.WriteLine($"Количество элементов меньше 10: {result3}");
                        // Выведет 3
                        break;
                        case 16:
                        Console.WriteLine("Sum\r\nПодсчитывает сумму числовых значений в коллекции.");
                        var listOne4 = new List<int>() { 7, 2, 57, 8 };
                        var sum = listOne4.Sum();
                        Console.WriteLine(sum);
                        break;
                        case 17:
                        Console.WriteLine("Average\r\nПодсчитывает cреднее значение числовых значений в коллекции.");
                        var listOne5 = new List<int>() { 7, 2, 57, 8 };
                        var average = listOne5.Average();
                        Console.WriteLine(average);
                        // Выведет среднее арифметическое ( 18.5 )
                        break;
                        case 18:
                        Console.WriteLine("Min, Max\r\nНаходит минимальное и максимальное значение соответственно.");
                        var listOne6 = new List<int>() { 7, 2, 57, 8 };

                        Console.WriteLine(listOne6.Min()); // 2
                        Console.WriteLine(listOne6.Max()); // 57

                        break;
                        case 19:
                        Console.WriteLine("Take\r\nВыбирает определенное количество элементов.");
                        var listOne7 = new List<int>() { 7, 2, 57, 8 };
                         var res = listOne7.Take(2);
                        Console.WriteLine(res);
                        // выберет первые два элемента (7 и 2)
                        break;
                        case 20:
                        Console.WriteLine("Skip\r\nПропускает определенное количество элементов.");
                        var listOne8 = new List<int>() { 7, 2, 57, 8 };
                        var resul = listOne8.Skip(1);
                        Console.WriteLine(resul);
                        // пропустит 1 элемент (получит 2, 57, 8)
                        break;
                        case 21:
                        Console.WriteLine("TakeWhile\r\nВозвращает цепочку элементов последовательности до тех пор, пока условие истинно.");
                        var listOne9 = new List<int>() { 7, 2, 57, 8 };
                        var res2 = listOne9.TakeWhile(e => e < 10);
                        Console.WriteLine(res2);    
                        break;
                        case 22:
                        Console.WriteLine("SkipWhile\r\nПропускает элементы в последовательности, пока они удовлетворяют заданному условию, и затем возвращает оставшиеся элементы.");
                        var listOne10 = new List<int>() { 7, 2, 57, 8 };
                        var res3 = listOne10.SkipWhile(e => e < 10);
                        Console.WriteLine(res3);    
                        break;
                        case 23:
                        Console.WriteLine("Concat\r\nОбъединяет две коллекции.");
                        
                        var concatenation = list1.Concat(list2);
                        Console.WriteLine(concatenation);
                        break;
                        case 24:
                        Console.WriteLine("Zip\r\nОбъединяет две коллекции в соответствии с определенным условием.");
                        var result11 = list1.Zip(list2, (a, b) => a + b);
                        Console.WriteLine(result11);    
                        break;
                        case 25:
                        Console.WriteLine("First\r\nВыбирает первый элемент коллекции, удовлетворяющий условию.");
                        Console.WriteLine(list1.First());
                        break;
                        case 26:
                        Console.WriteLine("FirstOrDefault\r\nВыбирает первый элемент коллекции, удовлетворяющий условию, или возвращает значение по умолчанию");
                        Console.WriteLine(list1.FirstOrDefault(a => a < 7));
                        break;
                        case 27:
                        Console.WriteLine("Single\r\nВыбирает единственный элемент коллекции, если коллекция содержит больше или меньше одного элемента, удовлетворяющего условию, то генерируется исключение.");
                        string firstWithLongName = students.Single(student => student.Length > 8);

                        Console.WriteLine(firstWithLongName);
                        break;
                        case 28:
                        Console.WriteLine("SingleOrDefault\r\nВыбирает первый элемент коллекции или возвращает значение по умолчанию.");
                        string firstWithLongName1 = students.SingleOrDefault(student => student.Length > 10);
                        Console.WriteLine(firstWithLongName1);
                        break;
                        case 29:
                        Console.WriteLine("ElementAt\r\nВыбирает элемент последовательности по определенному индексу.");
                        var second = list1.ElementAt(1);
                        Console.WriteLine(second);
                        break;
                        case 30:
                        Console.WriteLine("Last\r\nВыбирает последний элемент коллекции.");
                        Console.WriteLine(list1.Last());
                        break;
                        case 31:
                        Console.WriteLine("LastOrDefault\r\nВыбирает последний элемент коллекции или возвращает значение по умолчанию.");
                        var emptyList = new List<int>() { };
                        Console.WriteLine(emptyList.LastOrDefault());
                        break;
                        default:
                        Console.WriteLine("Введен неподходящий номер"); 
                        break;  

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
    public class Employee
    {
        public string Name { get; set; }   
        public string DepartMent { get; set; }   
    }
}
