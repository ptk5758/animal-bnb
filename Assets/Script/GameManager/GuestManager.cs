using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GuestManager
{
    [SerializeField]
    List<GameObject> prefabs;

    internal void SummonGuest()
    {
        // Debug.Log(prefabs[0]);
        Hotel.Instance.Summon(prefabs[0]);
    }
}
