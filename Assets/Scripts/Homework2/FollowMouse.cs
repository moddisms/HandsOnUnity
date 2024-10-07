using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    [Range (0,100)] public float speed;
    public Camera camera;
    void Update()
    {


        // the mouse position
        Vector2 mouse       = Input.mousePosition;

        // convert the mouse position (which is in pixels) into world coordinates
        Vector3 world       = camera.ScreenToWorldPoint(mouse);

        // align the mouse position (the Y AXIS) with the character
        Vector3 destination = new Vector3(world.x, transform.position.y, world.z);

        // momentum builder
        
        // distance between our mouse and our character

        float distance = Vector3.Distance(destination, transform.position);

        float velocity = (speed * distance) * Time.deltaTime;
        
        // character turn to face this position
        transform.LookAt(destination);

        // character move towards this position
        transform.position += transform.forward * velocity;

    }


  
}