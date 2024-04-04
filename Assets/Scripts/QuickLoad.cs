using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuickLoad : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftBracket))
        {
            SwitchToPreviousScene();
        }
        else if (Input.GetKeyDown(KeyCode.RightBracket))
        {
            SwitchToNextScene();
        }

        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            MainMenu();
        }
    }

    void SwitchToNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextSceneIndex);
    }

    void SwitchToPreviousScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int previousSceneIndex = (currentSceneIndex - 1 + SceneManager.sceneCountInBuildSettings) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(previousSceneIndex);
    }

    void MainMenu()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
