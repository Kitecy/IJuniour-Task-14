using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyMovement _enemyMover;
    [SerializeField] private DistanceChecker _distanceChecker;
    [SerializeField] private Stalker _stalker;
    [SerializeField] private Health _health;

    private void OnEnable()
    {
        _health.Died += OnDied;
    }

    private void OnDisable()
    {
        _health.Died -= OnDied;
    }

    private void Update()
    {
        if (_distanceChecker.TargetInFieldOfView())
            _stalker.GoToTarget();
        else
            _enemyMover.Move();
    }

    private void OnDied()
    {
        Destroy(gameObject);
    }
}
