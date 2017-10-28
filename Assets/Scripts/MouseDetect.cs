using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDetect : MonoBehaviour 
{
	public bool objmove=false; //variable to check whether object is selected or not


	void Update () 
	{
		if (objmove == true) //key controls for the movements of the cube
		{
			if (Input.GetKeyDown ("up")) 
			{
				this.transform.Translate(0f,1f,0f);
			}
			if (Input.GetKeyDown ("down")) 
			{
				this.transform.Translate(0f,-1f,0f);
			}
            if (Input.GetKeyDown("left"))
            {
                this.transform.Translate(1f,0f, 0f);
            }
            if (Input.GetKeyDown("right"))
            {
                this.transform.Translate(-1f, 0f, 0f);
            }
            if (Input.GetKeyDown("a"))
            {
                this.transform.Translate(0f, 0f, 1f);
            }
            if (Input.GetKeyDown("d"))
            {
                this.transform.Translate(0f, 0f, -1f);
            }
            if (Input.GetKeyDown("q"))
            {
                this.transform.Rotate(90f , 0f, 0f);
            }
            if (Input.GetKeyDown("w"))
            {
                this.transform.Rotate(0f, 90f, 0f);
            }
            if (Input.GetKeyDown("e"))
            {
                this.transform.Rotate(0f, 0f, 90f);
            }

        }
	}
	public void OnMouseOver() // detecting click and activating object for movement
	{
		if (objmove==false & Input.GetMouseButtonDown (0)) 
		{
			objmove = true;
			Debug.Log ("active");

		}
		else if (objmove==true & Input.GetMouseButtonDown (0)) 
		{
			objmove = false;
			Debug.Log ("not active");
		}
	}


}
