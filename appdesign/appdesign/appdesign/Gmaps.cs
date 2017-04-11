//GMAPS API (https://github.com/ericnewton76/gmaps-api-net) | Class by Ziggy
using System;
using Google.Maps;
using Google.Maps.StaticMaps;

namespace appdesign
{
    class Gmaps
    {
        public Gmaps()
        {
            //api connection Static Maps
            GoogleSigned.AssignAllServices(new GoogleSigned("AIzaSyAxfxfxvPKREy_eYuIOGaGaNYEXY8NdRzY"));
        }

        //Recieve an image with marker (lat and long required
        public String getGoogleMap(String e, Double lat, Double lng, int imgsizex = 400, int imgsizey = 400, int mapzoom = 14)
        {
            var map = new StaticMapRequest();

            //Location (example "Blaak, Rotterdam")
            map.Center = new Location(e);

            //Image size
            map.Size = new System.Drawing.Size(imgsizex, imgsizey);

            //Zoom in depth
            map.Zoom = mapzoom;

            map.Sensor = false;

            //Add the marker
            map.Markers.Add(new LatLng(lat, lng));

            //string actual = map.ToUri().Query;
            //Console.WriteLine(actual);
            //StringAssert.Contains("markers=52.0077271,-4.3496006&", actual);

            //returns the full image with the given parameters
            return map.ToUri().ToString();
        }
    }
}
