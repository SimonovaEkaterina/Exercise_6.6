using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercise_6._6
{
	internal class Program
	{
		static void Main(string[] args)
		//Справочник " Сотрудники "

		{
			string Employees = @"Employees.txt";
			
			P(Employees);
			Way(Employees);
		}
		/// <summary>
		/// Меню
		/// </summary>
		static void Way(string Employees)
		{
			WriteLine("'1' - Вывести данные на экран. '2' - Заполнить данные и добавить новую записть в конец списка. '3' - Выход");
			string num = ReadLine();
			switch (num)
			{
				case "1":
					Append(Employees);
					break;
				case "2":
					Print(Employees);
					break;
				case "3":

					break;
			}
		}

		/// <summary>
		/// Проверка
		/// </summary>
		static void P(string Employees)
		{			
			bool fileExist = File.Exists(Employees);
			if (fileExist)
			{
				Console.WriteLine("Файл, существует.");
			}
			else
			{
				Console.WriteLine("Файл, не существует.");
				File.Create(Employees).Close();				
				WriteLine("Файл, Создан.");		
			}
		}
		/// <summary>
		/// Запись 
		/// </summary>
		static void Print(string Employees)
		{
			using (StreamWriter sw = new StreamWriter(Employees, true))
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
		}
		/// <summary>
		/// Четение
		/// </summary>
		static void Append(string Employees)
		{
			using (StreamReader sr = new StreamReader(Employees))
			{
				string Line;
				WriteLine($"{"ID: "}{"Время: "}{"Ф.И.О: "}{"Возраст: "}{"Рост: "}{"Дата рождениия: "}{"Место рождения: "} ");

				while ((Line = sr.ReadLine()) != null)
				{ 
				string[] data = Line.Split('#');
					WriteLine($"{data[0]} {data[1]} {data[2]} {data[3]} {data[4]} {data[5]} {data[6]} ");
				}
			}
			Way(Employees);
		}
	}
}
