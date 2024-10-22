using UnityEngine;
using System.Collections.Generic;
public class Pebble : MonoBehaviour
{
    public GameObject pebble;

    private Queue<GameObject> pebbles = new Queue<GameObject>();

    void Update()
    {
        // when player hits left mouse button - place pebble
        
        if (Input.GetMouseButtonDown(0))
        {
            Place();
        }
    }

void Place()
{
// get mouse location (this tells us IN TERMS OF OUR SCREEN)
Vector2 mouse = Input.mousePosition;

//add depth to the mouse coordinate

Vector3 depth = new Vector3(mouse.x, mouse.y, 20f);

// mouse position to world co-ordinates (this tells us IN TERMS OF OUR GAME WORLD) 
Vector3 world = Camera.main.ScreenToWorldPoint(depth);
// make new pebbles 

GameObject crumbs = Instantiate(pebble, world, Quaternion.identity, this.transform);

//
pebbles.Enqueue(crumbs);

if (pebbles.Count > 10)
    Kill();
}

void Kill()
{
  //remove the first pebble on the list

  GameObject crumb = pebbles.Dequeue();
  Destroy(crumb); 
}
      

}

