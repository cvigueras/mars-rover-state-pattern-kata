namespace MarsRover.App
{
    public class North : IState
    {
        private readonly RemotelyControl _remotelyControl;

        public North(RemotelyControl remotelyControl)
        {
            _remotelyControl = remotelyControl;
        }
    }
}
