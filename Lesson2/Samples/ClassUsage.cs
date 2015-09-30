namespace Lesson2.Samples
{
	public class ClassUsage
	{
		static void EntryPoint()
		{
			// Класс - это лишь шаблон, свой тип данных
			// Программы манипулируют именно объектами
			
			// Создав класс, вы можете объявлять переменную этого типа так же, как и уже знакомых вам int, string
			Classes classInstance;

			// Точно так же вы можете объявить массив экземпляров вашего класса
			Classes[] classInstances;

			// Это только объявление. Инициализация таких переменных отличается от int, string, etc
			// Инициализация происходит с помощью ключевого слова new и вызова конструктора
			classInstance = new Classes(0);
			classInstances = new Classes[10]; // не путайте создание массива
			classInstances[0] = new Classes(10); // и создание объекта

			// После объявления вы можете пользоваться публичными элементами класса: полями, методами, свойствами
			string methodResult = classInstance.MakeSomething(42);
			int propertyValue = classInstance.ClassProperty;
			classInstance.ClassProperty = 24;

			// int fieldValue = classInstance._classField; - вызовет ошибку компиляции
			// Т.к. _classField объявлен private;
		}
	}
}
