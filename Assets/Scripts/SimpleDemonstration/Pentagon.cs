using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pentagon : Shape
{
    public override void DisplayText()
    {
        displayText.text = "We now have a " + ColorUtility.ToHtmlStringRGB(color) + " pentagon. \n Which has five sides.";
    }
}
