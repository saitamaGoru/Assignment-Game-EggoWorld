using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
[System.Serializable]
public class VirtualCamera : MonoBehaviour
{

    CinemachineVirtualCamera vcOne;
    private void Start()
    {
        
        vcOne = GetComponent<CinemachineVirtualCamera>();   
    }

    public void ZoomCamera()
    {
        vcOne.m_Lens.OrthographicSize = 2.0f;
    }
}
