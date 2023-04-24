namespace MarsRover.App
{
    public class North : IState
    {
        private readonly RemotelyControl _remotelyControl;

        public North(RemotelyControl remotelyControl)
        {
            remotelyControl.Orientation = Orientation.North;
            _remotelyControl = remotelyControl;
        }

        public void MoveForward()
        {
            _remotelyControl.Position = new Position(_remotelyControl.Position.X, _remotelyControl.Position.Y - 1);
        }

        public void MoveBackward()
        {
            _remotelyControl.Position = new Position(_remotelyControl.Position.X, _remotelyControl.Position.Y + 1);
        }

        public IState TurnRight()
        {
            return new East(_remotelyControl);
        }

        public IState TurnLeft()
        {
            return new West(_remotelyControl);
        }
    }
}
