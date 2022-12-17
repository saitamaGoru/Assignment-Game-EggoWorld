using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyAnimation : MonoBehaviour
{

  
    protected GameObject obj;
    
    public GameObject GetRef(string name)
    {
        obj = GameObject.Find(name);
        
       
       return obj;
    }
    public GameObject GetRefTwo(string name)
    {
        obj = GameObject.Find(name);


        return obj;
    }

    // Update is called once per frame
    public virtual void PlayAnimation()
    {

    }
}
