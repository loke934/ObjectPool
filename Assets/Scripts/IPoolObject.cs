using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPoolObject 
{
   bool IsActive { get; }
   void Return();
}
