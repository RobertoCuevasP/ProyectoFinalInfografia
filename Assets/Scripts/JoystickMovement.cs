using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickMovement : MonoBehaviour
{
    protected Joystick joystick;
    
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    void Update()
    {
        this.transform.Rotate(new Vector3(joystick.Vertical, joystick.Horizontal, 0f));
    }
}
