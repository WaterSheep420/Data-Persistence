using UnityEngine;
using UnityEngine.UI;

public class SetPlayerText : MonoBehaviour
{
    [SerializeField] private Text playerText;
    void Start()
    {
        playerText.text = "Player : " + DataManager.Instance.playerName;
    }
}
