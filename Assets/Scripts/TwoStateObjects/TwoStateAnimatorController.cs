using UnityEngine;

public class TwoStateAnimatorController : TwoStateObject
{
    [SerializeField] private string enabledStateName = "IsEnabled";
    [SerializeField] private bool initialize = true;

    private int enableStateHash;
    private int initializeStateHash;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        enableStateHash = Animator.StringToHash(enabledStateName);
        if (initialize)
        {
            initializeStateHash = Animator.StringToHash("IsInitialized");
        }
    }

    public override void Enable()
    {
        if (!enabled) return;
        base.Enable();
        OnStateChanged(true);
    }

    public override void Disable()
    {
        if (!enabled) return;
        base.Disable();
        OnStateChanged(false);
    }

    private void OnStateChanged(bool isEnabled)
    {
        animator.SetBool(enableStateHash, isEnabled);
        animator.SetBool(initializeStateHash, true);
    }

}
