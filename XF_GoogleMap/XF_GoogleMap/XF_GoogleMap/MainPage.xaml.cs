using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace XF_GoogleMap
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AddMarkers();
        }

        private void AddMarkers()
        {
            Position loc1 = new Position(17.430486, 78.341331);
            Position loc2 = new Position(17.427579, 78.342017);
            
            Pin marker1 = new Pin()
            {
                Address = "Gachibowli",
                IsVisible = true,
                Label = "Microsoft Hyderabad",
                Icon = BitmapDescriptorFactory.FromBundle("type1"),
                Position = loc1,
                Type = PinType.Place

            };
            Pin marker2 = new Pin()
            {
                Address = "Gachibowli",
                IsVisible = true,
                Label = "Wipro Hyderabad",
                Icon = BitmapDescriptorFactory.FromBundle("type2"),
                Position = loc2,
                Type = PinType.Place

            };

            mapView.Pins.Add(marker1);
            mapView.Pins.Add(marker2);

            Position southwestBound = new Position(17.418652, 78.327941);
            Position northeastBound = new Position(17.439288, 78.354593);
            var bounds = new Bounds(southwestBound, northeastBound);
            mapView.MoveToRegion(MapSpan.FromBounds(bounds));
        }
    }
}
