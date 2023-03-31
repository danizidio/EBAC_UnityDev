
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    [SerializeField] GameObject _objToManipulate;

    public void TurnObjOn()
    {
        _objToManipulate.SetActive(true);
    }

    public void TurnObjOff()
    {
        _objToManipulate.SetActive(false);
    }

    public void ManipulateViaUnityButtons(bool b)
    {
        _objToManipulate.SetActive(b);
    }
}
