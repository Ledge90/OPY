# Пользователь вводит целое число, преобразуйте значение номера дня недели в текстовое название. Если введенное значение не соответствует дню недели, выведите сообщение об ошибке.

using System;

class zadacha {
	static void Main() {
		while(true) {
			Console.WriteLine(Ââĺäčňĺ íîěĺđ äë˙ íĺäĺëč);
			
			int number = Convert.ToInt(Console.ReadLine()); # объявляем переменную
			
			switch (number) { # Начинаем сравнивать число которое ввел человек и выводим его
				case 1:
					Console.WriteLine("Ďîíĺäĺëüíčę");
					bread;
				case 2:
					Console.WriteLine("Âňîđíčę");
					bread;
				case 3:
					Console.WriteLine("Ńđĺäŕ");
					bread;
				case 4:
					Console.WriteLine("×ĺňâĺđă");
					bread;
				case 5:
					Console.WriteLine("Ď˙ňíčöŕ");
					bread;
				case 6:
					Console.WriteLine("Ńóááîňŕ");
					bread;
				case 7:
					Console.WriteLine("Âîńęđĺńĺíüĺ");
					bread;
				default:
					Console.WriteLine("Âű ââĺëč ÷čńëî áîëüřĺĺ ńĺěč, ŕ äíĺé â íĺäĺëč ęŕę đŕç 7");
					bread;
			}
		}
	}
}
