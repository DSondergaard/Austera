using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TileGame
{
    public class MapController
    {
        private static MapController _instance;
        public static MapController Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MapController();
                return _instance;
            }
        }


        public Map CurrentMap { get; set; }


        private MapController()
        {

        }

    }
}
