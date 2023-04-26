using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfeed : MonoBehaviour
{
    public GameObject CamFeed1;
    public GameObject CamFeed2;
    public GameObject CamFeed3;
    public GameObject CamFeed4;
    public GameObject CamFeed5;
    public GameObject CamFeed6;
    public GameObject CamFeed7;
    public GameObject CamFeed8;
    public GameObject CamFeed9;
    public GameObject CamFeed10;
    public GameObject CamFeed11;





    public gameControllerScript GameScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameScript.Player2Cam == 1f)
        {
            CamFeed1.SetActive(true);
            CamFeed2.SetActive(false);
            CamFeed3.SetActive(false);
            CamFeed4.SetActive(false);
            CamFeed5.SetActive(false);
            CamFeed6.SetActive(false);
            CamFeed7.SetActive(false);
            CamFeed8.SetActive(false);
            CamFeed9.SetActive(false);
            CamFeed10.SetActive(false);
            CamFeed11.SetActive(false);           
        }
        if (GameScript.Player2Cam == 2f)
        {
            CamFeed1.SetActive(false);
            CamFeed2.SetActive(true);
            CamFeed3.SetActive(false);
            CamFeed4.SetActive(false);
            CamFeed5.SetActive(false);
            CamFeed6.SetActive(false);
            CamFeed7.SetActive(false);
            CamFeed8.SetActive(false);
            CamFeed9.SetActive(false);
            CamFeed10.SetActive(false);
            CamFeed11.SetActive(false);
        }
        if (GameScript.Player2Cam == 3f)
        {
            CamFeed1.SetActive(false);
            CamFeed2.SetActive(false);
            CamFeed3.SetActive(true);
            CamFeed4.SetActive(false);
            CamFeed5.SetActive(false);
            CamFeed6.SetActive(false);
            CamFeed7.SetActive(false);
            CamFeed8.SetActive(false);
            CamFeed9.SetActive(false);
            CamFeed10.SetActive(false);
            CamFeed11.SetActive(false);
        }
        if (GameScript.Player2Cam == 4f)
        {
            CamFeed1.SetActive(false);
            CamFeed2.SetActive(false);
            CamFeed3.SetActive(false);
            CamFeed4.SetActive(true);
            CamFeed5.SetActive(false);
            CamFeed6.SetActive(false);
            CamFeed7.SetActive(false);
            CamFeed8.SetActive(false);
            CamFeed9.SetActive(false);
            CamFeed10.SetActive(false);
            CamFeed11.SetActive(false);
        }
        if (GameScript.Player2Cam == 5f)
        {
            CamFeed1.SetActive(false);
            CamFeed2.SetActive(false);
            CamFeed3.SetActive(false);
            CamFeed4.SetActive(false);
            CamFeed5.SetActive(true);
            CamFeed6.SetActive(false);
            CamFeed7.SetActive(false);
            CamFeed8.SetActive(false);
            CamFeed9.SetActive(false);
            CamFeed10.SetActive(false);
            CamFeed11.SetActive(false);
        }
        if (GameScript.Player2Cam == 6f)
        {
            CamFeed1.SetActive(false);
            CamFeed2.SetActive(false);
            CamFeed3.SetActive(false);
            CamFeed4.SetActive(false);
            CamFeed5.SetActive(false);
            CamFeed6.SetActive(true);
            CamFeed7.SetActive(false);
            CamFeed8.SetActive(false);
            CamFeed9.SetActive(false);
            CamFeed10.SetActive(false);
            CamFeed11.SetActive(false);
        }
        if (GameScript.Player2Cam == 7f)
        {
            CamFeed1.SetActive(false);
            CamFeed2.SetActive(false);
            CamFeed3.SetActive(false);
            CamFeed4.SetActive(false);
            CamFeed5.SetActive(false);
            CamFeed6.SetActive(false);
            CamFeed7.SetActive(true);
            CamFeed8.SetActive(false);
            CamFeed9.SetActive(false);
            CamFeed10.SetActive(false);
            CamFeed11.SetActive(false);
        }
        if (GameScript.Player2Cam == 8f)
        {
            CamFeed1.SetActive(false);
            CamFeed2.SetActive(false);
            CamFeed3.SetActive(false);
            CamFeed4.SetActive(false);
            CamFeed5.SetActive(false);
            CamFeed6.SetActive(false);
            CamFeed7.SetActive(false);
            CamFeed8.SetActive(true);
            CamFeed9.SetActive(false);
            CamFeed10.SetActive(false);
            CamFeed11.SetActive(false);
        }
        if (GameScript.Player2Cam == 9f)
        {
            CamFeed1.SetActive(false);
            CamFeed2.SetActive(false);
            CamFeed3.SetActive(false);
            CamFeed4.SetActive(false);
            CamFeed5.SetActive(false);
            CamFeed6.SetActive(false);
            CamFeed7.SetActive(false);
            CamFeed8.SetActive(false);
            CamFeed9.SetActive(true);
            CamFeed10.SetActive(false);
            CamFeed11.SetActive(false);
        }
        if (GameScript.Player2Cam == 10f)
        {
            CamFeed1.SetActive(false);
            CamFeed2.SetActive(false);
            CamFeed3.SetActive(false);
            CamFeed4.SetActive(false);
            CamFeed5.SetActive(false);
            CamFeed6.SetActive(false);
            CamFeed7.SetActive(false);
            CamFeed8.SetActive(false);
            CamFeed9.SetActive(false);
            CamFeed10.SetActive(true);
            CamFeed11.SetActive(false);
        }
        if (GameScript.Player2Cam == 11f)
        {
            CamFeed1.SetActive(false);
            CamFeed2.SetActive(false);
            CamFeed3.SetActive(false);
            CamFeed4.SetActive(false);
            CamFeed5.SetActive(false);
            CamFeed6.SetActive(false);
            CamFeed7.SetActive(false);
            CamFeed8.SetActive(false);
            CamFeed9.SetActive(false);
            CamFeed10.SetActive(false);
            CamFeed11.SetActive(true);
        }








    }
}
