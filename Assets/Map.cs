﻿using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour 
{

    Object[,] map = new Object[100, 100];

    public void AddTrack(int x, int y)
    {
        Debug.Log(x+","+ y);
        if(x >= 0 && x <= 100 && y >= 0 && y <= 100) // If coords are in map area
        {
            if(!map[x,y]) // If this grid space is empty
            {
                Debug.Log("Creating track at " + x + ", " + y);
                map[x, y] = Instantiate(GetComponent<Factory>().CreateTrack(), new Vector3(x, 0, y), Quaternion.identity);
            }
            else
            {
                if(map[x,y].name != "StationPiece(Clone)")
                {
                    Destroy(map[x, y]);
                }
            }
        }
    }

	// Use this for initialization
	void Start () 
    {
        for(int i = 0; i < 3; i++)
        {
            int x = Random.Range(0, 50);
            int y = Random.Range(0, 50);

            Debug.Log("Creating station at " + x + ", " + y);
            map[x, y] = Instantiate(GetComponent<Factory>().CreateStation(), new Vector3(x, 0, y), Quaternion.identity);
        }
	}

	// Update is called once per frame
	void Update () 
    {
	    
	}
}