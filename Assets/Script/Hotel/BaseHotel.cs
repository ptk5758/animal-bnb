using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHotel : MonoBehaviour, Hotel
{
    private void Awake()
    {
        if (Hotel.Instance == this)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
