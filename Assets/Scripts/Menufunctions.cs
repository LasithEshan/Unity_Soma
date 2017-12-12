using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menufunctions : MonoBehaviour {

    public void play()
    {
        SceneManager.LoadScene(1);
    }

    public void help()
    {
        SceneManager.LoadScene(2);
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }
 

}
