using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    private float Xmove;
    private float Ymove;
    [SerializeField] private Transform PlayerBody;
    public Vector2 LookAxis;
    public float Sensivity = 40f;
    void Start()
    {

    }


    void Update()
    {
        Xmove = LookAxis.x * Sensivity * Time.deltaTime;
        PlayerBody.Rotate(Vector3.up * Xmove);

    }
}
