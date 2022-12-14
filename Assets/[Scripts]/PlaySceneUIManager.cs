using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySceneUIManager : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickSave()
    {
        SaveLoadManager.SavePlayer(Player.GetComponent<Player>());
    }

    public void OnClickLoad()
    {
        PlayerData data = SaveLoadManager.LoadPlayer();
        Vector2 savedPosition = new Vector2(data.position[0], data.position[1]);
        Player.transform.position = savedPosition;
    }
}
