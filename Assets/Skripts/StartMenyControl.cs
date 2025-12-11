using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenyControl : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
