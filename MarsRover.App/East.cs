namespace MarsRover.App
{
    public class East : IState
    {
        private readonly RemotelyControl _remotelyControl;

        public East(RemotelyControl remotelyControl)
        {
            _remotelyControl = remotelyControl;
        }
    }
}
