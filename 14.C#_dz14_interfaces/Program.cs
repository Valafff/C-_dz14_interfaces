using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.C__dz14_interfaces
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Menu market = new Menu(new List<string> { "Вывести все товары", "Вывести продукты питания", "Вывести бытовую химию", "Добавить продукты питания", "Добавить бытовую химию", "Продать товар", "Выход" });
			int index;

			List<Goods> goods = new List<Goods> { };
			goods.Add(new Bread("Хлеб", 45, 100, 300, "Пшеничный", DateTime.Now, DateTime.Now.AddDays(3)));
			goods.Add(new Milk("Молочный продукт", 80, 100, 250, "Молоко", DateTime.Now, DateTime.Now.AddDays(10)));
			goods.Add(new Meat("Мясной продукт", 500, 30, 900, "Вырезка", DateTime.Now, DateTime.Now.AddDays(5)));
			goods.Add(new Soap("Мыло", 120, 90, "Домашняя химия", "Гигиена", DateTime.Now, DateTime.Now.AddDays(1095)));
			goods.Add(new Insecticides("Антижук", 120, 90, "Садовая химия", "Отрава для вредителей", DateTime.Now, DateTime.Now.AddDays(730)));

			//Временные позиции
			string tempName;
			string tempType;
			string tempType_2;
			double tempPrice;
			int tempCount;
			int tempCalorie;
			int tempDayManufactureDate;
			int tempMonthManufactureDate;
			int tempYearManufactureDate;
			int tempExperationDate;
			int tempIndex;


			do
			{
				index = market.KlacKlac_CS_v1();
				Console.Clear();
				Console.CursorTop = 10;
				switch (index)
				{
					case 0:
						//Распечатка всех товаров
						foreach (Goods good in goods)
						{
							good.Print();
						}
						break;
					case 1:
						//Вывод продуктов питания
						foreach (Goods food in goods)
						{
							if (food is Bread||  food is Meat || food is Milk)
								food.Print();
						}
						break;
					case 2:
						//Вывод бытовой химии
						foreach (Goods domestic in goods)
						{
							if (domestic is Soap || domestic is Insecticides)
								domestic.Print();
						}
						break;
					case 3:
						//ДОбавление продутов питания
						Console.Write("Введите вид товара: ");
						tempName = Console.ReadLine();
						Console.Write("Введите название товара: ");
						tempType_2 = Console.ReadLine();
						do
						{
							Console.Write("Введите цену: ");
							tempPrice = Convert.ToDouble(Console.ReadLine());
						}
						while (tempPrice < 0);
						do
						{
							Console.Write("Введите количество: ");
							tempCount = Convert.ToInt32(Console.ReadLine());
						}
						while (tempCount < 0);
						do
						{
							Console.Write("Введите калорийность: ");
							tempCalorie = Convert.ToInt32(Console.ReadLine());
						}
						while (tempCalorie < 0);
						do
						{
							Console.Write("Введите день изготовления: ");
							tempDayManufactureDate = Convert.ToInt32(Console.ReadLine());
						}
						while (tempDayManufactureDate <= 0 || tempDayManufactureDate > 31);
						do
						{
							Console.Write("Введите месяц изготовления: ");
							tempMonthManufactureDate = Convert.ToInt32(Console.ReadLine());
						}
						while (tempMonthManufactureDate <= 0 || tempMonthManufactureDate > 12);
						do
						{
							Console.Write("Введите год изготовления: ");
							tempYearManufactureDate = Convert.ToInt32(Console.ReadLine());
						}
						while (tempYearManufactureDate < 2020 || tempYearManufactureDate > DateTime.Now.Year);
						do
						{
							Console.Write("Введите срок годности(суток): ");
							tempExperationDate = Convert.ToInt32(Console.ReadLine());
						}
						while (tempExperationDate <= 0);
						goods.Add(new Bread(tempName, tempPrice, tempCount,  tempCalorie, tempType_2, new DateTime(tempYearManufactureDate, tempMonthManufactureDate, tempDayManufactureDate), new DateTime(tempYearManufactureDate, tempMonthManufactureDate, tempDayManufactureDate).AddDays(tempExperationDate)));
						break;
					case 4:
						//Добавление химии
						Console.Write("Введите название товара: ");
						tempName = Console.ReadLine();
						do
						{
							Console.Write("Введите цену: ");
							tempPrice = Convert.ToDouble(Console.ReadLine());
						}
						while (tempPrice < 0);
						do
						{
							Console.Write("Введите количество: ");
							tempCount = Convert.ToInt32(Console.ReadLine());
						}
						while (tempCount < 0);
						Console.Write("Введите тип: ");
						tempType = Console.ReadLine();
						Console.Write("Введите область применения: ");
						tempType_2 = Console.ReadLine();
						do
						{
							Console.Write("Введите день изготовления: ");
							tempDayManufactureDate = Convert.ToInt32(Console.ReadLine());
						}
						while (tempDayManufactureDate <= 0 || tempDayManufactureDate > 31);
						do
						{
							Console.Write("Введите месяц изготовления: ");
							tempMonthManufactureDate = Convert.ToInt32(Console.ReadLine());
						}
						while (tempMonthManufactureDate <= 0 || tempMonthManufactureDate > 12);
						do
						{
							Console.Write("Введите год изготовления: ");
							tempYearManufactureDate = Convert.ToInt32(Console.ReadLine());
						}
						while (tempYearManufactureDate < 2020 || tempYearManufactureDate > DateTime.Now.Year);
						do
						{
							Console.Write("Введите срок годности(суток): ");
							tempExperationDate = Convert.ToInt32(Console.ReadLine());
						}
						while (tempExperationDate <= 0);
						goods.Add(new Soap(tempName, tempPrice, tempCount, tempType, tempType_2, new DateTime(tempYearManufactureDate, tempMonthManufactureDate, tempDayManufactureDate), new DateTime(tempYearManufactureDate, tempMonthManufactureDate, tempDayManufactureDate).AddDays(tempExperationDate)));
						break;
					case 5:
						//Продажа товара
						bool is_sold = false;
						Console.Write("Введите id товара: ");
						tempIndex = Convert.ToInt32(Console.ReadLine());
						for (int i = 0; i < goods.Count(); i++)
						{
							if (goods[i].id == tempIndex)
							{
								Console.Write("Введите количество продаваемого товара: ");
								tempCount = Convert.ToInt32(Console.ReadLine());
								if (goods[i].TotalCount != 0 & tempCount <= goods[i].TotalCount)
								{
									goods[i].SellGoods(tempCount);
									is_sold = true;
								}
								break;
							}
						}
						if (!is_sold)
						{
							Console.WriteLine("Ошибка! Товар не продан");
						}
						else
						{
							Console.WriteLine("Товар продан");
						}
						break;
					case 6:
						index = -1;
						break;
					default:
						break;
				}
			} while (index != -1);

		}

	
	}
}
