namespace MarsRover.App
{
    public class East : IState
    {
        private readonly RemotelyControl _remotelyControl;

        public East(RemotelyControl remotelyControl)
        {
            remotelyControl.Orientation = Orientation.East;
            _remotelyControl = remotelyControl;
        }

        public void MoveForward()
        {
            _remotelyControl.Position = new Position(_remotelyControl.Position.X + 1, _remotelyControl.Position.Y);
        }

        public void MoveBackward()
        {
            throw new NotImplementedException();
        }

        public IState TurnRight()
        {
            return new South(_remotelyControl);
        }

        public IState TurnLeft()
        {
            return new North(_remotelyControl);
        }
    }
}
