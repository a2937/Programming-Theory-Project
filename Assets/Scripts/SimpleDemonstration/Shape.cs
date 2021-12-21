using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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

    public Color Color
    {
        get
        {
            return color;
        }
        protected set
        {
            color = value;
        }
    }

    public void RandomizeColor()
    {
        var red = Random.Range(0f, 1f);
        var blue = Random.Range(0, 1f);
        var green = Random.Range(0, 1f);
        Color color = new Color(red, green, blue);
        ChangeColor(color);
    }

    public void ChangeColor(Color color)
    {
        image.color = color;
        Color = color;
        DisplayText();
    }

    public virtual void DisplayText()
    {
        displayText.text = "We now have a " + ColorUtility.ToHtmlStringRGB(color) + " shape";
    }

    public void Reset()
    {
        if (GetComponent<Image>() == null)
        {
            Image image = gameObject.AddComponent<Image>();
            image.color = Color;
        }
    }
}
