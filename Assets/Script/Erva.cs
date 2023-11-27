using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Erva : Item
{
    [SerializeField] Color _color;
    
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        _color = Color.red;
    }

    // Update is called once per frame
   public void PegarNome(string value)
    {
        nome = value;
    }
}
