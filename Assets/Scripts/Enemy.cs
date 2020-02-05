using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject target; 
    public Transform player;
    //private Rigidbody rb;

    float rotSpeed = 3.0f;
    float moveSpeed = 3.0f;
    float distToAttack = 5.0f; 

    void Start()
    {
        // rb = this.GetComponent<Rigidbody>(); //lets us use RB to manipulate movement and how our object is
       player = GameObject.FindGameObjectWithTag("Player").transform; 


    }

    // Update is called once per frame
    void Update()
    {
        float distToTarget = CalculateDistance(target);
        Debug.Log(distToTarget); 

        if(distToTarget <= distToAttack)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.position - transform.position), rotSpeed * Time.deltaTime);

            transform.position += transform.forward * moveSpeed * Time.deltaTime;
            //Vector3 direciton = player.position - transform.position; 

        }

    }

    float CalculateDistance(GameObject target)
    {
        Vector3 Myposition = transform.position;
        Vector3 Tposition = target.transform.position;

        float X = Mathf.Abs(Myposition.x - Tposition.x);
        float Y = Mathf.Abs(Myposition.y - Tposition.y); 
        float Z = Mathf.Abs(Myposition.z - Tposition.z);
        float D = Mathf.Sqrt(Mathf.Pow(X, 2) + Mathf.Pow(Y, 2) + Mathf.Pow(Z, 2));

        return D; 
    }
}

