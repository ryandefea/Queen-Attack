using System;

namespace Chess.Models
{
  public class Queen
  {
    private int _xCoordinate;
    private int _yCoordinate;

    public Queen(int xCoordinate, int yCoordinate)
    {
      _xCoordinate = xCoordinate;
      _yCoordinate = yCoordinate;
    }

    public bool CanAttack(int xCoordinate, int yCoordinate)
    {
      if (_xCoordinate == xCoordinate)
      {
        return true;
      } 
      else 
      {
        int slope = Math.Abs((_yCoordinate - yCoordinate) / (_xCoordinate - xCoordinate));

        if (_yCoordinate == yCoordinate)
        {
          return true;
        }
        else if (slope == 1)
        {
          return true;
        }
        else
        {
          return false;
        }
      }
    }
  }
}