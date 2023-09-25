using UnityEngine;

public class CuttingTree : MonoBehaviour
{
    [SerializeField] float cutTime;
    private bool isCutting = false;
    private float timer  = 0.0f;
    

   


    private void Update()
    {
        if(isCutting)
        {
            timer += Time.deltaTime;

            if(timer >= cutTime)
            {
                CutTree();
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCutting();
            


        }
    }

    // Calling StartCutting Function
    public void StartCutting()
    {
        isCutting= true;
        
    }

    // Calling CutTree Function
    public void CutTree()
    {
        Destroy(gameObject);
        
    }

   

}
