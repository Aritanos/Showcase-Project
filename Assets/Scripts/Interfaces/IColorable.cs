using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IColorable
{
    public Transform Transform { get; }
    public ColorType ColorType { get; }
    public void ChangeColor(ColorType colorType);
}
