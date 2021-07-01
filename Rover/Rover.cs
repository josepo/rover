namespace Rover
{
   public class Rover
   {
      public Point Position { get; private set; }
      public Direction Direction { get; private set; }

      public Rover(Point position, Direction direction)
      {
         Position = position;
         Direction = direction;
      }

      public void GoForward()
      {
         GoForward(Direction);
      }

      public void GoBackward()
      {
         if (Direction == Direction.North)
            GoForward(Direction.South);

         if (Direction == Direction.South)
            GoForward(Direction.North);

         if (Direction == Direction.East)
            GoForward(Direction.West);

         if (Direction == Direction.West)
            GoForward(Direction.East);                                    
      }

      private void GoForward(Direction direction)
      {
         Point newPosition;

         if (direction == Direction.North)
         {
            newPosition = new Point(Position.X, Position.Y + 1);
         }
         else if (direction == Direction.South)
         {
            newPosition = new Point(Position.X, Position.Y - 1);
         }
         else if (direction == Direction.East)
         {
            newPosition = new Point(Position.X + 1, Position.Y);
         }
         else
         {
            newPosition = new Point(Position.X - 1, Position.Y);
         }

         Position = newPosition;         
      }
   }
}
