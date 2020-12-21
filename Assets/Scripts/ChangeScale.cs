using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeScale : MonoBehaviour
{
    public Button zoomIn;
    public Button zoomOut;
    private Vector3 scaleChange = new Vector3(0.1f, 0.1f, -0.1f);

    void Start()
    {
        zoomIn.onClick.AddListener(() => Zoom(true));
        zoomOut.onClick.AddListener(() => Zoom(false));
    }

    private void Zoom(bool size) //if size == true : zoomIn, else : zoomOut
    {
        if (size) { this.transform.localScale += scaleChange; } else { this.transform.localScale -= scaleChange; }
    }
}
