using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButtonGiraffe : MonoBehaviour
{
    public GameObject blackButton;
    public GameObject colorButton;

    void Start()
    {
        if (IsCompleted.isGiraffe == true)
        {
            blackButton.SetActive(false);
            colorButton.SetActive(true);
        }
    }
}
