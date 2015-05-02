using UnityEngine;
using System.Collections;
using System;

public class Screen : MonoBehaviour {

    public GameObject spawnObject;

	// Use this for initialization
	void Start () {
        Debug.Log(spawnObject);
	}

    void OnMouseDown()
    {
        //Debug.Log("Mouse Clicked");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicked");
            PlaceObjectRaycast(typeof(Train));
        }
	}

    public Ray ray;

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(ray);
    }

    public void PlaceObjectRaycast(Type objectType)
    {
        var theObject = objectType;
        Debug.Log(theObject);
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 2000f))
        {
            Instantiate(spawnObject, hit.point, Quaternion.identity);
            //Debug.Log(String.Format("{0} - Created", theObject.name));
            Debug.Log("clickety clackety");
            Debug.Log(hit.collider.name);
        }
        Debug.Log(hit.point.ToString());
    }
}
