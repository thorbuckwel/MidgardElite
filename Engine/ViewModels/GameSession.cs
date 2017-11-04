using Engine.Model;
using Engine.Factory;
 

namespace Engine.ViewModels
{
    public class GameSession
    {
        private static Location _currentLocation;
        //private Monster _currentMonster;
        public static Player currentPlayer;

        public GameWorld CurrentWorld { get; set; }
        public static Player CurrentPlayer { get; set; } 
        public static Location CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;

                //OnPropertyChanged(nameof(CurrentLocation));
                //OnPropertyChanged(nameof(HasLocationToNorth));
                //OnPropertyChanged(nameof(HasLocationToEast));
                //OnPropertyChanged(nameof(HasLocationToWest));
                //OnPropertyChanged(nameof(HasLocationToSouth));

                //GivePlayerQuestsAtLocation();
                //GetMonsterAtLocation();
            }
        }

        public GameSession()
        {
            GameWorldFactory factory = new GameWorldFactory();
            CurrentWorld = factory.CreateWorld();
            CurrentLocation = CurrentWorld.LocationAt(CurrentPlayer.Zone, CurrentPlayer.XCoord, CurrentPlayer.YCoord);
        }

        // Is there a room in the next direction?
        #region Has Location?
        public bool HasLocationToNorth
        {
            get
            {     
                foreach (string e in GameSession.CurrentLocation.Exits)
                {
                    if (e == "N")
                        return CurrentWorld.LocationAt(CurrentLocation.Zone, CurrentLocation.XCoord, CurrentLocation.YCoord + 1) != null;
                }
                return false;
            }
        }

        public bool HasLocationToEast
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.Zone, CurrentLocation.XCoord + 1, CurrentLocation.YCoord) != null;
            }
        }

        public bool HasLocationToSouth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.Zone, CurrentLocation.XCoord, CurrentLocation.YCoord - 1) != null;
            }
        }

        public bool HasLocationToWest
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.Zone, CurrentLocation.XCoord - 1, CurrentLocation.YCoord) != null;
            }
        }
        #endregion

        // Move to next room.
        #region Move
        public void MoveNorth()
        {
            if (HasLocationToNorth)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.Zone, CurrentLocation.XCoord, CurrentLocation.YCoord + 1);
            }           
        }

        public void MoveEast()
        {
            if (HasLocationToEast)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.Zone, CurrentLocation.XCoord + 1, CurrentLocation.YCoord);
            }
        }

        public void MoveSouth()
        {
            if (HasLocationToSouth)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.Zone, CurrentLocation.XCoord, CurrentLocation.YCoord - 1);
            }
        }

        public void MoveWest()
        {
            if (HasLocationToWest)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.Zone, CurrentLocation.XCoord - 1, CurrentLocation.YCoord);
            }
        }
        #endregion
    }
}
