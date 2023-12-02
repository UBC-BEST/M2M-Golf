using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeagueButUI : MonoBehaviour
{
   [SerializeField] private string nextStep = "LeagueScene";

   public void LeagueButton()
   {
        SceneManager.LoadScene(nextStep);
   }
}
