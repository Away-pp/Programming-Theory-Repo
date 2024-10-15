using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI BestScoreText;
    public TMP_InputField PlayerNameInput;
    // Start is called before the first frame update
    void Start()
    {
        if(DataManager.playerName != null)
        {
            BestScoreText.text = "Best Score\n" + DataManager.playerName + " " + DataManager.highestScore;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        DataManager.currentPlayer = PlayerNameInput.text;
        SceneManager.LoadScene(Constants.mainSceneName);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif        
    }
}
