using UnityEngine;
using System;

namespace Colortribes.FightSystem
{
    public interface IColorable
    {
        public event Action<Dummy> DestroyDummy;
        public Transform Transform { get; }
        public ColorType ColorType { get; }
        public void ChangeColor(ColorType colorType);
        public void Damage();
    }
}
