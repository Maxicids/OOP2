using System;
using System.Windows;

namespace Shop_Service.Dictionaries
{
    public class SkinResourceDictionary: ResourceDictionary
    {
        private Uri lightTheme;
        private Uri darkTheme;
 
        public Uri LightThemeSourceSource
        {
            get => lightTheme;
            set {
                lightTheme = value;
                UpdateSource();
            }
        }
        public Uri DarkThemeSource
        {
            get => darkTheme;
            set {
                darkTheme = value;
                UpdateSource();
            }
        }
 
        private void UpdateSource()
        {
            var val = App.Skin == Skin.Dark ? darkTheme : lightTheme;
            if (val != null && Source != val)
            {
                Source = val;
            }
        }
    }
}