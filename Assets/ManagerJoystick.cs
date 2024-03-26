using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ManagerJoystick : MonoBehaviour, IDragHandler
{
    public Transform player;
    public float speed = 5f;

    private Image imgJoystickBg;
    private Image imgJoystick;
    private Vector2 posInput;

    void Start()
    {
        imgJoystickBg = GetComponent<Image>();
        imgJoystick = transform.GetChild(0).GetComponent<Image>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
            imgJoystickBg.rectTransform,
            eventData.position,
            eventData.pressEventCamera,
            out posInput))
        {
            posInput.x = posInput.x / (imgJoystickBg.rectTransform.sizeDelta.x);
            posInput.y = posInput.y / (imgJoystickBg.rectTransform.sizeDelta.y);
            Debug.Log(posInput.x.ToString() + "/" + posInput.y.ToString());

            // normalize
            if (posInput.magnitude > 1.0f)
            {
                posInput = posInput.normalized;
            }
            // joystick move
            imgJoystick.rectTransform.anchoredPosition = new Vector2(
                posInput.x * (imgJoystickBg.rectTransform.sizeDelta.x / 4),
                posInput.y * (imgJoystickBg.rectTransform.sizeDelta.y / 4));
        }
    }

    

       
    }
