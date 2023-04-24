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
            throw new NotImplementedException();
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
