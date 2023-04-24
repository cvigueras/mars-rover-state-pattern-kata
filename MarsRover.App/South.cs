namespace MarsRover.App
{
    public class South : IState
    {
        private readonly RemotelyControl _remotelyControl;

        public South(RemotelyControl remotelyControl)
        {
            _remotelyControl = remotelyControl;
        }
    }
}
