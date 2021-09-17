using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployShield : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float respawnTime = 45.0f;
    private Vector2 screenBounds;
    private static int maxfloat;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(Shield());
    }

    private void spawnShield()
    {
        GameObject a = Instantiate(obstaclePrefab) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
    }

    IEnumerator Shield()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnShield();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
