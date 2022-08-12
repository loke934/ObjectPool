using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    private static Pool instance; 
    

    private static Dictionary<Type, List<PoolBehaviour>> poolsDictionary =
        new Dictionary<Type, List<PoolBehaviour>>();

    [SerializeField]
    public List<PoolSetting> poolSettingsList;

    private void Awake()
    {
        instance = this; //Not safe
        CreatePools();
    }

    private void CreatePools()
    {
        for (int i = 0; i < poolSettingsList.Count; i++)
        {
            List<PoolBehaviour> objectList = new List<PoolBehaviour>();
            for (int j = 0; j < poolSettingsList[i].PoolSize; j++)
            {
                PoolBehaviour obj = Instantiate(poolSettingsList[i].PoolPrefab);
                obj.gameObject.SetActive(false);
                objectList.Add(obj);
            }
            poolsDictionary.Add(poolSettingsList[i].PoolPrefab.GetType(), objectList);
        }
    }
    
 
    public static T GetPoolObject<T>(Vector3 position, Quaternion rotation) where T : PoolBehaviour
    {
        return instance.InternalGetPoolObject(typeof(T), position, rotation) as T;
    }
    private PoolBehaviour InternalGetPoolObject(Type type, Vector3 position, Quaternion rotation)
    {
        PoolBehaviour poolObject = null;
        for (int i = 0; i < poolsDictionary[type].Count; i++)
        {
            if (!poolsDictionary[type][i].IsActive)
            {
                poolObject = poolsDictionary[type][i];
                break;
            }
        }
        if (poolObject == null)
        {
            poolObject = Instantiate(poolsDictionary[type][0]);
            poolsDictionary[type].Add(poolObject);
        }
        poolObject.gameObject.SetActive(true);
        poolObject.transform.position = position;
        poolObject.transform.rotation = rotation;
        return poolObject;
    }
}
