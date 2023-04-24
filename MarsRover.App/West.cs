namespace MarsRover.App
{
    public class West : IState
    {
        private readonly RemotelyControl _remotelyControl;

        public West(RemotelyControl remotelyControl)
        {
            _remotelyControl = remotelyControl;
        }
    }
}
