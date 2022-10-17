using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class DeathController : MonoBehaviour
{
    public Transform playerSpawnPoint;
    private void Start()
    {

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
       // Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Player")
        {
            other.gameObject.transform.position = playerSpawnPoint.position;
        }
    }
}
