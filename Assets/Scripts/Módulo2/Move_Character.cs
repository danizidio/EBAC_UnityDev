using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Character : MonoBehaviour
{
    Animator _anim;
    Rigidbody _rb;
    [SerializeField] float _moveSpeed;

    bool _isWalking;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _rb = GetComponentInChildren<Rigidbody>();
    }

    void LateUpdate()
    {
        if(Input.GetKey(KeyCode.A))
        {
            _rb.velocity = new Vector3(-1 * _moveSpeed, 0, this.transform.position.y);
            
            _anim.SetBool("Walking", true);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            _rb.velocity = new Vector3(1 * _moveSpeed, 0, this.transform.position.y);

            _anim.SetBool("Walking", true);
        }

        else if (Input.GetKey(KeyCode.W))
        {
            _rb.velocity = new Vector3(this.transform.position.y, 0, 1 * _moveSpeed);

            _anim.SetBool("Walking", true);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            _rb.velocity = new Vector3(this.transform.position.y, 0, -1 * _moveSpeed);

            _anim.SetBool("Walking", true);
        }
        else
        {
            _anim.SetBool("Walking", false);
        }
    }
}
