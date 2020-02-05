using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_platform : MonoBehaviour
{
    Plane plane;
    GameObject thecam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Ray r = thecam.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

            float fDist = 0.0f;
            plane.Raycast(r, out fDist);
            transform.position = r.GetPoint(fDist); 
        }
    }
}
