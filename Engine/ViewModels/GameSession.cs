using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Model;
using Engine.WorldSave;

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

        //public static bool HasLocationToNorth
        //{
        //    get
        //    {
        //        return CurrentWorld.LocationAt(CurrentLocation.Zone, CurrentLocation.XCoord, CurrentLocation.YCoord + 1) != null;
        //    }
        //}

        //public bool HasLocationToEast
        //{
        //    get
        //    {
        //        return CurrentWorld.LocationAt(CurrentLocation.Zone, CurrentLocation.XCoord + 1, CurrentLocation.YCoord) != null;
        //    }
        //}

        //public bool HasLocationToSouth
        //{
        //    get
        //    {
        //        return CurrentWorld.LocationAt(CurrentLocation.Zone, CurrentLocation.XCoord, CurrentLocation.YCoord - 1) != null;
        //    }
        //}

        //public bool HasLocationToWest
        //{
        //    get
        //    {
        //        return CurrentWorld.LocationAt(CurrentLocation.Zone, CurrentLocation.XCoord - 1, CurrentLocation.YCoord) != null;
        //    }
        //}
    }
}
