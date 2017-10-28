using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pieceMove : MonoBehaviour {

	// gUse this for initialization
	

	void Start () {
       
	}

    // Update is called once per frame
    void FixedUpdate() {



        transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime*2f, Input.GetAxis("Vertical")*Time.deltaTime*3f, Input.GetAxis("Mouse X"));



        //first.GetComponent<pieceMove> ().enabled = true;

    }

		

		
	}

