namespace MarsRover.App;

public class RemotelyControl
{
    private Orientation _orientation;
    public Position Position;

    public RemotelyControl(Orientation orientation, Position position)
    {
        Position = position;
        _orientation = orientation;
    }

    public Position Move(Command[] givenCommand)
    {
        foreach (var command in givenCommand)
        {
            if (command == Command.F)
                MoveForward();
            if (command == Command.B)
                MoveBackward();
        }
        return Position;
    }

    private void MoveBackward()
    {
        Position = new Position(Position.X, Position.Y + 1);
    }

    private void MoveForward()
    {
        Position = new Position(Position.X, Position.Y - 1);
    }

    public Orientation Turn(Command[] givenCommand)
    {
        switch (givenCommand[0])
        {
            case Command.R:
                return TurnRight();
            default:
                return TurnLeft();
        }
    }

    private Orientation TurnLeft()
    {
        _orientation -= 1;
        if (_orientation <= Orientation.None)
        {
            _orientation = Orientation.West;
        }
        return _orientation;
    }

    private Orientation TurnRight()
    {
        _orientation += 1;
        if (_orientation > Orientation.West)
        {
            _orientation = Orientation.North;
        }
        return _orientation;
    }
}