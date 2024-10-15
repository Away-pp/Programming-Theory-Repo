using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Brick : MonoBehaviour
{
    public UnityEvent<int> onDestroyed;

    protected int m_PointValue;
    public virtual int PointValue // ENCAPSULATION    
    {
        set { m_PointValue = value; }
        get { return m_PointValue; }
    }    

    void Start()
    {
        var renderer = GetComponentInChildren<Renderer>();
        renderer.SetPropertyBlock(createBlockProperty(m_PointValue)); // ABSTRACTION
    }

    private void OnCollisionEnter(Collision other)
    {
        DestroyAndGetPoint();
    }

    protected virtual MaterialPropertyBlock createBlockProperty(int pointValue) // ABSTRACTION
    {
        //MaterialPropertyBlock block = new MaterialPropertyBlock();
        Block blockClass = new Block();
        switch (m_PointValue)
        {
            case 1:
                blockClass = new GreenBlock();
                //block.SetColor("_BaseColor", Color.green);
                break;
            case 2:
                blockClass = new YellowBlock();
                //block.SetColor("_BaseColor", Color.yellow);
                break;
            case 5:
                blockClass = new BlueBlock();
                //block.SetColor("_BaseColor", Color.blue);
                break;
            default:
                blockClass = new Block();
                //block.SetColor("_BaseColor", Color.red);
                break;
        }
        blockClass.setColor(); // POLYMORPHISM
        return blockClass.block;
    }

    protected void DestroyAndGetPoint()
    {
        onDestroyed.Invoke(m_PointValue);

        //slight delay to be sure the ball have time to bounce
        Destroy(gameObject, 0.2f);
    }
}
