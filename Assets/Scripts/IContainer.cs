using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IContainer<T, K>
{
    public Dictionary<T, K> Get { get; set; }
    public void Init();
}
