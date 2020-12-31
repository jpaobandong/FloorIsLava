using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelClearScript : MonoBehaviour
{
    float seconds;
    // Start is called before the first frame update
    void Start()
    {
        seconds = 3f;
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void nextLevel() {
        int lastLevel = PlayerPrefs.GetInt("currentLevel");
        if (lastLevel == 3) SceneManager.LoadScene("End Scene");
        else SceneManager.LoadScene(lastLevel + 1);
    }


}
