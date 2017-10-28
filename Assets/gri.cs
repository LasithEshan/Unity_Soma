using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gri : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Renderer>().enabled = false;
	}
	
	public void hide()
    {
        gameObject.GetComponent<Renderer>().enabled = true;

    }

}
