using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneTutorial : MonoBehaviour
{
    public void ChangeScenesTutorial(string tutorialSceneName)
    {
        SceneManager.LoadScene(tutorialSceneName);
    }
}
