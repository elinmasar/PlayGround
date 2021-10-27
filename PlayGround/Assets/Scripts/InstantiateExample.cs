using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateExample : MonoBehaviour
{
    public GameObject mySphere;

    // Start is called before the first frame update
    void Start()
    {


           // print("hej");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(mySphere, transform.position, transform.rotation);
        }
    }
}
