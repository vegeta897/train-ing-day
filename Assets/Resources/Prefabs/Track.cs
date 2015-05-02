using UnityEngine;
using System.Collections;

public class Track : MonoBehaviour
{

    int gridX = 0;
    int gridY = 0;

    public void SetPosition (int x, int y)
    {
        gridX = x;
        gridY = y;
        gameObject.transform.position = new Vector3(gridX, 0, gridY);
    }

	// Use this for initialization
	void Start () 
    {
        Vector3 pos = gameObject.transform.position;
        gameObject.transform.position = new Vector3(pos.x, 0.05f, pos.z);
	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}
}