using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuickLoad : MonoBehaviour
{
    private string level1Name = "Level_01";
    private string level2Name = "Level_02";
    private string level3Name = "Level_03";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftBracket))
        {
            SwitchToPreviousLevel();
        }
        else if (Input.GetKeyDown(KeyCode.RightBracket))
        {
            SwitchToNextLevel();
        }

        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            MainMenu();
        }
    }

    void SwitchToNextLevel()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == level1Name)
        {
            SceneManager.LoadScene(level2Name);
        }
        else if (currentSceneName == level2Name)
        {
            SceneManager.LoadScene(level3Name);
        }
        else if (currentSceneName == level3Name)
        {
            SceneManager.LoadScene(level1Name);
        }
    }

    void SwitchToPreviousLevel()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName == level1Name)
        {
            SceneManager.LoadScene(level3Name);
        }
        else if (currentSceneName == level2Name)
        {
            SceneManager.LoadScene(level1Name);
        }
        else if (currentSceneName == level3Name)
        {
            SceneManager.LoadScene(level2Name);
        }
    }

    void MainMenu()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
