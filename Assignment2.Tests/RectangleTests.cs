namespace Assignment2.Tests
{
    public class RectangleTests
    {
        private Rectangle Rectangle { get; set; }

        [SetUp]
        public void Setup()
        {
            Rectangle = new Rectangle();
        }

        //test GetLength Method
        [Test]
        public void GetLength_WhenLT0_ShouldReturn0()
        {
            //assign
            int newLength = -10;

            //Act
            Rectangle.SetLength(newLength);
            var length = Rectangle.GetLength();

            //Assert
            Assert.AreEqual(-1, length);
        }

        [Test]
        public void GetLength_WhenGT1100_ShouldReturn0()
        {
            //assign
            int newLength = 1200;

            //Act
            Rectangle.SetLength(newLength);
            var length = Rectangle.GetLength();

            //Assert
            Assert.AreEqual(-1, length);
        }

        [Test]
        public void GetLength_WhenInputBetween0and1100_ShouldReturnInput()
        {
            //assign
            int newLength = 800;

            //Act
            Rectangle.SetLength(newLength);
            var length = Rectangle.GetLength();

            //Assert
            Assert.AreEqual(800, length);
        }

        //test SetLength Method
        [Test]
        public void SetLength_WhenLT0_ShouldReturn0()
        {
            //assign
            int newLength = -200;

            //Act            
            var length = Rectangle.SetLength(newLength);

            //Assert
            Assert.AreEqual(-1, length);
        }

        [Test]
        public void SetLength_WhenGT0_ShouldReturn0()
        {
            //assign
            int newLength = 2450;

            //Act            
            var length = Rectangle.SetLength(newLength);

            //Assert
            Assert.AreEqual(-1, length);
        }

        [Test]
        public void SetLength_WhenInputBetween0and1100_ShouldReturnInput()
        {
            //assign
            int newLength = 450;

            //Act
            var length = Rectangle.SetLength(newLength);

            //Assert
            Assert.AreEqual(450, length);
        }

        //test GetWidth Method
        [Test]
        public void GetWidth_WhenLT0_ShouldReturn0()
        {
            //assign
            int newWidth = -10;

            //Act
            Rectangle.SetWidth(newWidth);
            var width = Rectangle.GetWidth();

            //Assert
            Assert.AreEqual(-1, width);
        }

        [Test]
        public void GetWidth_WhenGT0_ShouldReturn0()
        {
            //assign
            int newWidth = 1330;

            //Act
            Rectangle.SetWidth(newWidth);
            var width = Rectangle.GetWidth();

            //Assert
            Assert.AreEqual(-1, width);
        }

        [Test]
        public void GetWidth_WhenInputBetween0and1100_ShouldReturnInput()
        {
            //assign
            int newWidth = 180;

            //Act
            Rectangle.SetWidth(newWidth);
            var width = Rectangle.GetWidth();

            //Assert
            Assert.AreEqual(180, width);
        }

        //test SetWidth Method
        [Test]
        public void SetWidth_WhenLT0_ShouldReturn0()
        {
            //assign
            int newWidth = -500;

            //Act           
            var width = Rectangle.SetWidth(newWidth);

            //Assert
            Assert.AreEqual(-1, width);
        }

        [Test]
        public void SetWidth_WhenGT0_ShouldReturn0()
        {
            //assign
            int newWidth = 2500;

            //Act           
            var width = Rectangle.SetWidth(newWidth);

            //Assert
            Assert.AreEqual(-1, width);
        }

        [Test]
        public void SetWidth_WhenInputBetween0and1100_ShouldReturnInput()
        {
            //assign
            int newWidth = 500;

            //Act           
            var width = Rectangle.SetWidth(newWidth);

            //Assert
            Assert.AreEqual(500, width);
        }

        //test GetPerimeter Method
        [Test]
        public void GetPerimeter_WhenOneInputLT0_ShouldReturnN1()
        {
            //assign
            int newWidth = -500;
            int newLength = 100;

            //Act
            Rectangle.SetLength(newLength);
            Rectangle.SetWidth(newWidth);
            var perimeter = Rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(-1, perimeter);
        }

        [Test]
        public void GetPerimeter_WhenOneInputGT1100_ShouldReturnN1()
        {
            //assign
            int newWidth = 500;
            int newLength = 1800;

            //Act
            Rectangle.SetLength(newLength);
            Rectangle.SetWidth(newWidth);
            var perimeter = Rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(-1, perimeter);
        }

        [Test]
        public void GetPerimeter_WhenCorrectlyInput_ShouldReturn()
        {
            //assign
            int newWidth = 500;
            int newLength = 100;

            //Act
            Rectangle.SetLength(newLength);
            Rectangle.SetWidth(newWidth);
            var perimeter = Rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(1200, perimeter);
        }

        //test GetArea Method
        [Test]
        public void GetArea_WhenOneInputLT0_ShouldReturnN1()
        {
            //assign
            int newWidth = -500;
            int newLength = 100;

            //Act
            Rectangle.SetLength(newLength);
            Rectangle.SetWidth(newWidth);
            var area = Rectangle.GetArea();

            //Assert
            Assert.AreEqual(-1, area);
        }

        [Test]
        public void GetArea_WhenOneInputGT1100_ShouldReturnN1()
        {
            //assign
            int newWidth = 500;
            int newLength = 2100;

            //Act
            Rectangle.SetLength(newLength);
            Rectangle.SetWidth(newWidth);
            var area = Rectangle.GetArea();

            //Assert
            Assert.AreEqual(-1, area);
        }

        [Test]
        public void GetArea_WhenCorrectlyInput_ShouldReturn1()
        {
            //assign
            int newWidth = 500;
            int newLength = 200;

            //Act
            Rectangle.SetLength(newLength);
            Rectangle.SetWidth(newWidth);
            var area = Rectangle.GetArea();

            //Assert
            Assert.AreEqual(100000, area);
        }
    }
}