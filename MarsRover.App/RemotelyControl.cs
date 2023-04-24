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
        _state = Orientation switch
        {
            Orientation.North => new North(this),
            Orientation.East => new East(this),
            Orientation.South => new South(this),
            Orientation.West => new West(this)
        };
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