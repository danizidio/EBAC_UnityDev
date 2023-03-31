using UnityEngine;
using TMPro;
public class Módulo4 : MonoBehaviour
{
    System.Action<Animals> OnChangeNumber;

    [SerializeField] TMP_Text _txt;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            OnChangeNumber?.Invoke(Animals.DOG);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            OnChangeNumber?.Invoke(Animals.CAT);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            OnChangeNumber?.Invoke(Animals.LION);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            OnChangeNumber?.Invoke(Animals.WOLF);
        }
    }

    void ChangeNumber(Animals a)
    {
        switch(a)
        {
            case Animals.CAT:
                {
                    _txt.text = "Your Animal is a " + a + "!!";

                    break;
                }
            case Animals.DOG:
                {
                    _txt.text = "Your Animal is a " + a + "!!";
                    break;
                }
            case Animals.LION:
                {
                    _txt.text = "Your Animal is a " + a + "!!";
                    break;
                }
            case Animals.WOLF:
                {
                    _txt.text = "Your Animal is a " + a + "!!";
                    break;
                }
        }

    }

    private void OnEnable()
    {
        OnChangeNumber = ChangeNumber;
    }
}
