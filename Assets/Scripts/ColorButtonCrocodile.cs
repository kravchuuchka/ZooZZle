using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButtonCrocodile : MonoBehaviour
{
    public GameObject blackButton;
    public GameObject colorButton;

    void Start()
    {
        if (IsCompleted.isCrocodile == true)
        {
            blackButton.SetActive(false);
            colorButton.SetActive(true);
        }
    }
}
