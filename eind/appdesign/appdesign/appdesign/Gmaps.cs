//GMAPS API (https://github.com/ericnewton76/gmaps-api-net) | Class by Ziggy | 0.2
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
        public String getGoogleMap(String e, Double lat, Double longitude, int imgsizex = 400, int imgsizey = 400, int mapzoom = 14)
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
            map.Markers.Add(new LatLng(lat, longitude));

            //returns the full image with the given parameters
            return map.ToUri().ToString();
        }

        //Direct link to the location, goes to google.com/maps site
        public String getGoogleMapsLink(String street, String city = "Rotterdam", String postcode = "", String country = "Nederland")
        {

            //start of the link to google maps
            String pre = "https://www.google.com/maps/place";          

            //looks for spaces to replace with + as google does
            street = street.Replace(' ', '+');
            city = city.Replace(' ', '+');
            country = country.Replace(' ', '+');

            String link = "";

            if (postcode != "" && postcode != null)
            {
                //replaces spaces with +
                postcode = postcode.Replace(' ', '+');

                //formats it all together in one string (pre/street,postcode+city,county)
                link = String.Format("{0}/{1},{2}+{3},{4}", pre, street, postcode, city, country);
            }
            else
            {
                //formats it all together in one string (pre/street,city,county)
                link = String.Format("{0}/{1},{2},{3}", pre, street, city, country);
            }

            Console.WriteLine(link);
            return link;
        }
    }
}
