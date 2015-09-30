// Это - пространство имён. В пределах одного пространства имён не может существовать классов с одинаковыми названиями
// В разных namespace - могут.
namespace Lesson2.Samples
{
	// Объявление класса содержит модификатор доступа, ключевое слово class и название класса
	public class Classes
	{
		// Внутри фигурных скобок содержится тело класса
		// В теле можно объявлять поля, что является данными класса
		// Они объявляются аналогично переменным с указанием модификатора доступа
		private int _classField;

		// Можно декларировать методы как обычные функции
		public string MakeSomething(int someParameter)
		{
			return "something" + someParameter;
		}

		// Специфичная для C# конструкция - свойства
		public int ClassProperty
		{
			get
			{
				return _classField;
			}
			set
			{
				_classField = value;
			}
		}

		// Создание экземпляра класса делается с помощью конструктора
		// Даже если он не объявлен в классе, CLR предоставит свой конструктор по умолчанию без параметров

		public Classes(int classParameter)
		{
			_classField = classParameter;
		}
	}
}
