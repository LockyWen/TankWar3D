using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Tools
{
    public static Transform FindChildByName(this Transform parent, string name)
    {
        if(parent.name == name)
        {
            return parent;
        }

        if(parent.childCount == 0)
        {
            return null;
        }

        Transform target = null;
        target.Find(name);
        if(target != null)
        {
            return target;
        }

        for(int i = 0; i < parent.childCount; i++)
        {
            target = FindChildByName(parent.GetChild(i), name);
        }

        return target;
    }
}
