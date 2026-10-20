using System;

class Student
{
    public string firstName;
    public string lastName;
    private int _age; // Изменено на int для соответствия свойству age

    public int age
    {
        get => _age;
        set
        {
            // Исправлен оператор сравнения '=>' на '>='
            if ((value >= 6) && (value <= 100))
            {
                _age = value;
            }
            else
            {
                Console.WriteLine("ошибка: возраст присвоен некорректно");
                // Убран недопустимый оператор 'break;'
            }
        }
    }

    // Добавлен конструктор для инициализации объекта
    public Student(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age; // Используем свойство, чтобы сработала проверка возраста
    }

    public string fullName 
    { 
        get 
        {
            return $"{firstName} {lastName}"; // Добавлен ключевое слово 'return'
        } 
        set
        {
            // Простая логика разделения строки на имя и фамилию
            var parts = value.Split(' ');
            firstName = parts.Length > 0 ? parts[0] : "";
            lastName = parts.Length > 1 ? parts[1] : "";
        }
    }
}

class Program
{
    static void Main()
    {
        // Добавлено ключевое слово 'new' для создания объекта
        Student student = new Student("Иван", "Петров", 19);
        Console.WriteLine($"привет, меня зовут {student.fullName}, мне {student.age} лет");
    }
}
