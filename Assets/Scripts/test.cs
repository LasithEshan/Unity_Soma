using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    GameObject[][] sCube = new GameObject[7][];

    GameObject[] piece1;
    GameObject[] piece2;
    GameObject[] piece3;
    GameObject[] piece4;
    GameObject[] piece5;
    GameObject[] piece6;
    GameObject[] piece7;
    

    // Use this for initialization
    void Start()
    {
        //adding child objects into separate arrays at the start
        //each array will contain a list of gameobjects with the specific tag

        sCube[0] = piece1;
        sCube[1] = piece2;
        sCube[2] = piece3;
        sCube[3] = piece4;
        sCube[4] = piece5;
        sCube[5] = piece6;
        sCube[6] = piece7;


        piece1 = GameObject.FindGameObjectsWithTag("piece1");
        piece2 = GameObject.FindGameObjectsWithTag("piece2");
        piece3 = GameObject.FindGameObjectsWithTag("piece3");
        piece4 = GameObject.FindGameObjectsWithTag("piece4");
        piece5 = GameObject.FindGameObjectsWithTag("piece5");
        piece6 = GameObject.FindGameObjectsWithTag("piece6");
        piece7 = GameObject.FindGameObjectsWithTag("piece7");




        print("x"+Mathf.Floor(piece1[0].transform.position.x));
        //print("y"+piece1[0].transform.position.y);
        //print("z"+piece1[0].transform.position.z);
        print(getPositionX(piece1[0]));



       // print("x" + piece1[1].transform.position.x);
        //print("y" + piece1[1].transform.position.y);
        //print("z" + piece1[1].transform.position.z);



    }

    void checkCube() {

        for(int i=0; i<sCube.Length; i++)
        {
            for(int j=0; j<sCube[i].Length; j++)
            {
                if(getPositionX(sCube[i][j])<0 || getPositionY(sCube[i][j]) < 0|| getPositionZ(sCube[i][j]) < 0)
                {
                    //Checking whether it is a cube.Not complete
                }
            }
        }
    }






    int getPositionX(GameObject piece)
    {
        int xPos = (int)Mathf.Floor(piece.transform.position.x);
        return xPos;        //returns the grid position of a single cube in x
    }



    int getPositionY(GameObject piece)
    {
        int yPos = (int)Mathf.Floor(piece.transform.position.y);
        return yPos;    //returns the grid position of a single cube in y
    }


    int getPositionZ(GameObject piece)
    {
        int zPos = (int)Mathf.Floor(piece.transform.position.z);
        return zPos;    //returns the grid position of a single cube in z
    }


}
