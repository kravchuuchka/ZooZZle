using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePause : MonoBehaviour
{
    [SerializeField]
    public GameObject pauseMenu;
    public GameObject puzzle;

    void Update()
    {
        if (Input.touchCount > 0 && pauseMenu.activeInHierarchy)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                pauseMenu.SetActive(false);
                puzzle.SetActive(false);
            }

        }
    }
}
