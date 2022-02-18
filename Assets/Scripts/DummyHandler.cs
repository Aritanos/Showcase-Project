using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyHandler : MonoBehaviour
{
    [SerializeField] private List<Dummy> _dummies = new List<Dummy>();

    public void Init()
    {
        foreach (Dummy dummy in _dummies)
        {
            DummyRepository.AddDummy(dummy);
        }
    }

    public void StartFighting()
    {

    }
}
