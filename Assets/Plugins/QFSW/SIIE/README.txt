SIIE - Selectable Inversion Image Effect - for any support or questions or suggestions, please contact me at yusuf@qfsw.co.uk
This image effect allows you to easily and effortlessly create selectively invert parts of the screen

Begin by creating the layer "SelectableInversion", then adding the image effect to your main camera.

If you select Use Colored Inversion, then the image will approach a user specified color as the inversion approaches 50% instead of the gray that would otherwise be achieved by combining an inverted image with a non inverted image.

Clicking Use Mask Color will use the color of the mask at that pixel for the mid inversion color instead of a constant user defined color

The Clear Color lets you chose what color the Inversion Camera will clear to, you can also think of this as the default inversion value

To manipulate the effect via code, ensure to add `using QFSW.SIIE;` to your script
