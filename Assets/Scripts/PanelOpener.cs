using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {
        bool isActive = Panel.activeSelf;
        if (Panel != null)
            Panel.SetActive(!isActive);
    }
}
