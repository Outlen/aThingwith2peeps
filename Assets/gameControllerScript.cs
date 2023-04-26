using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControllerScript : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    public float Camera;
    public float Player2Cam;

    
    // Start is called before the first frame update
    void Start()
    {
        Camera = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Camera == 1f)
            {
                Camera = 2f;
            }
            else
            {
                Camera = 1f;
            }
        }

        if (Camera == 1)
        {
            Camera1.SetActive(true);
            Camera2.SetActive(false);

        }
        if (Camera == 2)
        {
            Camera1.SetActive(false);
            Camera2.SetActive(true);

        }









    }
}
