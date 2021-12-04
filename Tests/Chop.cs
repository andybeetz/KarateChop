using System;
using System.Linq;

namespace Tests
{
	public class ChopClass
	{
		public static int Chop(int number, int[] numbers)
		{
			var match = numbers.Select((value, index) => new { value, index }).Where(t => t.value == number).FirstOrDefault();

			if (match == null)
				return -1;

			return match.index;
		}
	}
}