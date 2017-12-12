using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Changeformation : MonoBehaviour {

    public Text formText;

	// Use this for initialization
	void Start () {
        int formation = PlayerPrefs.GetInt("formation");

        formText.text = formation.ToString();
        //formText.text = ("formations ");

    }


}
