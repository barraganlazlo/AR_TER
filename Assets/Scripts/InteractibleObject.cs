using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractibleObject : MonoBehaviour
{
    public Piece piece;
    public TextMeshPro worldTMProName;

    private void Start()
    {
        if(worldTMProName!=null) worldTMProName.text = piece.name;
    }
    private void OnMouseDown()
    {        
        if (!EventSystem.current.IsPointerOverGameObject()) // si le pointer n'est pas sur un élément d'ui
        {
            UIManager.instance.UpdateContent(piece);
            UIManager.instance.ActivateUI();
            Debug.Log("y");
        }
    }
}
