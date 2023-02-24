using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6._6
{
	internal class Program
	{
		static void Main(string[] args)
		//Справочник " Сотрудники "

		{
			Way();

		}
		/// <summary>
		/// Меню
		/// </summary>
		static void Way()
		{
			WriteLine("'1' - Вывести данные на экран. '2' - Заполнить данные и добавить новую записть в конец списка. 3 - Проверка. 4 - Выход");
			string num = ReadLine();
			switch (num)
			{
				case "1":
					Append();
					break;
				case "2":
					Print();
					break;
				case "3":
					P();
					break;
				case "4":
					
					break;
			}

		}
		/// <summary>
		/// Проверка
		/// </summary>
		static void P()
		{

			string Employees = @"Employees.txt";

			bool fileExist = File.Exists(Employees);
			if (fileExist)
			{
				Console.WriteLine("Файл существует.");
			}
			else
			{
				Console.WriteLine("Файл не существует.");
				
			}
			Way();

		}
		/// <summary>
		/// Запись 
		/// </summary>
		static void Print()
		{
			using (StreamWriter sw = new StreamWriter("Employees.txt", true, Encoding.Unicode))
			{
				
				char key = 'д';
				do
				{
					string text = string.Empty;

					Write("ID: ");
					string id = ReadLine();
				
					DateTime dateTime = DateTime.Now;

					Write("Ф.И.О: ");
					string fio = ReadLine();

					Write("Возраст: ");
					byte age = byte.Parse(ReadLine());

					Write("Рост: ");
					int h = int.Parse(ReadLine());

					Write("Дата рождениия: ");
					string data = ReadLine();

					Write("Место рождения: ");
					string spawn = ReadLine();

					text = id + "#" + dateTime + "#" + fio + "#" + age + "#" + h + "#" + data + "#" + spawn; 
					sw.WriteLine(text);

					WriteLine("Продолжить - Д/Н"); key = ReadKey(true).KeyChar;
				}
				while (char.ToLower(key) == 'д');
			}
			
			Way();
		}
		/// <summary>
		/// Четение
		/// </summary>
		static void Append()
		{
			using (StreamReader sr = new StreamReader("Employees.txt", Encoding.Unicode ))
			{
				string Line;
				WriteLine($"{"ID: "}{"Время: "}{"Ф.И.О: "}{"Возраст: "}{"Рост: "}{"Дата рождениия: "}{"Место рождения: "} ");

				while ((Line = sr.ReadLine()) != null)
				{ 
				string[] data = Line.Split('#');
					WriteLine($"{data[0]} {data[1]} {data[2]} {data[3]} {data[4]} {data[5]} {data[6]} ");
				}
			}
			
			Way();
		}
	}
}
