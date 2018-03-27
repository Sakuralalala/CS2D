﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galil : Gun {

    /// <summary>
    /// 该枪械的射击方法
    /// </summary>
    public override void Shoot()
    {
        GetComponent<Galil>().AttackTime -= Time.deltaTime;
        if (GetComponent<Galil>().MaxShoot > 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (GetComponent<Galil>().AttackTime <= 0)
                {
                    GetComponent<Galil>().AttackTime = 0.7f;
                    GameObject clone = Instantiate(GetComponent<Galil>().ShootObj, GetComponent<Galil>().ShootPos.position, GetComponent<Galil>().ShootPos.rotation);
                    clone.name = "galilButtle";
                    GetComponent<Galil>().MaxShoot--;
                }
            }
        }
        
    }

    /// <summary>
    /// 初始化方法
    /// </summary>    
    private void Init()
    {
        GetComponent<Galil>().MaxShoot = 90;
        GetComponent<Galil>().AttackForce = 25;
        GetComponent<Galil>().AttackTime = 0.7f;
        GetComponent<Galil>().ShootPos = GetComponentInChildren<Transform>().Find("shootPosition");
    }
    // Use this for initialization
    void Start () {
        Init();
	}
	
}
