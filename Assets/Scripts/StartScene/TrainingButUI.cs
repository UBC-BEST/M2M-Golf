using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrainingButUI : MonoBehaviour
{
   [SerializeField] private string nextStep = "TrainingScene";

   public void TrainingButton()
   {
        SceneManager.LoadScene(nextStep);
   }
}
