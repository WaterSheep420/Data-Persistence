using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_InputField playerNameInput;
    public void StartGame()
    {
        DataManager.Instance.playerName = playerNameInput.text;

        SceneManager.LoadScene(1);
    }
}
