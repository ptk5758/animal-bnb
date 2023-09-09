using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GuestManager guestManager;

    private void Awake()
    {
        
    }

    public void SummonButtonAction()
    {
        guestManager.SummonGuest();
    }
    
}
