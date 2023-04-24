namespace MarsRover.App;

public class RemotelyControl
{
    public Orientation Orientation;
    public Position Position;
    private IState _state;

    public RemotelyControl(Orientation orientation, Position position)
    {
        Position = position;
        Orientation = orientation;
        switch (Orientation)
        {
            case Orientation.North:
                _state = new North(this);
                break;
            case Orientation.East:
                _state = new East(this);
                break;
            case Orientation.South:
                _state = new South(this);
                break;
            case Orientation.West:
                _state = new West(this);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(Orientation));
        }
    }

    public void TurnRight()
    {
        _state = _state.TurnRight();
    }

    public void TurnLeft()
    {
        _state = _state.TurnLeft();
    }

    public void MoveBackward()
    {
        _state.MoveBackward();
    }

    public void MoveForward()
    {
        _state.MoveForward();
    }
}