using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackButton : MonoBehaviour
{
    public GameObject blackButton;
    public GameObject colorButton;

    void Start()
    {
        blackButton.SetActive(true);
        colorButton.SetActive(false);
    }
}
