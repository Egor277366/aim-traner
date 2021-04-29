using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ScreneManagement;

public class Menu : MonoBehaviour
    
    public void PlayGame
    {
    ScreneManagement.LoadScrene(ScreneManager.GetActiveScrene().buildIndex +1);
    }
