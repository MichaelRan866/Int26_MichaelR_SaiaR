using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
    
    public string description;
    public UnityEvent onClick;
    private GameObject clickPrompt;

    public Player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        onClick.Invoke();
        
    }

    public void AddToInv()
    {
        player.inventory.Add(this);
        gameObject.SetActive(false);
    }
    
}
