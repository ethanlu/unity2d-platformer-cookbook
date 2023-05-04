using System;
using Dummy.Animations;
using Dummy.States;
using Utils;
using UnityEngine;

namespace Dummy
{
    [RequireComponent(typeof(BoxCollider2D))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class Dummy : MonoBehaviour
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // customizable fields

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // unity components

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // internal properties

        private DummyStateMachine _stateMachine;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // internal methods

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // getters

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // event delegates

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // core unity behavior
        
        protected void Awake()
        {
        }

        protected void Start()
        {
            _stateMachine = new DummyStateMachine(
                GetComponent<Rigidbody2D>(),
                GetComponent<BoxCollider2D>(),
                GameObject.Find("DummyVisual").GetComponent<DummyAnimator>(),
                GameObject.Find("DummyHitBox").GetComponent<DummyHitBox>(),
                GameObject.Find("DummyHurtBox").GetComponent<DummyHurtBox>()
            );
            _stateMachine.Start(DummyStateMachine.NormalState);
        }
        
        protected void Update()
        {
            
        }
        
        protected void FixedUpdate()
        {
        }
    }
}