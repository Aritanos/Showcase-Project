using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Projectile : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private MeshRenderer _meshRenderer;

    private ProjectileProperties _properties;

    public void Init(ProjectileProperties properties)
    {
        _properties = properties;
        _meshRenderer.material = Containers.MaterialsContainer.Get[_properties.ColorType];
        SetVelocity();
        Destroy(gameObject, 5);
    }

    private void SetVelocity()
    {
        _rb.velocity = _properties.Speed * _properties.Direction;
    }

    private void OnTriggerEnter(Collider other)
    {
        var colorable = other.GetComponent<IColorable>();
        if (colorable != null)
        {
            colorable.ChangeColor(_properties.ColorType);
            Destroy(this.gameObject);
        }
        if (other.gameObject.layer == LayerMask.NameToLayer(Constants.ENVIRONMENT_LAYER))
        {
            Destroy(this.gameObject);
        }
    }
}
