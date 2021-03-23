using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartLevelButton : MonoBehaviour
{
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(RestartLevel);
    }

    // Update is called once per frame
    void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
