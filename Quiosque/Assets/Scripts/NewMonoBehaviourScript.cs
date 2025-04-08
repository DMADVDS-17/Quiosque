using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    [SerializeField]
    private Button leftBtn;
    [SerializeField]
    private Button rightBtn;

    private int Spacing = 840; //800 da largura + 40 spacing 

    private void MoveBar(int value)
    {
        var currentPosition = this.GetComponent<RectTransform>().localPosition;
        var newPosition = currentPosition;
        newPosition.x += value;
        this.transform.localPosition = newPosition;
        Debug.Log(newPosition.x);

        if (newPosition.x >= 1090.616)
        {
            leftBtn.interactable = false;
        }
        else
        {
            leftBtn.interactable = true;
        }

        //TODO: Terminar o Código para fazer disable ao botão da direita.
        if (newPosition.x <= -587.3843)
        {
            rightBtn.interactable = false;
        }
        else
        {
            rightBtn.interactable = true;
        }
        Debug.Log(newPosition.x); 
    }

    public void MoveLeft()
    {
        MoveBar(Spacing);
    }

    public void MoveRight()
    {
        MoveBar(-Spacing);
    }
}