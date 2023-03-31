using UnityEngine;

public class SpawnedObj : MonoBehaviour
{
    [SerializeField] float _timeToBeOff;

    public void CallToScene()
    {
        Invoke(nameof(BeingOff), _timeToBeOff);
    }

    void BeingOff()
    {
        gameObject.SetActive(false);
    }
}
