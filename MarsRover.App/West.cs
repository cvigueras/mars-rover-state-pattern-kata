namespace MarsRover.App
{
    public class West : IState
    {
        private readonly RemotelyControl _remotelyControl;

        public West(RemotelyControl remotelyControl)
        {
            remotelyControl.Orientation = Orientation.West;
            _remotelyControl = remotelyControl;
        }

        public void MoveForward()
        {
            _remotelyControl.Position = new Position(_remotelyControl.Position.X - 1, _remotelyControl.Position.Y);
        }

        public void MoveBackward()
        {
            throw new NotImplementedException();
        }

        public IState TurnRight()
        {
            return new North(_remotelyControl);
        }

        public IState TurnLeft()
        {
            return new South(_remotelyControl);
        }
    }
}
