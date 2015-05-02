using UnityEngine;
using System.Collections;

public class Station : MonoBehaviour 
{

    int resources = 0;

    void AccumulateResources()
    {
        resources++;
        gameObject.transform.localScale = new Vector3(1, 0.2f + resources * 0.02f, 1);
        Vector3 pos = gameObject.transform.position;
        gameObject.transform.position = new Vector3(pos.x, 0.1f + resources * 0.01f, pos.z);
    }

	// Use this for initialization
	void Start () 
    {
        InvokeRepeating("AccumulateResources",1,1);
	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}
}
