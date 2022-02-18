using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour, IColorable
{
    [SerializeField] private MeshRenderer _dummyRenderer;

    public ColorType ColorType { get; private set; }

    public Transform Transform => transform;

    public void ChangeColor(ColorType colorType)
    {
        ColorType = colorType;
        _dummyRenderer.material = Containers.MaterialsContainer.Get[ColorType];
    }

    public void StartFighting()
    {
        if (ColorType == ColorType.Neutral)
        {
            DestroyThisDummy();
        }
        else
        {

        }    
    }

    private void DestroyThisDummy()
    {
        DummyRepository.RemoveDummy(this);
        Destroy(gameObject);//change to death
    }
}
