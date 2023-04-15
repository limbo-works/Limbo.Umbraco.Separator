# Property Editor

The package introduces a **Limbo Separator** property editor (alias: `Limbo.Umbraco.Separator`) that you can use for creating new data types. The property editor displays a horizontal separator that is useful to give better overview of properties within your Umbraco content types when tabs and groups are not enough.

When in use, the property editor will show a title and optionally also a description. The title shown in the separator is based on the label of the property. If you also enter a description for your property, the description will be shown below the separator title.

![image](https://user-images.githubusercontent.com/3634580/174460208-1f2f4aed-8543-4e98-8878-ea947a8a6c0a.png)

## Configuration

### CSS class name

The separator data type has an optional setting for entering a custom CSS class name, which can then be used to customize the styling of the separator. Eg. if you'd wish to create a separator that is more visible than the default styling.

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
