using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoringsystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;


    void Update()
    {

        scoreText.GetComponent<Text>().text = "HONEY: " + theScore;


    }
}
