# Klazapp Script Creator

Klazapp Script Creator is a Unity Editor tool designed to streamline the process of creating new scripts from templates. It provides quick access to generating both MonoBehaviour and ScriptableObject scripts directly from the Unity Editor's menus.

## Features

- **Script Generation**: Quickly generate MonoBehaviour and ScriptableObject scripts.
- **Easy Access**: Create scripts via menu options or right-click in the Project window.
- **Template Customization**: Use predefined templates to ensure scripts adhere to project standards.
- **Context Sensitivity**: Only allows script creation in valid project directories to prevent misplaced files.

## Dependencies

- Unity 2020.3 LTS or newer.

## Installation

1. Clone or download the repository containing the script creator.
2. Import the package into your Unity project.
3. Make sure the package is located under your project's `Packages` directory for correct functioning.

## Usage

To create a new script, you can use one of the following methods:
- **MonoBehaviour Script**:
  - Go to `Klazapp > Create > MonoBehaviour Script` in the menu bar.
  - Right-click in the Project window and navigate to `Assets > Create > Klazapp > MonoBehaviour Script`.
- **ScriptableObject Script**:
  - Go to `Klazapp > Create > ScriptableObject Script` in the menu bar.
  - Right-click in the Project window and navigate to `Assets > Create > Klazapp > ScriptableObject Script`.

Scripts will be created in the currently selected directory within the Assets folder, following validation checks to ensure they are not created in inappropriate directories like `Packages` or `Editor`.

## Customization

Modify the script templates located at:
- MonoBehaviour: `Packages/com.klazapp.scriptcreator/Editor/Data/MonoBehaviourTemplate.cs.txt`
- ScriptableObject: `Packages/com.klazapp.scriptcreator/Editor/Data/ScriptableObjectTemplate.cs.txt`

Adjust these templates to fit your project's coding standards or requirements.

## Known Issues

- Scripts created in non-asset or special folders may not behave as expected due to Unity's asset compilation and management rules.

## To-Do List

- Add support for additional script types such as custom editors or interfaces.
- Provide GUI for managing and customizing templates directly from Unity.

## License

This project is licensed under the MIT License - see the LICENSE.md file for details.
