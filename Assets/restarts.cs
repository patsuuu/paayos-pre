using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restarts : MonoBehaviour
{
    // Start is called before the first frame update
    void Starts()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ResetTheScores()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("The button is workings.");
    }
}
