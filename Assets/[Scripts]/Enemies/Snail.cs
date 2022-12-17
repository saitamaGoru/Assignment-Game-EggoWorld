using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snail : SlimeEnemy
{
    // Start is called before the first frame update
    void Start()
    {
        SettingRef();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        IsGroundAhead();
    }
}
