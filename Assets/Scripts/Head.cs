using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    [SerializeField]

    private Transform headPlace;

    private Vector2 initialPosition;

    private float deltaX, deltaY;

    private bool canMove;

    public static bool locked;

    private void Start()
    {
        locked = false;
        initialPosition = transform.position;
    }

    private void Update()
    {
        if (Input.touchCount > 0 && !locked)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        canMove = true;
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;
                    }
                    break;

                case TouchPhase.Moved:         
                    if (canMove)
                        transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
                    break;

                case TouchPhase.Ended:
                    if (Mathf.Abs(transform.position.x - headPlace.position.x) <= 0.5f &&
                        Mathf.Abs(transform.position.y - headPlace.position.y) <= 0.5f)
                    {
                        transform.position = new Vector2(headPlace.position.x, headPlace.position.y);
                        locked = true;
                    }
                    else
                    {
                        canMove = false;
                        transform.position = new Vector2(initialPosition.x, initialPosition.y);
                    }
                    break;
            }
        }
    }
}
