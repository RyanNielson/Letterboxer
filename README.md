# Letterboxer
Add letterboxing or pillarboxing to your cameras in Unity3d. 

## Why Should I Use Letterboxer?

Letterboxer makes it easy to automatically add letterboxing, pillarboxing, or pixel perfect view scaling to your camera's view. It also updates while in edit mode to give you real-time previews of letterboxing in the game view.

## Installation

Copy the `Letterboxer` folder into your `Assets` folder.

## Usage

1. Add the `Letterboxer` component to your `Camera` GameObject. If a `Camera` component doesn't exist on the GameObject, one will be added.
2. Change the `Target Width` and `Target Height` options to suit your needs. These will be used to determine the aspect ratio for the `Maintain Aspect Ratio` mode, or the base size for the `Best Pixel Perfect Fit` mode.
3. Set the `Type` option, both of which will be described in more detail below.

## Inspector Options

- Target Width: The ideal width of your game view.
- Target Height: The idea height of your game view.
- Type: The type of view scaling behaviour to use. There are two options currently.
  - Maintain Aspect Ratio: Scales the view to fill the screen as much as possible while maintaining aspect ratio. If the resolution doesn't match the target width or height, letterboxing or pillarboxing will be added.
  - Best Pixel Perfect Fit: Scales your view by pixel perfect increments like 1x, 2x, 3x, etc. This ensures equal pixel sizes. For example for a base size of 200x200, view size will be fixed to sizes like 200x200, 400x400, etc depending on screen size.

## Demo

This project contains a demo in the `LetterboxDemo` folder. This includes an example of a camera with the `Letterboxer` component attached. To see how `Letterboxer` behaves, simply change the values on the component attached to the camera.

