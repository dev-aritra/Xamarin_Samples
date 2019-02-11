

namespace XF_GoogleMap.Droid
{
    using Xamarin.Forms.GoogleMaps;
    using Xamarin.Forms.GoogleMaps.Android.Factories;
    using AndroidBitmapDescriptor = Android.Gms.Maps.Model.BitmapDescriptor;
    using AndroidBitmapDescriptorFactory = Android.Gms.Maps.Model.BitmapDescriptorFactory;

    public sealed class AccessNativeBitmapConfig : IBitmapDescriptorFactory
    {
        public AndroidBitmapDescriptor ToNative(BitmapDescriptor descriptor)
        {
            int resId = 0;
            switch (descriptor.Id)
            {
                case "type2":
                    resId = Resource.Drawable.type2;
                    break;
                case "type1":
                    resId = Resource.Drawable.type1;
                    break;
            }

            return AndroidBitmapDescriptorFactory.FromResource(resId);
        }
    }
}