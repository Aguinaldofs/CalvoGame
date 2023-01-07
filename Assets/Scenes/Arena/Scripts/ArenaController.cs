using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaController : MonoBehaviour
{
  // Start is called before the first frame update
  public bool isKilled = false;
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space) && Time.time < 10 && isKilled == false)
    {
      Animator anim = GetComponent<Animator>();
      anim.SetBool("isKilled", true);
      GameObject enemy = GameObject.Find("Enemy");
      Animator enemyAnim = enemy.GetComponent<Animator>();
      enemyAnim.SetBool("isKilled", true);
      isKilled = true;

    }
    else if (Time.time > 10 && isKilled == false)
    {
      Animation anim = GetComponent<Animation>();
      anim.Play("Die");
      Debug.Log("You died in the arena");
      isKilled = true;
    }

  }

  //back to the original animation
  public void BackToIdle()
  {
    Animator anim = GetComponent<Animator>();
    anim.SetBool("isKilled", false);
    GameObject enemy = GameObject.Find("Enemy");
    Animator enemyAnim = enemy.GetComponent<Animator>();
    enemyAnim.SetBool("isKilled", false);
    isKilled = false;
  }

}
