using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class YouWin : MonoBehaviour
{
    [SerializeField]
    private GameObject getWin;

    private void Start()
    {
        getWin.SetActive(false);
    }

    private void Update()
    {
        if (Head.locked && Tail.locked && Body.locked)
            StartCoroutine(GetStart());        
    }

    private IEnumerator GetStart()
    {
        yield return new WaitForSeconds(1);
        getWin.SetActive(true);
    }
}
