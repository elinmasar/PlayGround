using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopExample : MonoBehaviour
{
    public GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {
        //for(int i=0; i<5; i++)
        //{
        //    print(i);
       // }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            for(int i=0; i<5; i++)
            {
                Instantiate(objects[i], transform.position + (new Vector3(i, 0, 0)), transform.rotation);
                // Instantiate(objects[Random.Range(0, 3)], transform.position, transform.rotation);
            }
        }
    }
}
