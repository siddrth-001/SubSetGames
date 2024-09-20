using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    public GameObject ChessPiece;
    private GameObject[,] position = new GameObject[8,8];
    private GameObject[] BlackPlayer = new GameObject[16];
    private String CurrentPlayer = "Black";
    private bool GameOver = false;

    
    // Start is called before the first frame update
    void Start()
    {
    //    Instantiate(ChessPiece, new Vector3(-1.65f,-12.6f,-3.0f),Quaternion.identity); 
    
    BlackPlayer = new GameObject[]
    {
        Create( "BlackPawn" ,-7,0),
        Create( "BlackPawn" , 0,0),
        Create( "BlackPawn" , 0,0),
        Create( "BlackPawn" ,0,0),
        Create( "BlackPawn" ,0,0),
        Create( "BlackPawn",0,0),
        Create( "BlackPawn",0,0),
        Create( "BlackPawn" ,0,0),
        Create( "BlackRook" ,0,0),
        Create ("BlackKnight" ,0,0),
        Create( "BlackBishop" ,0,0),
        Create( "BlackQueen",0,0),
        Create( "BlackKing" ,0,0),
        Create ("BlackBishop" ,0,0),
        Create( "BlackKnight" ,0,0),
        Create( "BlackRook",0,0)
     
    };

       for(int i=1;i<=BlackPlayer.Length;i++)
        {
         SetPosition(BlackPlayer[i]);         
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public GameObject Create(string name,int x, int y)
    {
        GameObject obj = Instantiate(ChessPiece,new Vector3(0,0,-3),Quaternion.identity);
        ChessMan cm = obj.GetComponent<ChessMan>();
        cm.name = name;
        cm.SetXBoard(x);
        cm.SetXBoard(y);
        cm.Activate();
        return obj;
    }

    public void SetPosition(GameObject obj)
    {
        ChessMan cm = obj.GetComponent<ChessMan>();
        position[cm.GetXBoard(), cm.GetYBoard()] = obj;
    }
}
