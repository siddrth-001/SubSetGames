using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ChessMan : MonoBehaviour
{
    // References
    public GameObject GameManager;
    public GameObject movePlate;

    // Position 
    private int xBoard =-1;
    private int yBoard =-1;

    //    VAriables for Black and White Players
    private string player;

    // Reference Sprites
    public Sprite BlackQueen,BlackKnight,BlackBishop,BlackKing,BlackRook,BlackPawn;
  


  public void Activate()
  {
    GameManager = GameObject.FindGameObjectWithTag("GameController");
    
    //take Instantiated location and Transform
    SetCoords();

    switch(this.name)
    {
        case "BlackQueen": this.GetComponent<SpriteRenderer>().sprite = BlackQueen;
        break;

        case "BlackKnight": this.GetComponent<SpriteRenderer>().sprite = BlackKnight;
        break;

        case "BlackBishop": this.GetComponent<SpriteRenderer>().sprite = BlackBishop;
        break;

        case "BlackKing": this.GetComponent<SpriteRenderer>().sprite = BlackKing;
        break;

        case "BlackRook": this.GetComponent<SpriteRenderer>().sprite = BlackRook;
        break;

        case "BlackPawn": this.GetComponent<SpriteRenderer>().sprite = BlackPawn;
        break;
    }
  }
 

  public void SetCoords()
  {
     float x = xBoard;
     float y = yBoard;

     x*=.6f;
     y*=.6f;

     x+=-2.3f;
     y+=-2.3f;

     this.transform.position = new Vector3(x,y,-3.0f);
  }

  public int GetXBoard()
  {
    return xBoard;
  }

  public int GetYBoard()
  {
    return yBoard;
  }

  public void SetXBoard(int x)
  {
    xBoard =x;
  }

   public void SetYBoard(int y)
  {
    yBoard =y;
  }

}


//-12.5,8.9