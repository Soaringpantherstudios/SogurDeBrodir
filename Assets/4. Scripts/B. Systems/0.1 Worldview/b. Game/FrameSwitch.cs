using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameSwitch : MonoBehaviour
{
    #region Unity Callbacks
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion

    #region Public Variables

    public GameObject Frame1;
    public GameObject Frame2;

    #endregion

    void OnTriggerEnter2D(Collider2D Edge)
    {
        if(Edge.tag == "Player" && Frame1.active == true)
        {
            Frame1.SetActive(false);
            Frame2.SetActive(true);
        }
        else if (Edge.tag == "Player" && Frame1.active == false)
        {
            Frame1.SetActive(true);
            Frame2.SetActive(false);
        }
    }
}
