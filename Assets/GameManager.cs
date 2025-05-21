using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Side {Israel,Palestine };
public class GameManager : MonoBehaviour
{
    public Side side;
    public static GameManager instance = null;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        
        if (instance == null)
            instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    public void NewGame()
    {
        SceneManager.LoadScene("CharacterSelection");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void StartGame(Side s)
    {
        side = s;
        SceneManager.LoadScene("SampleScene");
    }
}
