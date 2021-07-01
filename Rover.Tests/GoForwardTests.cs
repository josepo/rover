using Xunit;

namespace Rover.Tests
{
   public class GoForwardTests
   {
      [Fact]
      public void GoNorth()
      {
         Point position = new Point(3, 5);
         Rover rover = new Rover(position, Direction.North);

         rover.GoForward();

         Assert.Equal(3, rover.Position.X);
         Assert.Equal(6, rover.Position.Y);
      }

      [Fact]
      public void GoSouth()
      {
         Point position = new Point(3, 5);
         Rover rover = new Rover(position, Direction.South);

         rover.GoForward();

         Assert.Equal(3, rover.Position.X);
         Assert.Equal(4, rover.Position.Y);         
      }

      [Fact]
      public void GoEast()
      {
         Point position = new Point(3, 5);
         Rover rover = new Rover(position, Direction.East);

         rover.GoForward();

         Assert.Equal(4, rover.Position.X);
         Assert.Equal(5, rover.Position.Y);
      }

      [Fact]
      public void GoWest()
      {
         Point position = new Point(3, 5);
         Rover rover = new Rover(position, Direction.West);

         rover.GoForward();

         Assert.Equal(2, rover.Position.X);
         Assert.Equal(5, rover.Position.Y);         
      }      
   }
}
