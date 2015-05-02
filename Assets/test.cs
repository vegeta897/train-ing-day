using UnityEngine;
using System.Collections;

public class test : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
        Track[,] map = new Track[100, 100];
        for (int i = 0; i < 30; i++)
        {
            int x = Random.Range(0, 50);
            int y = Random.Range(0, 50);
            Debug.Log(x + ":" + y);
            map[x, y] = gameObject.AddComponent<Track>();
            map[x, y].SetPosition(x, y);
        }
	}

	// Update is called once per frame
	void Update () 
    {
	    
	}
}