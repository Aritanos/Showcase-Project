using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummySpawner : MonoBehaviour
{
    private Dummy _enemyDummyPrefab;

    public Dummy SpawnDummy()
    {
        return Instantiate(_enemyDummyPrefab);
    }
}
