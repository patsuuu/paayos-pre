using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoredSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int yheScore;


    void Update()
    {

        scoreText.GetComponent<Text>().text = "HONEY: " + yheScore;


    }
}
