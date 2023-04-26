using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerahighlight : MonoBehaviour
{
    public Sprite HighlightedCamera;
    public Sprite DefaultCamera;
    public Transform Camera;
    public gameControllerScript GameScript;

    public Camera cam;
    public float MousePosX;
    public float MousePosY;
    public float PosX;
    public float PosY;
    public float Radius;

    Vector2 mousePos;



   


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PosX = Camera.position.x;
        PosY = Camera.position.y;
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        MousePosX = mousePos.x;
        MousePosY = mousePos.y;
        float NewPosX = Mathf.Pow( MousePosX - PosX , 2) ;
        float NewPosY = Mathf.Pow(MousePosY - PosY, 2);
        if (NewPosX < 0)
        {
            NewPosX = NewPosX * -1f;
        }
        if (NewPosY < 0)
        {
            NewPosY = NewPosY * -1f;
        }
        float Squarething = NewPosX + NewPosY;
        Radius = Mathf.Sqrt(Squarething);

        if (Radius < 1.22f)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = HighlightedCamera;
            if (Input.GetMouseButtonDown(0))
            {
                if (gameObject.tag == "Cam1")
                {
                    GameScript.Player2Cam = 1;
                }
                if (gameObject.tag == "Cam2")
                {
                    GameScript.Player2Cam = 2;
                }

                if (gameObject.tag == "Cam3")
                {
                    GameScript.Player2Cam = 3;
                }

                if (gameObject.tag == "Cam4")
                {
                    GameScript.Player2Cam = 4;
                }

                if (gameObject.tag == "Cam5")
                {
                    GameScript.Player2Cam = 5;
                }

                if (gameObject.tag == "Cam6")
                {
                    GameScript.Player2Cam = 6;
                }

                if (gameObject.tag == "Cam7")
                {
                    GameScript.Player2Cam = 7;
                }

                if (gameObject.tag == "Cam8")
                {
                    GameScript.Player2Cam = 8;
                }

                if (gameObject.tag == "Cam9")
                {
                    GameScript.Player2Cam = 9;
                }

                if (gameObject.tag == "Cam10")
                {
                    GameScript.Player2Cam = 10;
                }

                if (gameObject.tag == "Cam11")
                {
                    GameScript.Player2Cam = 11;
                }









            }
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = DefaultCamera;
        }















        






    }
    
    }




