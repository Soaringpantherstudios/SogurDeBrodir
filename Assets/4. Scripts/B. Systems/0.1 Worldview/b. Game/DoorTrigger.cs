using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DoorTrigger : MonoBehaviour
{
    #region Variables

    public string sceneName;

    [SerializeField]
    GameObject SceneChangePanel;


    #endregion

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

    #region Detect Player
    // Funtion is used to detect the player //

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Has entered");
            SceneChangePanel.SetActive(true);
            // Need to pause the game at this point so the player can choose their option
        }
    }
    #endregion

    #region UI Functions

    public void Yes()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void No()
    {
        SceneChangePanel.SetActive(false);
    }
    #endregion
}
