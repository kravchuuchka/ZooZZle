using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour
{
    [SerializeField]
    public GameObject getWin;

    public void Start()
    {
        getWin.SetActive(false);
    }

    public void Update()
    {
        if ((Head.giraffeLocked && Tail.giraffeLocked && Body.giraffeLocked) ||
        (Head.crocodileLocked && Tail.crocodileLocked && Body.crocodileLocked) ||
        (Head.hippopotamusLocked && Tail.hippopotamusLocked && Body.hippopotamusLocked))
        {
            StartCoroutine(GetStart());
        }
    }
    public IEnumerator GetStart()
    {
        yield return new WaitForSeconds(1);
        getWin.SetActive(true);
        if (Head.giraffeLocked && Tail.giraffeLocked && Body.giraffeLocked)
            IsCompleted.isGiraffe = true;
        if (Head.crocodileLocked && Tail.crocodileLocked && Body.crocodileLocked)
            IsCompleted.isCrocodile = true;
        if (Head.hippopotamusLocked && Tail.hippopotamusLocked && Body.hippopotamusLocked)
            IsCompleted.isHippopotamus = true;
    }
}
