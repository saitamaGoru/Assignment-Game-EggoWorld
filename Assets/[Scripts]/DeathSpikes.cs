using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;



public class DeathSpikes : MonoBehaviour
{
  
    public float timer = 0; //under process

  
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Player")
        {
            FindObjectOfType<VirtualCamera>().ZoomCamera();
            var smallSupportPlatform = FindObjectOfType<SmallSupportPlatform>();
            smallSupportPlatform.Deactivate(smallSupportPlatform);
           PlayerController player = FindObjectOfType<PlayerController>();
            player.animator.SetInteger("AnimationState", 4);
            Debug.Log("Player Died");
            
             Destroy(player.gameObject,5f);

            
        }


     
}
}
