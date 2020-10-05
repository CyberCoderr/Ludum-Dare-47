using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstical_Spawner : MonoBehaviour
{
    [SerializeField] private GameObject Obstical;
    [SerializeField] private GameObject Obstical_2;

    [SerializeField] private GameObject PowerUp_1;
    private GameObject PowerUp_Instance;

    private GameObject Obstical_Instance;

    public float WaitTime = 0.8f;   

    void Start()
    {
        StartCoroutine(SpawnObstacleCoroutine());
        StartCoroutine(SpawnPowerUpCoroutine());
    }

    void SpawnObstacle()
    {
    	float random_num = Random.Range(-7f, 7f);
    	int random_int = Random.Range(0, 2);
    	transform.position = new Vector3(random_num, transform.position.y, transform.position.z);
    	if (random_int == 0)
    	{
    		Obstical_Instance = Instantiate(Obstical, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
    	}
    	if (random_int == 1)
    	{
    		Obstical_Instance = Instantiate(Obstical_2, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
    	}
    }

    void SpawnPowerUp()
    {
        float random_num = Random.Range(-7f, 7f);
        int random_int = Random.Range(1, 11);
        transform.position = new Vector3(random_num, transform.position.y, transform.position.z);
        if (random_int == 5)
        {
            PowerUp_Instance = Instantiate(PowerUp_1, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        }
    
    }

    IEnumerator SpawnObstacleCoroutine()
    {
    	yield return new WaitForSeconds(WaitTime);
    	SpawnObstacle();
        yield return new WaitForSeconds(WaitTime);
        SpawnObstacle();
        yield return new WaitForSeconds(WaitTime);
        SpawnObstacle();
        foreach (var obstacle in GameObject.FindGameObjectsWithTag("Obstacle"))
        {
            if (obstacle.gameObject.transform.position.y < -7f)
            {
                Destroy(obstacle);
            }
        }
        if (WaitTime > 0.4f)
        {
            WaitTime -= 0.03f;
        }
        StartCoroutine(SpawnObstacleCoroutine());
    }

    IEnumerator SpawnPowerUpCoroutine()
    {
        yield return new WaitForSeconds(2f);
        SpawnPowerUp();
        yield return new WaitForSeconds(2f);
        Destroy(PowerUp_Instance);
        StartCoroutine(SpawnPowerUpCoroutine());
    }
}
