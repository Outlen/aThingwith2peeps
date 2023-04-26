using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hidedarkness : MonoBehaviour
{
    public Transform Darkness;
    public bool HideDarkness;

    private float DarknessX;
    private float DarknessY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HideDarkness == true)
        {
            DarknessX = transform.position.x;
            DarknessY = transform.position.y;

            Darkness.transform.position = new Vector2(DarknessX, DarknessY + 2000f);
        }
     
       

        
    }
}
