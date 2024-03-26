using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joybutton : MonoBehaviour
{

    protected Joystick joystick;
    protected Joybutton joybutton;

    protected bool jump;

    public bool Pressed { get; private set; }

    // use this for initialization
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();
    }

    // Update is called once per frame
    void Update()
    {

        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(joystick.Horizontal * 100f,
                                         rigidbody.velocity.y,
                                         joystick.Vertical * 100f);

        if (!jump && joybutton.Pressed)
        {
            jump = true;
            rigidbody.velocity += Vector3.up * 100f;
        }

        if (jump && !joybutton.Pressed)
        {
            jump = false;
        }



    }
}