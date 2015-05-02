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

	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}
}