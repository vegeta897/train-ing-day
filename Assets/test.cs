using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class test : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
        int[,] map = new int[100, 100];
        map[50, 50] = 3;
        Debug.Log(map[50,50]);
	}

	// Update is called once per frame
	void Update () 
    {
	    
	}
}
