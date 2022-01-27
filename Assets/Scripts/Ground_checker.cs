using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_checker : MonoBehaviour
{

    Player _player;

    // Start is called before the first frame update
    void Awake()
    {
        _player = GameObject.Find("Mario").GetComponent<Player>();
    }

    void OnTriggerStay2D(Collider2D col)
    {

        _player.tocaSuelo = true;
        _player.animatronix.SetBool("Salto", false);

    }

    void OnTriggerExit2D(Collider2D col)
    {

        _player.tocaSuelo = false;

    }

}
