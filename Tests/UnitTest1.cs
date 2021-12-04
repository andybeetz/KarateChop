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
			ThenTheCorrectIndexIsReturned(5, result);
		}
		[Test]
		public void WhenChopIsCalledWith66_ReturnsMinus1()
        {
			var numbers = GivenASortedSetOfNumbers();
			var result = WhenChopIsCalledWithANumberInTheSet(66, numbers);
			ThenTheCorrectIndexIsReturned(-1, result);
		}

		private void ThenTheCorrectIndexIsReturned(int expectedResult, int result)
		{
			Assert.That(result, Is.EqualTo(expectedResult));
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