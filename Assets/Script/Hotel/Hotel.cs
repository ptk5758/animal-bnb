using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Hotel
{
    private static Hotel instance;
    public static Hotel Instance {
        get {
            if (instance == null)
                instance = Object.FindObjectOfType<BaseHotel>();
            return instance;
        }
        set { instance = value; }
    }
}
