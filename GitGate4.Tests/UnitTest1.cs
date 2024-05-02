using GitGate4.Player;

namespace GitGate4.Tests
{
    public class Tests
    {
        [Test]
        public void WhenElfIsHealed_ThenHealthGoesUpBy4()
        {
            //Arrange
            int currentHealth = 10;
            int healValue = 4;
            int expectedResult = 14;
            Elf elf = new Elf();
            elf.Hitpoints = currentHealth;

            //Act
            elf.HealSelf(healValue);

            //Assert
            Assert.AreEqual(expectedResult, elf.Hitpoints);
        }
    }
}