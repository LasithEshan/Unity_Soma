using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour {

    public GameObject target = null;
    public bool orbitY = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (target != null)
        {
            transform.LookAt(target.transform);

            if (orbitY)
            {
                if (Input.GetKey(KeyCode.G))
                    {
                    transform.RotateAround(target.transform.position, Vector3.up, Time.deltaTime*60);
                }else if (Input.GetKey(KeyCode.H))
                {
                    transform.RotateAround(target.transform.position, Vector3.down, Time.deltaTime * 60);

                }else if (Input.GetKey(KeyCode.V))
                {
                    transform.RotateAround(target.transform.position, Vector3.left, Time.deltaTime * 60);

                }
                else if (Input.GetKey(KeyCode.B))
                {
                    transform.RotateAround(target.transform.position, Vector3.right, Time.deltaTime * 60);

                }
            } 
        }
    }
}
