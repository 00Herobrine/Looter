using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetworkStartUI : MonoBehaviour
{
    [SerializeField] Button startHostButton;
    [SerializeField] Button startClientButton;

    void Start()
    {
        startHostButton.onClick.AddListener(StartHost);
        startClientButton.onClick.AddListener(StartClient);
    }

    void StartHost()
    {
        NetworkManager.Singleton.StartHost();
        Hide();
    }

    void StartClient()
    {
        NetworkManager.Singleton.StartClient();
        Hide();
    }

    void Hide() => gameObject.SetActive(false);
}
