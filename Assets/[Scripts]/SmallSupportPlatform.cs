using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class SmallSupportPlatform : MonoBehaviour
{
    public Vector2 startPoint;
    public Vector2 endPoint;
    
    public float horDistance = 1.0f;
    public float vertDistance = 0f; 
    

    void Start()
    {
       startPoint = transform.position;
        endPoint = new Vector2(horDistance, vertDistance);
       
    }

    
    void Update()
    {
       transform.position = new Vector3(Mathf.PingPong(Time.time,horDistance )+ startPoint.x,transform.position.y,0.0f);
    }

    public void Deactivate(SmallSupportPlatform platform)
    {
        platform.gameObject.SetActive(false);
    }
}   
