using System;
using Chess.Models;

namespace Chess
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter Queen's x coordinate: ");
      string stringXCoordinate = Console.ReadLine();
      int xCoordinate = int.Parse(stringXCoordinate);
      Console.WriteLine("Enter Queen's y coordinate: ");
      string stringYCoordinate = Console.ReadLine();
      int yCoordinate = int.Parse(stringYCoordinate);

      Queen queen = new Queen(xCoordinate, yCoordinate);

      Console.WriteLine("Enter other piece's x coordinate: ");
      string stringPieceXCoordinate = Console.ReadLine();
      int pieceXCoordinate = int.Parse(stringPieceXCoordinate);
      Console.WriteLine("Enter other piece's y coordinate: ");
      string stringPieceYCoordinate = Console.ReadLine();
      int pieceYCoordinate = int.Parse(stringPieceYCoordinate);

      bool attackable = queen.CanAttack(pieceXCoordinate, pieceYCoordinate);

      if (attackable)
      {
        Console.WriteLine("Queen can attack (" + pieceXCoordinate + ", " + pieceYCoordinate + ")");
      }
      else
      {
        Console.WriteLine("Queen cannot attack (" + pieceXCoordinate + ", " + pieceYCoordinate + ")");
      }
    }
  }
}
