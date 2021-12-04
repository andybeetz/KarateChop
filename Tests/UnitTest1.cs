using NUnit.Framework;

using System.Linq;

namespace Tests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void WhenChopIsCalledWith54_ReturnsCorrectIndex()
		{
			var numbers = GivenASortedSetOfNumbers();
			var result = WhenChopIsCalledWithANumberInTheSet(54, numbers);
			ThenTheCorrectIndexIsReturned(result);
		}

		private void ThenTheCorrectIndexIsReturned(int result)
		{
			Assert.That(result, Is.EqualTo(5));
		}

		private int WhenChopIsCalledWithANumberInTheSet(int number, int[] numbers)
		{
			return ChopClass.Chop(number, numbers);
		}

		private int[] GivenASortedSetOfNumbers()
		{
			var numbers = new[] { -3, 0, 1, 4, 27, 54, 76 };

			return numbers.OrderBy(n => n).ToArray();
		}
	}
}