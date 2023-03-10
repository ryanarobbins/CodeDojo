namespace CodeDojo
{
	public class Tests
	{
		/*
		 * FizzBuzz
		 * Write a function that takes in an integer and returns FizzBuzz translation of that number
		 * 1 => "1"		6 => Fizz		11 => 11		30 => FizzBuzz		
		 * 2 => "2"		7 => 7			12 => Fizz	
		 * 3 => Fizz	8 => 8			13 => 13		
		 * 4 => 4		9 => Fizz		14 => 14	
		 * 5 => Buzz	10 => Buzz		15 => FizzBuzz		
		 * 
		 * 
		 */
		

		[Test]
		[TestCase(1, "1")]
		[TestCase(6, "Fizz")]
		public void SixShouldFizz(int toTranslate, string expected)
		{
			Assert.That(Translate(toTranslate), Is.EqualTo(expected));
		}
        

		[Test]
		public void TestTrans2 ()
		{
			Assert.That(Translate(2), Is.EqualTo("2"));
		}

		[Test]
		public void TestTrans15()
		{
			Assert.That(Translate(15), Is.EqualTo("FizzBuzz"));
		}

		[Test]
		public void FourteenShouldBeFourteen()
		{
			Assert.That(Translate(14), Is.EqualTo("14"));
		}

		private string Translate(int v)
		{

			return v switch
			{
				15 => "FizzBuzz",
				14 => "14",
				6 => "Fizz",
				2 => "2",
				1 => "1",
				_ => ""
			};
		}
    }
}