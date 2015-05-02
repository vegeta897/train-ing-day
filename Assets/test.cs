using UnityEngine;
using System.Collections;

public class test : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
        Track[,] map = new Track[100, 100];
        int x = 25;
        int y = 25;
        for (int i = 0; i < 300; i++)
        {
            int dir = Random.Range(0, 3);
            for (int j = 0; j < 2; j++)
            {
                switch (dir)
                {
                    case 0:
                        x++;
                        break;
                    case 1:
                        x--;
                        break;
                    case 2:
                        y++;
                        break;
                    case 3:
                        y--;
                        break;
                }
                map[x, y] = gameObject.AddComponent<Track>();
                map[x, y].SetPosition(x, y);
            }
        }
	}

	// Update is called once per frame
	void Update () 
    {
	    
	}
}