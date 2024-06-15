# Ittle Dew 2 Mod Template

This is a template for building Ittle Dew 2 mods. It has all the necessary files for the mod to run, so requires minimal effort to get a new mod up and running!

## How does this Work?
What you download from [Releases](https://github.com/Extra-2-Dew/ID2ModTemplate/releases) page is the project template folder for Visual Studio. With it installed, you can easily create a new mod from the template from within Visual Studio.

## Installing Template
1. Download the latest `ID2ModTemplate.zip` file from [Releases](https://github.com/Extra-2-Dew/ID2ModTemplate/releases) page
2. Place the downloaded `ID2ModTemplate.zip` into your Visual Studio project templates folder (`Documents\Visual Studio 2022\Templates\ProjectTemplates`)

## Using Template
1. Launch Visual Studio. Inside it, open the new project window (`File -> New -> Project...`) and search for `ID2ModTemplate` (if it was just installed, it should be at the top of the list with "new" badge)
2. Configure and create the project by changing its name and location. Recommendation is to keep solution and project in the same directory.
3. Add a new file to the project. Name the file `AssemblyName.csproj.user`, but replace `AssemblyName` with the name of your assembly (eg. if your assembly name is `NewMod`, this file should be `NewMod.csproj.user`).
4. In this new file, add this XML code and put in the full path to your Ittle Dew 2 install's root folder (eg. `D:\Steam\steamapps\common\Ittle Dew 2`):
```xml
<Project>
	<PropertyGroup>
		<GameInstallPath></GameInstallPath>
	</PropertyGroup>
</Project>
```
5. In the terminal, run the command `dotnet restore` to install necessary packages
6. Finally, run the command `dotnet build` to built it. This will automatically add the mod to the game!

## Publishing Your Mod
1. When you're ready to publish your mod to the (future) mod loader, you'll want to update the `manifest.json` file with your mod's information. The mod loader reads this file to display info about it. you can replace `thumbnail.png` as well, as this will be the preview of your mod in the mod loader.

## Explanation of Files
- `manifest.json` contains the data used by (the future) mod manager, such as mod name, description, thumbnail, etc.
- `default-config.json` contains any options your mod should have by default. If not empty, a `config.json` will be added to mod folder on first launch of the game that will have these default options in it
- `thumbnail.png` is the thumbnail used to represent your mod. It will be displayed in (the future) mod manager
- `NuGet.config` is necessary for BepInEx packages
- `AssemblyName.csproj.user` contains user-specific path variables used for the project
- `Plugin.cs` is the initialization class. BepInEx will first run this class to initialize your mod

## Conventions
- Keep all classes contained within the `Code` folder
- The `Plugin` class should never be renamed. This is BepInEx convention. This is the class that runs first when mod is initialized
    - Use the `Plugin` class only for initialization stuff