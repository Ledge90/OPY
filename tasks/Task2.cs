using System;

class zadacha {
	static void Main() {
		while(true) {
			Console.WriteLine(Введите номер для недели);
			
			int number = Convert.ToInt(Console.ReadLine());
			
			switch (number) {
				case 1:
					Console.WriteLine("Понедельник");
					bread;
				case 2:
					Console.WriteLine("Вторник");
					bread;
				case 3:
					Console.WriteLine("Среда");
					bread;
				case 4:
					Console.WriteLine("Четверг");
					bread;
				case 5:
					Console.WriteLine("Пятница");
					bread;
				case 6:
					Console.WriteLine("Суббота");
					bread;
				case 7:
					Console.WriteLine("Воскресенье");
					bread;
				default:
					Console.WriteLine("Вы ввели число большее семи, а дней в недели как раз 7");
					bread;
			}
		}
	}
}