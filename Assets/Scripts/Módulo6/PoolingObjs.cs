using System.Collections.Generic;
using UnityEngine;

public class PoolingObjs : MonoBehaviour
{
    [SerializeField] int _maxquantity;
    
    [SerializeField] GameObject[] _objs;

    [SerializeField] List<GameObject> _poolingObjects;


    private void Awake()
    {
        StartPooling();
    }

    void StartPooling()
    {
        _poolingObjects = new List<GameObject>();
        for (int i = 0; i < _maxquantity; i++)
        {
            GameObject temp = Instantiate(_objs[Random.Range(0, _objs.Length)], transform);
            temp.SetActive(false);
            _poolingObjects.Add(temp);
        }
    }

    public GameObject GetPoolObj()
    {
        for (int i = 0; i < _maxquantity; i++)
        {
            if(!_poolingObjects[i].activeInHierarchy)
            {
                return _poolingObjects[i];
            }
        }

        return null;
    }
}
