using UnityEngine;
using System.Collections;

public class Track : MonoBehaviour
{

    public int gridX { get; set; }
    public int gridY { get; set; }

	// Use this for initialization
	void Start () 
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.localScale = new Vector3(1f, 0.1f, 1f);
        cube.transform.position = new Vector3(gridX,0,gridY);
	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}
}