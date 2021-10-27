using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollosionTest : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name  == "Floor")
        {
            Destroy(gameObject);
        }

    }
}
