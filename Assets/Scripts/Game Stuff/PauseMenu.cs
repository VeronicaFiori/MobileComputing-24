using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused;
    private bool muted;
    public GameObject pausePanel;
    public string mainMenu;

    [SerializeField]
    public TextMeshProUGUI mutotext;

    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("pause"))
        {
            ChangePause();
        }

    }

    public void ChangePause()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (!isPaused)
        {

            pausePanel.SetActive(false);
            Time.timeScale = 1f;
        }
        if (muted)
        {
            AudioListener.volume = 0;
            mutotext.text = "Audio";
        }
        else if (!muted)
        {
            AudioListener.volume = 1;
            mutotext.text = "Muto";
        }

    }

    public void QuitToMain()
    {
        SceneManager.LoadScene(mainMenu);
        Time.timeScale = 1f;
    }

    public void Mute()
    {
        muted = !muted;

        if (muted)
        {
            AudioListener.volume = 0;
            mutotext.text = "Audio";
        }
        else if (!muted)
        {
            AudioListener.volume = 1;
            mutotext.text = "Muto";
        }
    }

}
