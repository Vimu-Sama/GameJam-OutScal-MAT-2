using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Enemy List")]
    [SerializeField] List<GameObject> enemies = new List<GameObject>();
    [Header("Enemy Spawn Confirguration")]
    [SerializeField] float timeBetweenSpawn = 4f;
    [Header("Player Position")]
    [SerializeField] Transform player;
    float timeElapsed= 0f;

    private void FixedUpdate()
    {
        if(timeElapsed>=timeBetweenSpawn)
        {
            int indexofEnemy = SelectRandom();
            SpawningEnemy(indexofEnemy);
            timeElapsed = 0f;
        }
        timeElapsed += Time.fixedDeltaTime;
    }

    int SelectRandom()
    {
       int numOfElements= enemies.Count;
        return Random.Range(0,numOfElements);

    }

    void SpawningEnemy(int i)
    {
        float x, y;
        if(player!=null)
        {
            do
            {
                x = Random.Range(transform.position.x - 40f, transform.position.x + 40f);
                y = Random.Range(transform.position.x - 30f, transform.position.x + 30f);
            } while ((x < player.position.x - 25f) && (x > player.position.x + 25f) &&
            (y < player.position.y - 20f) && (y > player.position.y + 20f));
            Instantiate(enemies[i], new Vector3(x, y, transform.position.z), Quaternion.identity);
        }
        
    }

}
