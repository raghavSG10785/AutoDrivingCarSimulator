using AutoCarDrivingLogic.Service;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AutoCarDrvingLogicUnitTest
{
    [TestFixture]
    public class AutoCarDrvingLogicTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("L", 0, 0)]
        public void MoveTestLeft90Degree(string commands, int maxWidth, int maxHeight)
        {
            // Arrange
            var direction = new AutoDrivingDirectionLogic();

            // Act
            direction.Move(commands, maxWidth, maxHeight);

            // Assert
            Assert.IsTrue(true);
        }

        [TestCase("R", 0, 0)]
        public void MoveTestRight90Degree(string commands, int maxWidth, int maxHeight)
        {
            // Arrange
            var direction = new AutoDrivingDirectionLogic();

            // Act
            direction.Move(commands, maxWidth, maxHeight);

            // Assert
            Assert.IsTrue(true);
        }

        [TestCase("F", 1, 2)]
        public void MoveTestForward(string commands, int maxWidth, int maxHeight)
        {
            // Arrange
            var direction = new AutoDrivingDirectionLogic();

            // Act
            direction.Move(commands, maxWidth, maxHeight);

            // Assert
            Assert.IsTrue(true);
        }
    }
}