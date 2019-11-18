using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTrigger : MonoBehaviour
{
    #region Variables

    public string sceneName;

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

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Has entered");
            SceneManager.LoadScene(sceneName);
            
        }
    }
    #endregion
}
