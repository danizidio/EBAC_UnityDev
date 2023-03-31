using UnityEngine;

public class CallObjects : MonoBehaviour
{
    [SerializeField] PoolingObjs _poolManager;

    [SerializeField] Transform[] _spawnPoints;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SpawnObj();
        }
    }

    void SpawnObj()
    {
        GameObject temp = _poolManager.GetPoolObj();
        
        if (temp == null) return;

        temp.SetActive(true);
        temp.GetComponent<SpawnedObj>().CallToScene();
        temp.transform.position = _spawnPoints[Random.Range(0, _spawnPoints.Length)].position;
    }
}
