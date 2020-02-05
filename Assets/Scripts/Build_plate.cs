using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Build_plate : MonoBehaviour
{
    public GameObject thecamera;
    public GameObject build; //platform

    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        count = count + 1; 
        if(count >= 3)
        {
            count = 0; 
        }
        if(Input.GetMouseButton(0) && count == 0) //if we click right button
        {
            Debug.Log("Left Mouse clicked"); 
            RaycastHit hit;
            Ray r = thecamera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);


            if (Physics.Raycast(r,out hit))
            {
                Debug.Log("Creating platform"); 
                GameObject.Instantiate(build, hit.point, Quaternion.identity);
            }
           
        }

  
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Zombie")
        {
            SceneManager.LoadScene("Death"); 
        }
    }


}
