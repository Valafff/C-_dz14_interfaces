using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.C__dz14_interfaces
{
	internal class CaloriSort : IComparer
	{
		public int Compare(object x, object y)
		{
			if (x is Bread   && (y is Bread || x is Meat || x is Milk))
			{
				int caloriSort = ((Bread)x).Calorie.CompareTo(((Bread)x).Calorie);
				return caloriSort;
			}
			throw new NotImplementedException();
		}

	}
}
