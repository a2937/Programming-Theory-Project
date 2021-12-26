using NUnit.Framework;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

public class ColorTest
{

    [UnityTest]
    public IEnumerator TriangleColorChanges()
    {
        TextMeshProUGUI descriptionText = Object.Instantiate(Resources.Load<TextMeshProUGUI>("Prefabs/Shape Description Text"));
        Shape triangle = Object.Instantiate(Resources.Load<Triangle>("Prefabs/Triangle"));
        triangle.Start();
        yield return new WaitForFixedUpdate();
        triangle.SetUITextObject(descriptionText);
        Color color = new Color(0.2f, 0.2f, 0.2f);
        triangle.ChangeColor(color);
        Image triangleImage = triangle.GetComponent<Image>();
        Assert.AreEqual(color, triangleImage.color);
    }

    [UnityTest]
    public IEnumerator SquareColorChanges()
    {
        TextMeshProUGUI descriptionText = Object.Instantiate(Resources.Load<TextMeshProUGUI>("Prefabs/Shape Description Text"));
        Shape square = Object.Instantiate(Resources.Load<Square>("Prefabs/Square"));
        square.Start();
        yield return new WaitForFixedUpdate();
        square.SetUITextObject(descriptionText);
        Color color = new Color(0.2f, 0.2f, 0.2f);
        square.ChangeColor(color);
        Image squareImage = square.GetComponent<Image>();
        Assert.AreEqual(color, squareImage.color);
    }


    [UnityTest]
    public IEnumerator PentagonColorChanges()
    {
        TextMeshProUGUI descriptionText = Object.Instantiate(Resources.Load<TextMeshProUGUI>("Prefabs/Shape Description Text"));
        Shape pentagon = Object.Instantiate(Resources.Load<Pentagon>("Prefabs/Pentagon"));
        pentagon.Start();
        yield return new WaitForFixedUpdate();
        pentagon.SetUITextObject(descriptionText);
        Color color = new Color(0.2f, 0.2f, 0.2f);
        pentagon.ChangeColor(color);
        Image pentagonImage = pentagon.GetComponent<Image>();
        Assert.AreEqual(color, pentagonImage.color);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator ColorTestWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
