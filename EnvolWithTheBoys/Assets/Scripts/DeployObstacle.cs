using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployObstacle : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(obstacleWave());
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(obstaclePrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * -2, Random.Range(-screenBounds.y + 2.5f, screenBounds.y - 1f));
    }

    IEnumerator obstacleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
