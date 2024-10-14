using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointingAt : MonoBehaviour
{

    public Renderer ren;
    [SerializeField] LineRenderer lineRenderer;


    // Start is called before the first frame update
    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        Debug.DrawRay(transform.position, fwd * 10, Color.green, 2);

        RaycastHit a;


        if (Physics.Raycast(transform.position, fwd, out a, 10))
        {
            print("There is something in front of the object!");



            ChangeColour(a.transform);
            ////
            //stuff to set positions on the line renderer
/*

            Vector3[] vectorArray = new Vector3[] { transform.position, a.point };
            lineRenderer.SetPositions(vectorArray);
*/

        }

        
    }

    public void ChangeColour(Transform a)
    {
        
        ren = a.GetComponent<Renderer>();

        ren.material.color = Color.white;
    }

}







