
using UnityEngine;

public class EndTriggerscript : MonoBehaviour
{
    public GameManagerscript  gameManager;
    void OnTriggerEnter(){
        gameManager.CompeteLevel();
    }
}
