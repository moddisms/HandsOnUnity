using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemiMover : MonoBehaviour
{

    [Range(0, 1000)] public float speed = 10f;
    [Range(0, 1000)] public float turn = 200f;


    void Update()
    {

        if (ClickScript.selected == this.gameObject)
            Mover();

    }

    void Mover()
    {
    // RETURNS YOUR HORIZONTAL AND VERTCIAL inputs
    // as either -1, 0, or 1
    float move = Input.GetAxis("Vertical");
    float rotate = Input.GetAxis("Horizontal");

    // MULTIPLIES them by the speed
    // when you're multiplying move by speed "(move * speed)"
    // you're multiplying the value stored in "move", by the value stored in "speed"
    move = (move * speed) * Time.deltaTime;
    rotate = (rotate * turn) * Time.deltaTime;

    // SETS the movement
    // "+=" is shorthand for typing out "value = value +"
    // "transform.forward" is shorthand for typing out "new Vector3(0, 0, 1);"
    transform.position += transform.forward * move;

    // SETS the rotation
    // "transform.up" is shorthand for typing out "new Vector3(0, 1, 0);" 
    transform.Rotate(transform.up * rotate, Space.Self);
    }
}
