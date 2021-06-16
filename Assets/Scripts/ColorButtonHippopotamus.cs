using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButtonHippopotamus : MonoBehaviour
{
    public GameObject blackButton;
    public GameObject colorButton;

    void Start()
    {
        if (IsCompleted.isHippopotamus == true)
        {
            blackButton.SetActive(false);
            colorButton.SetActive(true);
        }
    }
}
