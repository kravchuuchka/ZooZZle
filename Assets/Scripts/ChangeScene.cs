using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public static bool isTutorialSavannah = false;
    public static bool isTutorialGiraffe = false;

    public void ChangeScenes(string sceneName)
    {
        if (!PlayerPrefs.HasKey("IsFirstRun"))
            PlayerPrefs.SetInt("IsFirstRun", 1);

        if (PlayerPrefs.GetInt("IsFirstRun") == 1)
        {
            SceneManager.LoadScene("ZooMapTutorial");
            isTutorialSavannah = true;
            isTutorialGiraffe = true;
        }

        else
            SceneManager.LoadScene(sceneName);

        PlayerPrefs.SetInt("IsFirstRun", 0);
    }
}
