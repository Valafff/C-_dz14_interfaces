using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.C__dz14_interfaces
{
	internal abstract class Goods : IComparable
	{

		public static uint ID;
		public uint id { get; set; }
		public string Name { get; set; }
		public DateTime ManufactureDate { get; set; }
		public DateTime ExperationDate { get; set; }

		double price;
		public double Price
		{
			get { return price; }
			set
			{
				if (value < 0)
				{
					value = 0;
				}
				price = value;
			}
		}

		public int TotalCount { get; set; }


        //public Goods(string arg_name, double arg_price, int count = 1)
        //{
        //	id = ID;
        //	ID++;
        //	Name = arg_name;
        //	Price = arg_price;
        //	//Is_sold = arg_status;
        //	if (count > 0)
        //	{
        //		TotalCount = count;
        //	}
        //	else
        //		TotalCount = 1;
        //}

        public abstract void AddManData(DateTime arg_date);
		public abstract void AddExperationDate(DateTime arg_);
		public abstract void ReName(string arg_name);
		public abstract void RePrice(double arg_price);
		public abstract void AddGoods(int arg_status);
		public abstract void Print();
		public abstract void SellGoods(int arg_count);


		public int CompareTo(object obj)
		{
			if ((obj is Goods))
			{
				return ExperationDate.CompareTo(((Goods)obj).ExperationDate);
			}
			throw new NotImplementedException();
		}
	}


}
