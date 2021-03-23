using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButton : MonoBehaviour
{
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(LoadMainMenu);
    }

    // Update is called once per frame
    void LoadMainMenu()
    {
        SceneManager.LoadScene(1);
    }
}
