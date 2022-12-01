using System.Collections;
using System.Collections.Generic;
using ScriptableObj;
using UnityEngine;
using UnityEngine.UI;

public class CardPresenter : MonoBehaviour
{
    public Card card;

    public Text name;
    public Image image;
    public Text Description;
    void Start()
    {
        name.text = card.name;
        image.material.mainTexture = card.Photo;
        Description.text = card.Description;
    }

   
    void Update()
    {
        
    }
}
