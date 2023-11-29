using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.C__dz14_interfaces
{
	internal class Insecticides : Goods, IDomestics, IGardenChem
	{


		public string DomesticsChemType { get; set; }
		public string GardenType { get; set; }

		public Insecticides(string arg_name, double arg_price, int arg_count, string arg_type, string arg_Domestic_type, DateTime manufactureDate, DateTime arg_GarrantyEndDate)
		{
			id = ID;
			ID++;
			Name = arg_name;
			Price = arg_price;
			TotalCount = arg_count;

			GardenType = arg_type;
			DomesticsChemType = arg_Domestic_type;
			ManufactureDate = manufactureDate;
			ExperationDate = arg_GarrantyEndDate;
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

		public override void SellGoods(int arg_count = 1)
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
			Console.WriteLine($"Артикул: {id} Название товара: {Name} Назначение товара: {GardenType} Тип товара {DomesticsChemType} Цена товара: {Price} руб. Кол-во на складе: {TotalCount} шт. \nДата изг.: {ManufactureDate.ToShortDateString()}  Срок годности до: {ExperationDate.ToShortDateString()}");
		}

	}
}
