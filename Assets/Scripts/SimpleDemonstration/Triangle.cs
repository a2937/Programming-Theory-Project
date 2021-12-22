using UnityEngine;

/// <summary>
/// Represents the concept of a Triangle
/// and an implementation of a Shape.
/// <see cref="Shape"/>
/// </summary>
public class Triangle : Shape
{
    /// <summary>
    /// Sets the shape's text box to display the color
    /// and says that a triangle has three sides.
    /// <see cref="Shape.DisplayText"/>
    /// </summary>
    public override void DisplayText()
    {
        displayText.text = "We now have a " + ColorUtility.ToHtmlStringRGB(color) + " triangle. Which has three sides";
    }
}
