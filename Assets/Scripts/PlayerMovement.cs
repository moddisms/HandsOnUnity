using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Public variable to set the speed in the Inspector
    public float speed;
    public float rotation;
    void Update() 
    {

        {
            if (Input.GetKey(KeyCode.W)) { transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime, Space.Self); }
            if (Input.GetKey(KeyCode.S)) { transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime, Space.Self); }
            if (Input.GetKey(KeyCode.A)) { transform.Translate(new Vector3(-speed, 0, 0) * Time.deltaTime, Space.Self); }
            if (Input.GetKey(KeyCode.D)) { transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime, Space.Self); }
        }
        {

            float mouseX = Input.GetAxis("Mouse X");
            transform.Rotate(0, mouseX * rotation * Time.deltaTime, 0);
        }
    }
}