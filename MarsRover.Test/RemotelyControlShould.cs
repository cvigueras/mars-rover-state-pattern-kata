using FluentAssertions;
using MarsRover.App;

namespace MarsRover.Test
{
    public class RemotelyControlShould
    {
        private RemotelyControl _remotelyControl;

        [SetUp]
        public void Setup()
        {
            _remotelyControl = new RemotelyControl(Orientation.North, new Position(1,1));
        }

        [Test]
        public void PlaceRoverInInitialPosition()
        {
            var result = _remotelyControl.Position;
            
            result.Should().BeEquivalentTo(new Position(1,1));
        }

        [Test]
        public void MoveOneStepRoverForwardWhenStayInInitialPosition()
        {
            _remotelyControl.MoveForward();

            _remotelyControl.Position.Should().BeEquivalentTo(new Position(1,0));
        }

        [Test]
        public void MoveOneStepRoverBackwardWhenStayInInitialPosition()
        {
            _remotelyControl.MoveBackward();

            _remotelyControl.Position.Should().BeEquivalentTo(new Position(1, 2));
        }

        [Test]
        public void MoveTwoStepsRoverBackwardWhenStayInInitialPosition()
        {
            _remotelyControl.MoveBackward();
            _remotelyControl.MoveBackward();

            _remotelyControl.Position.Should().BeEquivalentTo(new Position(1, 3));
        }

        [Test]
        public void MoveThreeStepsRoverBackwardWhenStayInInitialPosition()
        {
            _remotelyControl.MoveBackward();
            _remotelyControl.MoveBackward();
            _remotelyControl.MoveBackward();

            _remotelyControl.Position.Should().BeEquivalentTo(new Position(1, 4));
        }

        [Test]
        public void RotateLeftRoverWhenStayInInitialOrientation()
        {
            _remotelyControl.TurnLeft();

            _remotelyControl.Orientation.Should().Be(Orientation.West);
        }

        [Test]
        public void RotateRightRoverWhenStayInInitialOrientation()
        {
            _remotelyControl.TurnRight();

            _remotelyControl.Orientation.Should().Be(Orientation.East);
        }

        [Test]
        public void RotateRightRoverWhenStayInCurrentOrientation()
        {
            _remotelyControl.TurnRight();
            _remotelyControl.TurnLeft();

            _remotelyControl.Orientation.Should().Be(Orientation.North);
        }

        [Test]
        public void RotateLeftRoverWhenStayInNorth()
        {
            _remotelyControl.TurnLeft();

            _remotelyControl.Orientation.Should().Be(Orientation.West);
        }

        [Test]
        public void RotateRightRoverWhenStayInWest()
        {
            _remotelyControl = new RemotelyControl(Orientation.West, new Position(1, 1));
            _remotelyControl.TurnRight();

            _remotelyControl.Orientation.Should().Be(Orientation.North);
        }

        [Test]
        public void RotateLeftRoverWhenStayInSouth()
        {
            _remotelyControl = new RemotelyControl(Orientation.South, new Position(1, 1));
            _remotelyControl.TurnLeft();

            _remotelyControl.Orientation.Should().Be(Orientation.East);
        }

        [Test]
        public void MoveTwoStepsRoverForwardWhenLookToSouthAndInitialPosition()
        {
            _remotelyControl = new RemotelyControl(Orientation.South, new Position(1, 1));
            _remotelyControl.MoveForward();
            _remotelyControl.MoveForward();

            _remotelyControl.Position.Should().BeEquivalentTo(new Position(1, 3));
        }
    }
}