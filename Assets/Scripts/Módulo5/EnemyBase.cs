using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyBase : MonoBehaviour
{
    Rigidbody _rb;
    protected Rigidbody rb { get { return _rb; } }

    [SerializeField] TMP_Text _lifeText;

    [SerializeField] EnemyAttributes _attributes;
    protected EnemyAttributes attributes { get { return _attributes; } }

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();    
    }

    protected void GetLife()
    {
        _lifeText.text = "My Current Life is... " + attributes.maxLife;
    }
}
