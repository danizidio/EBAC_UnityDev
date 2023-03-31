using UnityEngine;

[CreateAssetMenu]
public class EnemyAttributes : ScriptableObject
{
    [SerializeField] int _maxLife;
    public int maxLife { get { return _maxLife; } }
    [SerializeField] float _speed;
    public float speed { get { return _speed; } }
}
