using UnityEngine;

/// <summary>
/// Represents the concept of a Square;
/// and an implementation of a Shape.
/// <see cref="Shape"/>
/// </summary>
public class Square : Shape
{
    /// <summary>
    /// Sets the shape's text box to display the color
    /// and says that a square has four sides.
    /// <see cref="Shape.DisplayText"/>
    /// </summary>
    public override void DisplayText()
    {
        displayText.text = "We now have a " + ColorUtility.ToHtmlStringRGB(color) + " square. Which has four sides";
    }
}
