﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class map2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public void OnDown()
    {
        //第二地图
        SceneManager.LoadScene(3);
    }
}
