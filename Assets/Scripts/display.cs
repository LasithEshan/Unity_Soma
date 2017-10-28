using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class display : MonoBehaviour {

 

    // Use this for initialization
    void Start () {

        GameObject child0 = gameObject.transform.GetChild(0).gameObject;
        GameObject child1 = gameObject.transform.GetChild(1).gameObject;
        GameObject child2 = gameObject.transform.GetChild(2).gameObject;
        GameObject child3 = gameObject.transform.GetChild(3).gameObject;


        child0.GetComponent<Renderer>().enabled = false;
        child1.GetComponent<Renderer>().enabled = false;
        child2.GetComponent<Renderer>().enabled = false;
        child3.GetComponent<Renderer>().enabled = false;



    }

    public void showw()
    {

        GameObject child0 = gameObject.transform.GetChild(0).gameObject;
        GameObject child1 = gameObject.transform.GetChild(1).gameObject;
        GameObject child2 = gameObject.transform.GetChild(2).gameObject;
        GameObject child3 = gameObject.transform.GetChild(3).gameObject;

        child0.GetComponent<Renderer>().enabled = true;
        child1.GetComponent<Renderer>().enabled = true;
        child2.GetComponent<Renderer>().enabled = true;
        child3.GetComponent<Renderer>().enabled = true;

    }


}
