# Limbo Separator

Limbo Separator is a small package for Umbraco that adds a property editor serving as a separator to give a better overview of properties within your Umbraco content types.

<table>
  <tr>
    <td><strong>License:</strong></td>
    <td><a href="./LICENSE.md"><strong>MIT License</strong></a></td>
  </tr>
  <tr>
    <td><strong>Umbraco:</strong></td>
    <td>v10</td>
  </tr>
  <tr>
    <td><strong>Target Framework:</strong></td>
    <td>.NET 6</td>
  </tr>
</table>

<br /><br />

## Installation

The package only supports Umbraco 10. To install the package, you can use either .NET CLI:

```
dotnet add package Limbo.Umbraco.Separator --version 1.0.0
```

or the NuGet Package Manager:

```
Install-Package Limbo.Umbraco.Separator -Version 1.0.0
```

For previous versions of Umbraco, see either our older [**Skybrud.Separator**](https://github.com/skybrud/Skybrud.Separator) package (for Umbraco 8 and 9), or the [**CM.Seperator**](https://www.nuget.org/packages/CM.Seperator) package by [Rasmus Fjord](https://twitter.com/rasmusfjord?lang=da) (for Umbraco 7).

<br /><br />

## Screenshots

The separator property editor helps group similar properties within an existing property group:

![image](https://user-images.githubusercontent.com/3634580/84443532-1812ef80-ac40-11ea-8077-515c48015070.png)

[NuGetPackage]: https://www.nuget.org/packages/Limbo.Umbraco.Separator
[GitHubRelease]: https://github.com/limbo-works/Limbo.Umbraco.Separator/releases

<br /><br />

## Documentation

### Description

The title shown in the separator is based on the label of the property. If you also enter a description for your property, the description will be shown below the separator title.

![image](https://user-images.githubusercontent.com/3634580/174460208-1f2f4aed-8543-4e98-8878-ea947a8a6c0a.png)

### CSS class name

The separator data type has an optional option for entering a custom CSS class name, which can then be used to customize the styling of the separator. Eg. if you'd wish to create a separator that is more visible than the default styling.

![image](https://user-images.githubusercontent.com/3634580/174460243-7740377b-fca8-470b-8da9-b32cf00fe1a2.png)

![image](https://user-images.githubusercontent.com/3634580/174460227-16fdc933-92ca-4fc9-9bb5-ced462b26f81.png)

The example shown in the screenshots above can be accomplished by adding the following CSS/LESS to your solution:

```css
.limbo-separator-primary.limbo-separator {
    margin: -21px -20px -21px -20px;
    border-bottom: 0;
    .limbo-separator-content {
        border-top: 15px solid #fff;
        border-bottom: 10px solid #fff;
        padding: 7px 20px;
        background: #ccc;
        background: #1b264f;
        color: #fff;
    }
    .limbo-separator-title {
        font-weight: bold;
    }
    .limbo-separator-description {
        color: #efefef;
    }
}
```
