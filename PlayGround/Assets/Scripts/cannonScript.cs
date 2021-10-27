using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonScript : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bullet;
    float timebetween;
    public float starttimebetween;

    // Start is called before the first frame update
    void Start()
    {
        timebetween = starttimebetween;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump") && timebetween <= 0)
        {
            Instantiate(bullet, firepoint.position, firepoint.rotation);
            //print("text");
            timebetween = starttimebetween;
        }
    }
}
