using UnityEngine;
using System.Collections;

public class Track : MonoBehaviour
{

    int gridX = 0;
    int gridY = 0;
    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

    public void SetPosition (int x, int y)
    {
        gridX = x;
        gridY = y;
        cube.transform.localScale = new Vector3(1f, 0.1f, 1f);
        cube.transform.position = new Vector3(gridX, 0, gridY);
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