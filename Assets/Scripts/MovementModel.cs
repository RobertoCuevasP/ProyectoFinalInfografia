using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementModel : MonoBehaviour
{
    public Button rightButton;
    public Button leftButton;

    void Start()
    {
        rightButton.onClick.AddListener(() => Rotate("right"));
        leftButton.onClick.AddListener(() => Rotate("left"));
        
    }

    private void Rotate(string direction)
    {
        if (direction == "right")
        {
            this.transform.Rotate(Vector3.up * 10);
        } else if (direction == "left")
        {
            this.transform.Rotate(Vector3.down * 10);
        }
    }

    
}
