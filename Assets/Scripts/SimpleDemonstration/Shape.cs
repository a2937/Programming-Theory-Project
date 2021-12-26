using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// An abstract design of a shape component.
/// It must have an image component attached to the same
/// game object this component is on. There are already
/// a few shapes implemented such as:
/// <see cref="Triangle"/>
/// <see cref="Square"/>
/// <see cref="Pentagon"/>
/// </summary>
public abstract class Shape : MonoBehaviour
{
    [SerializeField]
    protected Color color;

    [SerializeField]
    protected TextMeshProUGUI displayText;

    protected Image image;

    public void Start()
    {
        image = GetComponent<Image>();
        image.color = color;
    }

    public void SetUITextObject(TextMeshProUGUI textBox)
    {
        displayText = textBox;
    }

    /// <summary>
    /// A property used to represent the color of the image's fill.
    /// </summary>
    public Color Color
    {
        get
        {
            return color;
        }
        protected set
        {
            if (value.r >= 0 && value.r <= 1
       && value.b >= 0 && value.b <= 1 &&
       value.g >= 0 && value.g <= 1
       && value.a >= 0 && value.a <= 1)
            {
                color = value;
            }
            else
            {
                throw new System.Exception("Color values are out of range. They must be between 0 and 1.");
            }
        }
    }

    /// <summary>
    /// Randomly generates an color with an alpha of 255,
    /// that is 100% filled in and then sets the image fill
    /// to the generated color.
    /// </summary>
    public void RandomizeColor()
    {
        var red = Random.Range(0f, 1f);
        var blue = Random.Range(0, 1f);
        var green = Random.Range(0, 1f);
        Color color = new Color(red, green, blue);
        ChangeColor(color);
    }

    /// <summary>
    /// Sets the image fill to the new color and then updates
    /// the text to have information about the shape.
    /// </summary>
    /// <param name="color">The new image fill color</param>
    public void ChangeColor(Color color)
    {
        if (color.r >= 0 && color.r <= 1
            && color.b >= 0 && color.b <= 1 &&
            color.g >= 0 && color.g <= 1
            && color.a >= 0 && color.a <= 1)
        {
            image.color = color;
            Color = color;
            DisplayText();
        }

    }

    /// <summary>
    /// Updates the text box with information about the given
    /// shape's color and other basic facts.
    /// </summary>
    public virtual void DisplayText()
    {
        displayText.text = "We now have a " + ColorUtility.ToHtmlStringRGB(color) + " shape";
    }

    /// <summary>
    /// Resets the component to normal values by ensuring it
    /// has an image component attached to the same gameobject.
    /// </summary>
    public void Reset()
    {
        if (GetComponent<Image>() == null)
        {
            Image image = gameObject.AddComponent<Image>();
            image.color = Color;
        }
    }
}
