using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : EnemyBase
{
    [Header("Patrol")]

    [SerializeField] Transform _pointA;
    [SerializeField] Transform _pointB;
    Transform _toGo;

    private void Start()
    {
        _toGo = _pointA;

        GetLife();
    }

    void LateUpdate()
    {
        Patrolling();    
    }

    void Patrolling()
    {
        rb.MovePosition(Vector3.MoveTowards(transform.position, _toGo.position, attributes.speed * Time.deltaTime));
    }

    void WhereToGo()
    {
        if (_toGo.position == _pointA.position)
        {
            _toGo = null;

            _toGo = _pointB;
        }

        else if(_toGo.position == _pointB.position)
        {
            _toGo = null;

            _toGo = _pointA;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PatrolPoint"))
        {
            WhereToGo();
        }
    }
}
