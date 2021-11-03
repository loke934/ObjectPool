using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PoolBehaviour : MonoBehaviour, IPoolObject
{
    //Base class, can not be instantiated on its own with abstract. Some cases you want to instantiate base class?
    public bool IsActive => this.gameObject.activeInHierarchy;
    
    protected abstract void OnEnable(); 
    // protected: only this class and classes derived from this class can use method
    // abstract: must be implemented by classes that derive from this class
    
    protected abstract IEnumerator Destroy(float seconds);
    public void Return()
    {
        this.gameObject.SetActive(false);
    }

    // private void OnCollisionEnter(Collision other)
    // {
    //     this.Return();
    // }
}
