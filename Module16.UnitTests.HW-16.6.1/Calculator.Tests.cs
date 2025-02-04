namespace Module16.UnitTests.HW_16._6._1
{
    public class Tests
    {
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(300 == calc.Additional(150, 150));
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(300 == calc.Subtraction(450, 150));
        }

        [Test]
        public void Multiplication_MustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(300 == calc.Multiplication(30, 10));
        }

        [Test]
        public void Division_MustThrowDivideByZeroException()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Division(300, 0));
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.That(300 == calc.Division(3000, 10));
        }
    }
}
