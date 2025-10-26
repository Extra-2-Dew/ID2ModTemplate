# Ittle Dew 2 Mod Template

This is a template for building Ittle Dew 2 mods. It has all the necessary files for the mod to run, so requires minimal effort to get a new mod up and running!

## How does this Work?
What you download from [Releases](https://github.com/Extra-2-Dew/ID2ModTemplate/releases) page is the project template folder for Visual Studio. With it installed, you can easily create a new mod from the template from within Visual Studio.

## Installing Template
1. Download the latest `ID2ModTemplate.zip` file from [Releases](https://github.com/Extra-2-Dew/ID2ModTemplate/releases/latest) page.
2. Place the downloaded `ID2ModTemplate.zip` into your Visual Studio project templates folder (`Documents\Visual Studio 2022\Templates\ProjectTemplates`).

## Using Template
1. Launch Visual Studio. Inside it, open the new project window (`File -> New -> Project...`) and search for `ID2ModTemplate` (if it was just installed, it should be at the top of the list with "new" badge). You can pin it if you plan to use it frequently.
1. Configure and create the project by changing its name and location. Recommendation is to keep solution and project in the same directory. Don't use spaces in the project name, as those get replaced by underscores in project files, which are ugly.
1. Open `config.targets` and fill in the properties there.
	1. `GameInstallPath` should point to ID2's root directory (`<Steam game install path>\Steam\steamapps\common\Ittle Dew 2`).
	1. `PluginsPath` should point to where you have your ID2 mods installed (by default it would be at `Ittle Dew 2\BepInEx\plugins`).
1. In the terminal, run the command `dotnet restore` to install necessary packages.
1. Finally, run the command `dotnet build` to built it. This will automatically add the mod to the game!

## Explanation of Files
- `$safeproojectname$` is a placeholder that gets replaced by your project name. It replaces spaces with underscores.
- `$safeproojectname$\Logger.cs` is a logging helper class.
- `$safeproojectname$\Plugin.cs` is the initialization class. BepInEx will first run this class to initialize your mod.
- `__TemplateIcon.png` is the icon used in the VS template dialog.
- `.editorconfig` is a preconfigured set of rules and convention that all ID2 mods should adhere to for consistency.
- `config.targets` is where you put in user-specific paths to the game's install path and BepInEx plugins path.
- `NuGet.Config` adds additional NuGet package sources.