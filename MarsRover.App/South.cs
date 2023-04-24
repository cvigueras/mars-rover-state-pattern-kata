namespace MarsRover.App
{
    public class South : IState
    {
        private readonly RemotelyControl _remotelyControl;

        public South(RemotelyControl remotelyControl)
        {
            remotelyControl.Orientation = Orientation.South;
            _remotelyControl = remotelyControl;
        }

        public void MoveForward()
        {
            _remotelyControl.Position = new Position(_remotelyControl.Position.X, _remotelyControl.Position.Y + 1);
        }

        public void MoveBackward()
        {
            _remotelyControl.Position = new Position(_remotelyControl.Position.X, _remotelyControl.Position.Y - 1);
        }

        public IState TurnRight()
        {
            return new West(_remotelyControl);
        }

        public IState TurnLeft()
        {
            return new East(_remotelyControl);
        }
    }
}