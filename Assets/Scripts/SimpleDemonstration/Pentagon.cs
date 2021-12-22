using UnityEngine;

/// <summary>
/// Represents the concept of a Pentagon;
/// and an implementation of a Shape.
/// <see cref="Shape"/>
/// </summary>
public class Pentagon : Shape
{
    /// <summary>
    /// Sets the shape's text box to display the color
    /// and says that a pentagon has five sides.
    /// <see cref="Shape.DisplayText"/>
    /// </summary>
    public override void DisplayText()
    {
        displayText.text = "We now have a " + ColorUtility.ToHtmlStringRGB(color) + " pentagon. \n Which has five sides.";
    }
}
