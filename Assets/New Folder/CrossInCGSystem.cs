﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrossInCGSystem : MonoBehaviour {
    public static bool isStart = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        SceneManager.UnloadSceneAsync("CG");
        if (!isStart)
        {
            GameObject.FindGameObjectWithTag("music").GetComponent<RectTransform>().localPosition = new Vector3(-157, 168, 0);
        }
    }
}
