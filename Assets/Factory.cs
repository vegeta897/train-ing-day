using UnityEngine;
using System.Collections;

public class Factory : MonoBehaviour 
{

    public Object CreateTrain()
    {
        return Resources.Load("Prefabs/TrainDrainEngain");
    }

    public Object CreateTrack()
    {
        return Resources.Load("Prefabs/TrackPiece");
    }

    public Object CreateStation()
    {
        return Resources.Load("Prefabs/StationPiece");
    }

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
