
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Gamemanager gameManger;

    void OnTriggerEnter()
    {
        gameManger.CompleteLevel();
    }
}
