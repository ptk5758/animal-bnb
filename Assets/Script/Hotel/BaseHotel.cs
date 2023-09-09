using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHotel : MonoBehaviour, Hotel
{

    private static int MAX_COUNT = 12;
    private static List<GameObject> animals = new List<GameObject>();

    public void Summon(GameObject prefab)
    {
        if (CheckSummon()) {
            GameObject obj = GameObject.Instantiate(prefab);
            animals.Add(obj);
        } else {
            Debug.Log("최대 접대 가능 인원 12임");
        }
        
    }

    private bool CheckSummon()
    {
        bool result = true;
        if (animals.Count >= MAX_COUNT) result = false;
        return result;
    }

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
