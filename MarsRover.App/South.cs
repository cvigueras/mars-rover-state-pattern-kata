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
            throw new NotImplementedException();
        }

        public void MoveBackward()
        {
            throw new NotImplementedException();
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
