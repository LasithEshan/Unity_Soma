using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

  

    // Use this for initialization
    void Start()
    {
        //adding child objects into separate arrays at the start

        GameObject[] piece1 = GameObject.FindGameObjectsWithTag("piece1");
        GameObject[] piece2 = GameObject.FindGameObjectsWithTag("piece2");
        GameObject[] piece3 = GameObject.FindGameObjectsWithTag("piece3");
        GameObject[] piece4 = GameObject.FindGameObjectsWithTag("piece4");
        GameObject[] piece5 = GameObject.FindGameObjectsWithTag("piece5");
        GameObject[] piece6 = GameObject.FindGameObjectsWithTag("piece6");
        GameObject[] piece7 = GameObject.FindGameObjectsWithTag("piece7");

    }

    void check() {

    }
}
