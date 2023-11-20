using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int currentLevelIndex = 0;

    public void LoadNextLevel()
    {
        currentLevelIndex++;
        LoadScene(currentLevelIndex);
    }
    public void LoadPreviousLevel()
    {
        if (currentLevelIndex > 1)
        {
            currentLevelIndex--;
            LoadScene(currentLevelIndex);
        }
    }
    public void LoadSpecificlevel(int levelIndex)
    {
        if (levelIndex > 1 && levelIndex <= SceneManager.sceneCountInBuildSettings - 1)
        {
            currentLevelIndex = levelIndex; 
            LoadScene(currentLevelIndex);
        }
    }
    private void LoadScene(int index)
    {
        /// <summary>
        /// Loads new scene
        /// </summary>
        
        SceneManager.LoadScene(index);
        Debug.Log("Start Button pressed, Loaded Next Scene");
    }
    public void QuitGame()
    {
        Debug.Log("Qutting Application");
        Application.Quit();
    }
}
