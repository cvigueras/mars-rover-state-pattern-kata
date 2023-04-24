namespace MarsRover.App
{
    public class West : IState
    {
        private readonly RemotelyControl _remotelyControl;

        public West(RemotelyControl remotelyControl)
        {
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
            throw new NotImplementedException();
        }

        public IState TurnLeft()
        {
            throw new NotImplementedException();
        }
    }
}
