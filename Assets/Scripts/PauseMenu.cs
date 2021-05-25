using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    public GameObject pauseMenu;
    public GameObject puzzle;

    public void ClickPause()
    {
        pauseMenu.SetActive(true);
        puzzle.SetActive(true);
    }
}
