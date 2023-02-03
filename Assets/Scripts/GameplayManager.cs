using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : Singleton<GameplayManager>
{

    public int m_points =0;

    public int _points
    {
        get { return m_points; }
        set
        {
            m_points = value;

        }
    }



    // Start is called before the first frame update
    void Start()
    {
        _points= 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
