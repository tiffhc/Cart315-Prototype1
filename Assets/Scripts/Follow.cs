using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{

   // GameObject leader = GameObject.FindWithTag("Player");
   // GameObject follower;
    Transform target = null;
    private float speed = 0; 
   // float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
       if(target!= null)
        {
            transform.Translate((target.position - transform.position).normalized * speed * Time.deltaTime);
        }
        //follower.transform.LookAt(target);
        //follower.transform.Translate(speed * Vector3.forward * Time.deltaTime);
    }

    public void SetTarget(GameObject newT, float chaseSpeed)
    {
        target = newT.transform;
        speed = chaseSpeed; 
    }
}
