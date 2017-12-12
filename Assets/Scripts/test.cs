using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    public GameObject[][] sCube = new GameObject[7][];
    public GameObject testObject;

    int[,,] gridMap;
    string formation;
    public dataList dataList = new dataList();

    public int form;
    public int id;
    

    



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

        gridMap = new int[3, 3, 3];//3D array which holds the positions of the cube pieces
        form = 0;
        id = 0;
        TextAsset asset = Resources.Load("data") as TextAsset;

        if(asset != null)
        {
            dataList = JsonUtility.FromJson<dataList>(asset.text);
     

        }
        else
        {
            print("asset is null");
        }

        piece1 = GameObject.FindGameObjectsWithTag("piece1");
        piece2 = GameObject.FindGameObjectsWithTag("piece2");
        piece3 = GameObject.FindGameObjectsWithTag("piece3");
        piece4 = GameObject.FindGameObjectsWithTag("piece4");
        piece5 = GameObject.FindGameObjectsWithTag("piece5");
        piece6 = GameObject.FindGameObjectsWithTag("piece6");
        piece7 = GameObject.FindGameObjectsWithTag("piece7");

        sCube[0] = piece1;
        sCube[1] = piece2;
        sCube[2] = piece3;
        sCube[3] = piece4;
        sCube[4] = piece5;
        sCube[5] = piece6;
        sCube[6] = piece7;

        formation = "";

        





        print("x"+Mathf.Floor(piece1[0].transform.position.x));
        //print("y"+piece1[0].transform.position.y);
        //print("z"+piece1[0].transform.position.z);
        print(getPositionX(piece1[0]));



       // print("x" + piece1[1].transform.position.x);
        //print("y" + piece1[1].transform.position.y);
        //print("z" + piece1[1].transform.position.z);



    }

    public void checkCube() {


        print("finish build clicked");

        print(getPositionX(piece1[2]));
        print(getPositionX(sCube[2][0]));

        for(int i=0; i<sCube.Length; i++)
        {
            for(int j=0; j<sCube[i].Length; j++)
            {
                if(getPositionX(sCube[i][j])<0 || getPositionY(sCube[i][j]) < 0|| getPositionZ(sCube[i][j]) < 0 || getPositionX(sCube[i][j]) >= 3 || getPositionY(sCube[i][j]) >= 3 || getPositionZ(sCube[i][j]) >= 3)
                {
                    print("cube not formed");
                    break;
                }else
                {
                    gridMap[getPositionX(sCube[i][j]),getPositionY(sCube[i][j]),getPositionZ(sCube[i][j])] = i+1;
                }
                //else enter the piece condinates into the index of 3d array
                //mark the location with the corresponding i value
            }
        }
    }




    public void showForm()
    {
        print("Button clicked");


        for(int i =0; i<3; i++)
        {
            for(int j=0; j<3; j++)
            {
                for(int k =0; k<3; k++)
                {
                    formation += gridMap[k, i, j];
                }
            }
        }
        print(formation);


        string fixedFormation = formation.Replace(" ", string.Empty);
        string fixedConfig;

        foreach (data datas in dataList.data)
        {

            fixedConfig = datas.config.Replace(" ", string.Empty);

            if (fixedFormation == fixedConfig)
            {
                id = datas.id;
                form = datas.number;
                break;
            }else
            {
                continue;
            }
            
        }

        print(form);
        saveresult();


        /*print(gridMap[0, 0, 0]);
        print(gridMap[1, 0, 0]);
        print(gridMap[2, 0, 0]);
        print(gridMap[0, 0, 1]);
        print(gridMap[1, 0, 1]);
        print(gridMap[2, 0, 1]);
        print(gridMap[0, 0, 2]);
        print(gridMap[1, 0, 2]);
        print(gridMap[2, 0, 2]);

        print(gridMap[0, 1, 0]);
        print(gridMap[1, 1, 0]);
        print(gridMap[2, 1, 0]);
        print(gridMap[0, 1, 1]);
        print(gridMap[1, 1, 1]);
        print(gridMap[2, 1, 1]);
        print(gridMap[0, 1, 2]);
        print(gridMap[1, 1, 2]);
        print(gridMap[2, 1, 2]);

        print(gridMap[0, 2, 0]);
        print(gridMap[1, 2, 0]);
        print(gridMap[2, 2, 0]);
        print(gridMap[0, 2, 1]);
        print(gridMap[1, 2, 1]);
        print(gridMap[2, 2, 1]);
        print(gridMap[0, 2, 2]);
        print(gridMap[1, 2, 2]);
        print(gridMap[2, 2, 2]);*/

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

    public void saveresult()
    {
        PlayerPrefs.SetInt("formation", form);
        SceneManager.LoadScene(3);
    }


}
