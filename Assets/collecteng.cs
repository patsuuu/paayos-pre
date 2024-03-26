using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectstar : MonoBehaviour
{

    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        ScoredSystem.yheScore += 50;
        Destroy(gameObject);

    }
}
