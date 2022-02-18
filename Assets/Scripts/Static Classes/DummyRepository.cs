using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DummyRepository
{
    public static List<Dummy> Dummies = new List<Dummy>();

    public static void AddDummy(Dummy dummy)
    {
        Dummies.Add(dummy);
    }

    public static void RemoveDummy(Dummy dummy)
    {
        Dummies.Remove(dummy);
    }

    public static IColorable GetNearestDummy(ColorType type, Vector3 position)
    {
        
        float distance = float.PositiveInfinity;
        Dummy nearestColorableObject = null;
        foreach (Dummy dummy in Dummies)
        {
            var newDistance = Vector3.Distance(dummy.transform.position, position);
            if (newDistance < distance && dummy.ColorType != type)
            {
                distance = newDistance;
                nearestColorableObject = dummy;
            }
        }
        return nearestColorableObject;
    }
}
