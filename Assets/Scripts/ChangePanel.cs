using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePanel : MonoBehaviour
{
    public GameObject closedPanel;
    public GameObject openedPanel;

    public void ChangePanels()
    {
        if (closedPanel != null)
        {
            closedPanel.SetActive(false);
            openedPanel.SetActive(true);
        }
    }
}
