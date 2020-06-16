using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackToSceneChooser : MonoBehaviour
{
    [SerializeField]
    private Scene chooserScene;
    [SerializeField]
    private Button backButton;

    private void Awake()
    {
        backButton.onClick.AddListener(Back);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Back();
        }
    }

    private void Back()
    {
        SceneManager.LoadScene(0);
    }
    
}
