using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] Enemy;

    private int zpos;
    private int xpos;
    private int EnemyCount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnEnemy");
    }

    IEnumerator SpawnEnemy()
    {
        while (EnemyCount < 5)
        {
            xpos = Random.Range(-493, -227);
            zpos = Random.Range(-93, 17);
            int rand = Random.Range(0,Enemy.Length);
            Instantiate(Enemy[rand], new Vector3(xpos, 16, zpos), Quaternion.identity);
            SoundManager.instance.TuyulSpawn();
            
            yield return new WaitForSeconds(2);
            EnemyCount += 1;
        }
    }
}
