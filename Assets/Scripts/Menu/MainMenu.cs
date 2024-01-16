using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshProUGUI bestTimeText;
    [SerializeField] private GameObject levelSelecter;
    [SerializeField] private GameObject mainMenu;

    private void Start()
    {
        int score = GameManager.Instance.bestTimeManager.GetTotalTime();
        if (score > 0)
        {
            bestTimeText.gameObject.SetActive(true);
            bestTimeText.text = "High Score : " + score.ToString();
        }
     }
    public void StartGame()
    {
        GameManager.Instance.LoadGame();
    }
    public void QuitGame()
    {
        GameManager.Instance.QuitGame();
    }
    public void LevelSelect()
    {
        levelSelecter.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void Back()
    {
        levelSelecter.SetActive(false);
        mainMenu.SetActive(true);
    }
}
