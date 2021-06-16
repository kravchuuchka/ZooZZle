using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Body : MonoBehaviour
{
    [SerializeField]

    private Transform bodyPlace;

    private Vector2 initialPosition;

    private float deltaX, deltaY;

    private bool canMove;

    private string  sceneName;

    public static bool giraffeLocked;
    public static bool crocodileLocked;
    public static bool hippopotamusLocked;

    private void Start()
    {
        giraffeLocked = false;
        crocodileLocked = false;
        hippopotamusLocked = false;
        initialPosition = transform.position;
        sceneName = SceneManager.GetActiveScene().name;
    }

    private void Update()
    {
        switch (sceneName)
        {
            case "Giraffe":
                {
                    if (Input.touchCount > 0 && !giraffeLocked)
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
                                if (Mathf.Abs(transform.position.x - bodyPlace.position.x) <= 0.5f &&
                                    Mathf.Abs(transform.position.y - bodyPlace.position.y) <= 0.5f)
                                {
                                    transform.position = new Vector2(bodyPlace.position.x, bodyPlace.position.y);
                                    giraffeLocked = true;
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
                break;

            case "Crocodile":
                {
                    if (Input.touchCount > 0 && !crocodileLocked)
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
                                if (Mathf.Abs(transform.position.x - bodyPlace.position.x) <= 0.5f &&
                                    Mathf.Abs(transform.position.y - bodyPlace.position.y) <= 0.5f)
                                {
                                    transform.position = new Vector2(bodyPlace.position.x, bodyPlace.position.y);
                                    crocodileLocked = true;
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
                    break;
            case "Hippopotamus":
                {
                    if (Input.touchCount > 0 && !hippopotamusLocked)
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
                                if (Mathf.Abs(transform.position.x - bodyPlace.position.x) <= 0.5f &&
                                    Mathf.Abs(transform.position.y - bodyPlace.position.y) <= 0.5f)
                                {
                                    transform.position = new Vector2(bodyPlace.position.x, bodyPlace.position.y);
                                    hippopotamusLocked = true;
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
                break;
        }
    }
}
