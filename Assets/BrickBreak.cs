using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBreak : MonoBehaviour
{
    // Start is called before the first frame update
  private SpriteRenderer sr;

// The sprite to change into
public Sprite explodedBlock;

// Use this for initialization
void Start()
{

sr = GetComponent<SpriteRenderer>();
}
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
{
// Check if the collision hit the bottom of the block
if (other.gameObject.tag == "Player" && other.GetContact(0).point.y < transform.position.y){

sr.sprite = explodedBlock;


Object.Destroy(gameObject, .2f);
}
}
}