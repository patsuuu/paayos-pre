using UnityEngine;
using System.Collections;


public class EnemySpawn : MonoBehaviour{
    public GameObject enemy;
    public Transform enemyPos;
    private float repeatRate = 5.0f;

    void Start() {
    }
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                InvokeRepeating("EnemySpawner", 0.5f, repeatRate);
                Destroy(gameObject, 11);
                gameObject.GetComponent<BoxCollider>().enabled = false;
            }
        }
        void EnemySpammer()
        {
            Instantiate(enemy, enemyPos.position, enemyPos.rotation);
        }
    }

