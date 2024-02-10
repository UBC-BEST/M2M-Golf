using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
//using DG.Tweening;

public class GolfClubScript : MonoBehaviour
{
    [SerializeField] GameObject GolfClub;
    [SerializeField] Rigidbody2D golfClubBody;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Sprite goldClubSprite; 
    //[SerializeField] GameEvent; add
    [SerializeField] Vector2 startingPosition = new Vector2(2, 2);
    //[SerializeField] float moveTime = 2.0f; 

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.sprite = goldClubSprite;
        //transform.DOMove(startingPosition, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
