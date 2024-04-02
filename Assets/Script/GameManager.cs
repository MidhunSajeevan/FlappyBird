using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public UnityAction OnGameOver;
    [SerializeField] GameObject GameOverPanel;
    void Start()
    {
       
        Time.timeScale = 1.0f;
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        OnGameOver += ShowPopUp;
    }

   
    private void ShowPopUp()
    {
        GameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void OnPlayButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
