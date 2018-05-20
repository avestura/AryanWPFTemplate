# Aryan MVVM WPF Template
My MVVM WPF Projects Template for Visual Studio 

## How to use?
1. Open solution in Visual Studio
2. In the menu, go to **Project > Export Template...**
3. Name your template and done!

## Description
##### Animation
These files are used for adding custom extension animations to the project. There are already
some animations defined in this file (for example: `HideUsingLinearAnimation()`)

##### App.xaml
All resources are defined here. If you added any `ResourceDictionary` file, you shoud address it here as a merged dictionary.

##### Configuration.cs
This is used for saving config of your app to a file.  
For using this feature, simply define a CLR-Property and call
`SaveSettingsToFile()`.  
For loading configurations, call `LoadSettingsFromFile()`.  
Config will be loaded to `App.CurrentApp.Configuration`.  
`Configuration` is a partial class that has three sub-files containing Fields, HardOperations and Constants separately.

##### Extensions.cs
Define your general extension methods here.

##### Assets
This is the base folder for you app's assets. It contains Colors, 
Fonts, Images, Photos and Strings by default.

##### Assets/Colors
Define any color in `SolidColors.xaml` and `GradientColors.xaml`, and their brushes in `Brushes/SolidColorBrushes.xaml` and `Brushes/GradientColorBrushes.xaml`. Then, you can use them anywhere in your project.

##### Assets/Fonts
Simply address your fonts in `Fonts.xaml` and use them anywhere in you project

##### Assets/Images
Define vector based icons here (Geometric Paths, FontAwesome, ...). You can also put png, jpeg, png, ... files here.

##### Assets/Photos
Put you large photos here.

##### Assets/Strings
You can define strings here. `ApplicationStrings.xaml` is a pre-defined file for strings that is related to the application (example: Application Name). You can create other `ResourceDictionary` files here (for example: `AlertMessages.xaml`), but don't forget to put the new file address in the `App.xaml`.

##### Assets/Behaviors
You can define Behaviors from `System.Windows.Interactivity` here.

##### Models
Define application models here.

##### ViewModels
Define application view models here. A template file with implemented `INotifyPropertyChanged` interface is already defined as an example.

##### Views
This section is for View (User Interface) of your WPF Application.
##### Views/Controls
Define your custom controls here.
##### Views/Pages
Page section for multiple pages applications.
##### Views/PartialViews
You can define Partial Views here. If you have a view that you want to use it in multiple places, simply define it here and use it anywhere you want. Menues are the best examples.

## Structure
```bash
│   App.config  
│   App.xaml  
│   App.xaml.cs    
│   MainWindow.xaml  
│   MainWindow.xaml.cs  
│  
├───Assets  
│   ├───Colors  
│   │   │   GradientColors.xaml  
│   │   │   SolidColors.xaml  
│   │   │  
│   │   └───Brushes  
│   │           GradientColorBrushes.xaml  
│   │           SolidColorBrushes.xaml  
│   │  
│   ├───Fonts  
│   │       Fonts.xaml  
│   │  
│   ├───Images  
│   │       MenuIcons.xaml  
│   │  
│   ├───Photos  
│   │       Pattern_CreamPixles.png  
│   │  
│   └───Strings  
│           ApplicationStrings.xaml  
│  
├───Models  
│       NewModel.cs  
│  
├───Engines  
│       CalculationEngine.cs  
│  
├───Extensions  
│       Extensions.cs  
│  
├───Views  
│   ├───Controls  
│   │   └───WaveCircle  
│   │           WaveCircle.xaml  
│   │           WaveCircle.xaml.cs  
│   │  
│   ├───Pages  
│   │       SamplePage.xaml  
│   │       SamplePage.xaml.cs  
│   │  
│   ├───PartialViews  
│   │   └───Menu  
│   │           MainMenu.xaml  
│   │  
│   ├───Styles  
│   │       GeneralStyles.xaml  
│   │  
│   ├───Templates  
│   │       GeneralTemplates.xaml  
│   │  
│   └───Behaviors  
│           BlinkBehavior.xaml  
│  
└───ViewModels  
        NewViewModel.cs  
```
