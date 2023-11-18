using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    //public Rigidbody2D trainingButtonBody;
    //public Rigidbody2D leagueButtonBody;
    public Button trainingBtn;
    public Button leagueBtn;

    public Vector2 startingPositionTrain = new Vector2(0, 1f);
    public Vector2 startingPositionLeague = new Vector2(0, -1f);

    void Start()
    {
        //leagueButtonBody.position = startingPositionLeague;
        Button btnT = trainingBtn.GetComponent<Button>();
        Button btnL = leagueBtn.GetComponent<Button>();
		btnT.onClick.AddListener(TaskOnClick);
		btnL.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(sceneName:"TrainingScene");
        
    }
}
