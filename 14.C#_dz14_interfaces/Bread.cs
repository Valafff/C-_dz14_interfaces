using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.C__dz14_interfaces
{
	internal class Bread : Goods, IFood, IBredDepartment
	{
		public int Calorie { get; set; }
		public string Breadtype { get; set; }

		public Bread(string arg_name, double arg_price, int arg_count, int arg_calorie, string arg_breadType, DateTime manufactureDate, DateTime experationDate)
		{
			id = ID;
			ID++;
			Name = arg_name;
			Price = arg_price;
			TotalCount = arg_count;
			Calorie = arg_calorie;
			Breadtype = arg_breadType;
			ManufactureDate = manufactureDate;
			ExperationDate = experationDate;
		}
		public override void AddManData(DateTime arg_date)
		{
			ManufactureDate = arg_date;
		}

		public override void AddExperationDate(DateTime arg_date)
		{
			ExperationDate = arg_date;
		}

		public override void AddGoods(int arg_count)
		{
			TotalCount += arg_count;
		}

		public override void ReName(string arg_name)
		{
			Name = arg_name;
		}

		public override void RePrice(double arg_price)
		{
			Price = arg_price;
		}

		public override void SellGoods(int arg_count=1)
		{
			if (arg_count <= TotalCount)
			{
				TotalCount -= arg_count;
			}
			else
			{
				Console.WriteLine("Количество товара на складе меньше продаваемого количества");
			}
		}
		public override void Print()
		{
			Console.WriteLine($"Артикул: {id} Название товара: {Name} Название хлеба: {Breadtype} Цена товара: {Price} руб. Кол-во на складе: {TotalCount} шт.\nПищевая ценность: {Calorie} ккал. Дата изготовления: {ManufactureDate.ToShortDateString()} Срок годности до: {ExperationDate.ToShortDateString()}");
		}


	}
}
