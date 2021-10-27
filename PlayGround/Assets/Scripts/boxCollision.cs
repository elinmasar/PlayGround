using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            Destroy(gameObject);
            print("hit");
        }

    }
}
