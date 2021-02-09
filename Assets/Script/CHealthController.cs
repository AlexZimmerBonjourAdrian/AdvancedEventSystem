using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
public class CHealthController : MonoBehaviour
{

    public UnityEvent OnHealthChange;

    public UnityEvent OnDeath;

    [SerializeField]
    private CHealth _health;



    // Start is called before the first frame update
    void Start() => _health.init();

    private void OnTriggerEnter(Collider other)
    {
        var currentHealth = _health.Damage(2);
        OnHealthChange.Invoke();

        if(currentHealth < 1)
        {
            OnDeath.Invoke();
        }

    }

    // Update is called once per frame
    
}
