using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{

    public override void DisplayText()
    {
        displayText.text = "We now have a " + ColorUtility.ToHtmlStringRGB(color) + " square. Which has four sides";
    }
}
