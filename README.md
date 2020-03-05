# Logikoz.XamarinUtilities
Utilities for xamarin.forms, Themes, ThemeService, Refections...

### Add namespace reference on app.xaml
```xml
xmlns:theme="clr-namespace:Logikoz.XamarinUtilities.Themes;assembly=Logikoz.XamarinUtilities"
xmlns:color="clr-namespace:Logikoz.XamarinUtilities.Themes.Colors;assembly=Logikoz.XamarinUtilities"
```

### Add a default theme on app.xaml
```xml
<ResourceDictionary>
  <ResourceDictionary.MergedDictionaries>
    <theme:LightDefaultTheme />
    <color:Color.Primary.Purple />
    <color:Color.Secondary.Red />
  </ResourceDictionary.MergedDictionaries>
</ResourceDictionary>
```
