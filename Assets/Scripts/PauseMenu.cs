using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    public GameObject pauseMenu;
    public GameObject puzzle;

    public void Update()
    {
        if (ChangeScene.isTutorialSavannah && SceneManager.GetActiveScene().name == "LocationSavannah")
        {
            ChangeScene.isTutorialSavannah = false;
            ClickPause();
        }

        if (ChangeScene.isTutorialGiraffe && SceneManager.GetActiveScene().name == "Giraffe")
        {
            ChangeScene.isTutorialGiraffe = false;
            ClickPause();
        }
    }

    public void ClickPause()
    {
        pauseMenu.SetActive(true);
        puzzle.SetActive(true);
    }
}
