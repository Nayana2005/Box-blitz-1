
using UnityEngine;
using UnityEngine.UI;

public class scoreacript : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
