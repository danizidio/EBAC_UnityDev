using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Modulo3 : MonoBehaviour
{
    System.Action<int> OnChangeNumber;

    [SerializeField] TMP_Text _txt;

    int _n;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            OnChangeNumber?.Invoke(-1);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            OnChangeNumber?.Invoke(1);
        }
    }

    void ChangeNumber(int a)
    {
        _n += a;

        _txt.text = _n.ToString();
    }

    private void OnEnable()
    {
        OnChangeNumber = ChangeNumber;
    }
}
