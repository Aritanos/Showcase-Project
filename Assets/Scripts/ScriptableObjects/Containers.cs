using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Main Container", menuName = "Containers/Main")]
public class Containers : ScriptableObject
{
    [SerializeField] private MaterialsContainer _materialsContainer;
    [SerializeField] private PrefabsContainer _prefabsContainer;

    public static MaterialsContainer MaterialsContainer { get; private set; }
    public static PrefabsContainer PrefabsContainer { get; private set; }

    public void Init()
    {
        MaterialsContainer = _materialsContainer;
        PrefabsContainer = _prefabsContainer;

        _materialsContainer.Init();
        _prefabsContainer.Init();

    }
}
