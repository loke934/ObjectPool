using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PoolBehaviour : MonoBehaviour, IPoolObject
{
    public bool IsActive => this.gameObject.activeInHierarchy;
    
    protected abstract void OnEnable(); 
    
    protected abstract IEnumerator Destroy(float seconds);
    public void Return()
    {
        this.gameObject.SetActive(false);
    }

}
