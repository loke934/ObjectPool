using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeOne : PoolBehaviour
{
    protected override void OnEnable()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Vector3.zero;
        rb.velocity = Vector3.zero;

        StartCoroutine(Destroy(4f));
    }

    protected override IEnumerator Destroy(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Return();
    }
}
