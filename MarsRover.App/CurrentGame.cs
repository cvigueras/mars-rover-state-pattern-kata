namespace MarsRover.App
{
    public class CurrentGame
    {
        public Planet Planet;
        private readonly RemotelyControl _remotelyControl;
        private readonly Dictionary<string, Command> _commandsDict;

        public CurrentGame()
        {
            Planet = new Planet();
            _remotelyControl = new RemotelyControl(Orientation.North, new Position(1, 1));
            Planet.SetInitialValue();
            _commandsDict = new Dictionary<string, Command>
            {
                {"F",Command.F},
                {"B",Command.B},
                {"L",Command.L},
                {"R",Command.R},
            };
        }

        public void ResetPlanet()
        {
            Planet = new Planet();
        }

        public void ExecuteCommand(string[] commands)
        {
            foreach (var command in commands)
            {
                var com = _commandsDict.FirstOrDefault(c => c.Key.Equals(command)).Value;
                switch (com)
                {
                    case Command.F:
                        _remotelyControl.MoveForward();
                        break;
                    case Command.B:
                        _remotelyControl.MoveBackward();
                        break;
                    case Command.R:
                        _remotelyControl.TurnRight();
                        break;
                    case Command.L:
                        _remotelyControl.TurnLeft();
                        break;
                }
            }

            ResetPlanet();
            Planet.CheckPosition(_remotelyControl.Position);
            SetPositionInPlanet();
        }

        private void SetPositionInPlanet()
        {
            Planet.Value[_remotelyControl.Position.X, _remotelyControl.Position.Y] =
                Planet.GetCurrentUnicodeOrientation(_remotelyControl.Orientation);
        }
    }
}