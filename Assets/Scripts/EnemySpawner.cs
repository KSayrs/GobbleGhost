using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnEnemy(Vector2 location)
    {
        //Randomly select enemy
        int i = Random.Range(0, enemy.Length - 1);

        Vector2 v2Pos = location;
        Instantiate(enemy[i], v2Pos, transform.rotation);
       // Debug.Log(enemy[i].name);
    }
}
