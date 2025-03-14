using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    string currentScene = "";
    
    public void ChangeToSceneOne()
    {
        currentScene = SceneManager.GetActiveScene().name;

        if (currentScene != "Scene01")
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            Debug.Log("You're already in scene one!");
        }
    }

    public void ChangeToSceneTwo()
    {
        currentScene = SceneManager.GetActiveScene().name;

        if (currentScene != "Scene02")
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            Debug.Log("You're already in scene two!");
        }
    }
}
