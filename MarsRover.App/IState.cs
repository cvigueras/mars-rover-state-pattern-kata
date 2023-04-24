namespace MarsRover.App
{
    abstract class IState
    {
        protected RemotelyControl? RemotelyControl;

        public void SetContext(RemotelyControl? remotelyControl)
        {
            RemotelyControl = remotelyControl;
        }
    }
}
