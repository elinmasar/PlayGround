using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopExampleLong : MonoBehaviour
{
    public GameObject[] objectNames;
    public int width = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            for (int i = 0; i < 5; i++)
            {   
                for (int j = 0; j < 5; j++)
                {
                    Instantiate(objectNames[i], transform.position + (new Vector3(i, j, 0)), transform.rotation);

                }
            }
        }
    }
}
