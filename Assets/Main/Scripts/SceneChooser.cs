using System.IO;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChooser : MonoBehaviour
{
    [SerializeField]
    private Button buttonPrefab;
    [SerializeField]
    private RectTransform content;

    private void Awake()
    {
        Enumerable.Range(0, SceneManager.sceneCountInBuildSettings)
                  .Select(SceneUtility.GetScenePathByBuildIndex)
                  .Where(path => SceneManager.GetSceneByPath(path).buildIndex != 0)
                  .Foreach(CreateButtonForScene);
    }

    private void CreateButtonForScene(string scenePath)
    {
        var button = Instantiate(buttonPrefab, content);
        var sceneName = Path.GetFileNameWithoutExtension(scenePath);
        button.gameObject.SetActive(true);
        button.GetComponentInChildren<Text>().text = sceneName;
        button.name = sceneName;
        button.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(scenePath);
        });
    }
}
