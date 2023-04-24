namespace MarsRover.App
{
    public interface IState
    {
        void MoveForward();
        void MoveBackward();
        IState TurnRight();
        IState TurnLeft();
    }
}
