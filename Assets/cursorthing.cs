using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorthing : MonoBehaviour
{
    public float cursorX;
    public float cursorY;
    



    public float cursorAdjustX;
    public float cursorAdjustY;

    public gameControllerScript GameScript;

    public Transform CursorPos;
    public Camera cam1;
    public Camera cam2;
    Vector3 player1scale;
    Vector3 player2scale;

    Vector2 mousePos;
    
    // Start is called before the first frame update
    void Start()
    {
        cursorAdjustX = -0.225f;
        cursorAdjustY = 0.3f;
        Cursor.visible = false;

        player1scale = new Vector3(0.1f, 0.1f, 0.1f);
        player2scale = new Vector3(0.5f, 0.5f, 0.5f);



    }

    // Update is called once per frame
    void Update()
    {
        if (GameScript.Camera == 1)
        {
            mousePos = cam1.ScreenToWorldPoint(Input.mousePosition);
            cursorX = mousePos.x;
            cursorY = mousePos.y;
            CursorPos.transform.localScale = player1scale;
            cursorAdjustX = -0.225f;
            cursorAdjustY = 0.3f;
        }
        if (GameScript.Camera == 2)
        {
            mousePos = cam2.ScreenToWorldPoint(Input.mousePosition);
            cursorX = mousePos.x;
            cursorY = mousePos.y;
            CursorPos.transform.localScale = player2scale;
            cursorAdjustX = -1f;
            cursorAdjustY = 1f;
        }







        CursorPos.transform.position = new Vector2(cursorX - cursorAdjustX, cursorY - cursorAdjustY);

        
        



    }
}

internal class playerController
{
}