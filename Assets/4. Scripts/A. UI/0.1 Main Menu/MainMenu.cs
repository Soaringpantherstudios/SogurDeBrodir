using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class MainMenu : MonoBehaviour
{
    #region Pubic/Private Variables Main Menu

    //=======================//  Main Canvas //====================================//

    [SerializeField]
    GameObject MainMenuCanvas; // Main Menu Canvas //

    [SerializeField]
    GameObject OptionsCanvas; // Options Canvas //

    [SerializeField]
    GameObject QuitCanvas; // Quit Canvas //


    // ======================// Main Menu Buttons //============================//

    [SerializeField]
    GameObject startGameButton; // Start Game Button //

    [SerializeField]
    GameObject OptionsButton; // Options Game Button //

    [SerializeField]
    GameObject quitGameButton; // Quit Game Button //

    public string sceneName;

    #endregion

    #region Functions Main Menu

    public void GameStartMenu() // This will bring up the new/load game canvas
    {
        MainMenuCanvas.SetActive(false);
        OptionsCanvas.SetActive(false);
        QuitCanvas.SetActive(false);
        gameSelectCanvas.SetActive(true);
    }

    public void OptionsMenu() // This will bring up the options canvas
    {
        MainMenuCanvas.SetActive(false);
        OptionsCanvas.SetActive(true);
        QuitCanvas.SetActive(false);
        gameSelectCanvas.SetActive(false);
    }

    public void QuitMenu() // This will bring up the Quit canvas
    {
        MainMenuCanvas.SetActive(false);
        OptionsCanvas.SetActive(false);
        QuitCanvas.SetActive(true);
        gameSelectCanvas.SetActive(false);
    }

    public void Back()  // This will reset back to the Main Menu Canvas
    {
        MainMenuCanvas.SetActive(true);
        OptionsCanvas.SetActive(false);
        QuitCanvas.SetActive(false);
        gameSelectCanvas.SetActive(false);
    }

    public void No() // This will take you back to main menu
    {
        MainMenuCanvas.SetActive(true);
        OptionsCanvas.SetActive(false);
        QuitCanvas.SetActive(false);
        gameSelectCanvas.SetActive(false);
    }

    public void Quit() // This will Quit the game
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void TestPlay() // Test button function to make sure play button is working
    {
        SceneManager.LoadScene(sceneName);
    }

    #endregion

    #region  Pubic/Private Variables Options Menu

    //==================================// Options Canvas // ==========================// 

    [SerializeField]
    GameObject gameSettings; // Game Settings Canvas //

    [SerializeField]
    GameObject videoSettings; // Video Settings Canvas //

    [SerializeField]
    GameObject audioSettings; // Audio Settings Canvas //

    [SerializeField]
    GameObject controllerSettings; // Controller Settings Canvas // 

    [SerializeField]
    GameObject keyboardSettings; // Keyboard Settings Canvas // 

    //===============================// Options Buttons // ==============================//

    [SerializeField]
    GameObject gameSettingsButton; // PC & Console

    [SerializeField]
    GameObject audioSettingsButton; // PC & Console

    [SerializeField]
    GameObject controllerSetttingsButton; // PC & Console

    [SerializeField]
    GameObject videoSettingsButton; // PC Only

    [SerializeField]
    GameObject keyboardSetttingsButton;  // PC Only

    #endregion

    #region Functions Options Menu  

    public void GameSettingsCanvas()
    {
        OptionsCanvas.SetActive(false);
        gameSettings.SetActive(true);
        videoSettings.SetActive(false);
        audioSettings.SetActive(false);
        controllerSettings.SetActive(false);
        keyboardSettings.SetActive(false);
    }

    public void AudioSettingsCanvas()
    {
        OptionsCanvas.SetActive(false);
        gameSettings.SetActive(false);
        videoSettings.SetActive(false);
        audioSettings.SetActive(true);
        controllerSettings.SetActive(false);
        keyboardSettings.SetActive(false);
    }

    public void ControllerSettingsCanvas()
    {
        OptionsCanvas.SetActive(false);
        gameSettings.SetActive(false);
        videoSettings.SetActive(false);
        audioSettings.SetActive(false);
        controllerSettings.SetActive(true);
        keyboardSettings.SetActive(false);
    }

    public void VideoSettingsCanvas()
    {
        OptionsCanvas.SetActive(false);
        gameSettings.SetActive(false);
        videoSettings.SetActive(true);
        audioSettings.SetActive(false);
        controllerSettings.SetActive(false);
        keyboardSettings.SetActive(false);
    }

    public void KeyboardSettingsCanvas()
    {
        OptionsCanvas.SetActive(false);
        gameSettings.SetActive(false);
        videoSettings.SetActive(false);
        audioSettings.SetActive(false);
        controllerSettings.SetActive(false);
        keyboardSettings.SetActive(true);
    }

    public void optionsBack()
    {
        OptionsCanvas.SetActive(false);
        OptionsCanvas.SetActive(true);
        gameSettings.SetActive(false);
        videoSettings.SetActive(false);
        audioSettings.SetActive(false);
        controllerSettings.SetActive(false);
        keyboardSettings.SetActive(false);
    }

    #endregion

    #region Game Select Menu

    [SerializeField]
    GameObject gameSelectCanvas; // Game Select Canvas //

    #endregion

    #region Unity Start Functions
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion
}
