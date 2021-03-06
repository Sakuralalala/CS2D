﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usp : Gun {

    /// <summary>
    /// AI调用的射击方法
    /// </summary>
    public override void AIShoot()
    {
        GetComponent<Usp>().AttackTime -= Time.deltaTime;
        if (GetComponent<Usp>().MaxShoot > 0)
        {
            if (GetComponent<Usp>().AttackTime <= 0)
            {
                GetComponent<AudioSource>().Play();
                GetComponent<Usp>().AttackTime = 1.0f;
                //Debug.Log("ok");
                GameObject clone = Instantiate(GetComponent<Usp>().ShootObj, GetComponent<Usp>().ShootPos.position, GetComponent<Usp>().ShootPos.rotation);
                clone.name = "uspButtle";
                GetComponent<Usp>().MaxShoot--;
            }
        }
        else
        {
            return;
        }
    }

    /// <summary>
    /// 该枪械的射击方法
    /// </summary>
    public override void Shoot()
    {
        GetComponent<Usp>().AttackTime -= Time.deltaTime;
        if (GetComponent<Usp>().MaxShoot > 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (GetComponent<Usp>().AttackTime <= 0)
                {
                    GetComponent<AudioSource>().Play();
                    GetComponent<Usp>().AttackTime = 1.0f;
                    //Debug.Log("ok");
                    GameObject clone = Instantiate(GetComponent<Usp>().ShootObj, GetComponent<Usp>().ShootPos.position, GetComponent<Usp>().ShootPos.rotation);
                    clone.name = "uspButtle";
                    GetComponent<Usp>().MaxShoot--;
                }
            }
            else
            {
                return;
            }
        }
    }
    /// <summary>
    /// 初始化方法
    /// </summary>    
    public void Init()
    {

        GetComponent<Usp>().MaxShoot = 40;
        GetComponent<Usp>().AttackForce = 9;
        GetComponent<Usp>().AttackTime = 1.0f;
        GetComponent<Usp>().ShootPos = GetComponentInChildren<Transform>().Find("shootPosition");
        GetComponent<Usp>().ID = 9;
    }
    // Use this for initialization
    void Start()
    {
        Init();
    }
}
