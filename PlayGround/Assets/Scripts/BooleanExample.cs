using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanExample : MonoBehaviour
{
    public bool mySwitch = false;
    public GameObject Bomb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            Instantiate(Bomb, transform.position, transform.rotation);
        }

        if (Input.GetButtonUp("Jump"))
        {
            mySwitch = false; //!mySwitch = päinvastaiseen tilaan, aka false in this case
        }
    }
}
