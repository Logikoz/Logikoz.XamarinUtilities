# Logikoz.XamarinUtilities
Utilities for xamarin.forms, Themes, ThemeService, Refections...

### Add namespace reference on app.xaml
```xml
xmlns:theme="clr-namespace:Logikoz.XamarinUtilities.Themes;assembly=Logikoz.XamarinUtilities"
xmlns:SecondaryColor="clr-namespace:Logikoz.XamarinUtilities.Themes.Colors.Secondary;assembly=Logikoz.XamarinUtilities"
xmlns:primaryColor="clr-namespace:Logikoz.XamarinUtilities.Themes.Colors.Primary;assembly=Logikoz.XamarinUtilities"
```

### Add a default theme on app.xaml
```xml
<ResourceDictionary>
  <ResourceDictionary.MergedDictionaries>
    <theme:LightDefaultTheme />
    <primaryColor:Purple />
    <SecondaryColor:Red />
  </ResourceDictionary.MergedDictionaries>
</ResourceDictionary>
```
