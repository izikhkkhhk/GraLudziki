using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelection : MonoBehaviour
{
    // Start is called before the first frame update
    public void SelectIsrael()
    {
        GameManager.instance.StartGame(Side.Israel);
    }
    public void SelectPalestine()
    {
        GameManager.instance.StartGame(Side.Palestine);
    }
}
