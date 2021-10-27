using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{

    public float speed = 5f;
    public float timer; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float hor = Input.GetAxis("Horizontal"); //Input manager, to get the cube to move
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        timer += Time.deltaTime;

        if (timer > 3f)
        {
            speed = -speed;
            timer = 0;
        }
    }
}
