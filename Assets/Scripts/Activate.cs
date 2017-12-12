using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour {
    GameObject par;
	// Use this for initialization
	void Start () {
        
        par.GetComponentInParent<pieceMove>().enabled = false;


    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0)){
            par.GetComponentInParent<pieceMove>().enabled = true;
            Debug.Log("work");
            
        }
	}
}
