using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    public string[] chrName;
    public GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(objects[Random.Range(0, 3)], transform.position, transform.rotation);
        }
    }
}
