using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Pool.GetPoolObject<TypeOne>(transform.position + new Vector3(0f, 2f,-2f), transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Pool.GetPoolObject<TypeTwo>( transform.position + new Vector3(0f, 2f,-2f), transform.rotation);
        }
        
    }
}
