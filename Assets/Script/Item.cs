using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] int tipo;
    [SerializeField] protected string nome;
    [SerializeField] Animator _anim;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        _anim = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
