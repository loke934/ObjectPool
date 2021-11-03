using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//If not using generics, you can use enum and pass that in as parameter and key
public enum PoolType
{
    TypeOne,
    TypeTwo,
}

//Use method to get pool object in Pool.cs
// public static PoolBehaviour GetPoolObject(PoolType type, Vector3 position, Quaternion rotation)
// {
//     return instance.InternalGetPoolObject(type, position, rotation);
// }
