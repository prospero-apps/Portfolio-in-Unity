using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hyperlinks : MonoBehaviour
{
    [SerializeField] private TMP_Text textElement;
    private Color basicColor;

    void Start()
    {
        basicColor = textElement.color;
    }

    public void Hover()
    {
        textElement.color = Color.gray;
    }

    public void StopHovering()
    {
        textElement.color = basicColor;
    }


    public void OpenURL(string url)
    {
        Application.OpenURL(url);
    }
}


