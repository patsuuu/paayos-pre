
using UnityEngine;

public class SwipeRotate : MonoBehaviour
{
    private Touch touch;
    private Vector2 touchPosition;
    private Quaternion rotationY;
    private float rotateSpeedModifier = 0.1f;
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                rotationY = Quaternion.Euler(touch.deltaPosition.y * rotateSpeedModifier, -touch.deltaPosition.x * rotateSpeedModifier, 0f);

                transform.rotation = rotationY * transform.rotation;
            }
        }
    }
}