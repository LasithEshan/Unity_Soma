using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class display3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject child0 = gameObject.transform.GetChild(0).gameObject;
        GameObject child1 = gameObject.transform.GetChild(1).gameObject;
        GameObject child2 = gameObject.transform.GetChild(2).gameObject;
        


        child0.GetComponent<Renderer>().enabled = false;
        child1.GetComponent<Renderer>().enabled = false;
        child2.GetComponent<Renderer>().enabled = false;
        

    }
    public void showw()
    {

        GameObject child0 = gameObject.transform.GetChild(0).gameObject;
        GameObject child1 = gameObject.transform.GetChild(1).gameObject;
        GameObject child2 = gameObject.transform.GetChild(2).gameObject;
        

        child0.GetComponent<Renderer>().enabled = true;
        child1.GetComponent<Renderer>().enabled = true;
        child2.GetComponent<Renderer>().enabled = true;
        

    }
}
